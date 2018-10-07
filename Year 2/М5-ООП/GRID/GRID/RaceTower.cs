using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRID
{

    public class RaceTower
    {
        int GlobalLapsNumber;
        int GlobalTrackLength;
        int GlobalCurrentLap;
        private Dictionary<string, Driver> racingDrivers = new Dictionary<string, Driver>();
        private readonly List<Driver> dnf = new List<Driver>();

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            GlobalLapsNumber = lapsNumber;
            GlobalTrackLength = trackLength;
        }


        public void RegisterDriver(List<string> commandArgs)
        {
            try
            {

                string driverType = commandArgs[0];
                string name = commandArgs[1];
                int hp = int.Parse(commandArgs[2]);
                double fuelAmount = double.Parse(commandArgs[3]);
                string typeTyre = commandArgs[4];
                double typeHardness = double.Parse(commandArgs[5]);

                Tyre tyre = null;
                Car car = new Car(hp, fuelAmount, tyre);
                Driver driver = null;

                switch (typeTyre)
                {
                    case "UltrasoftTyre":
                        tyre = new UltrasoftTyre(name, typeHardness);
                        break;
                    case "HardTyre":
                        tyre = new HardTyre(typeHardness);
                        break;
                }



                switch (driverType)
                {
                    case "AggressiveDriver":
                        driver = new AggressiveDriver(name, car);
                        break;
                    case "EnduranceDriver":
                        driver = new EnduranceDriver(name, car);
                        break;
                }
                //Driver driver = new Driver(driverType, name, car);
                if (typeTyre == "Ultrasoft")
                {


                }


                this.racingDrivers.Add(name, driver);
            }
            catch (Exception)
            {
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            commandArgs.RemoveAt(0);
            string reasonToBox = commandArgs[0];
            string driversName = commandArgs[1];
            if (reasonToBox == "ChangeTyres")
            {
                Tyre tyre;
                string changeTyre = commandArgs[2];
                double tyreHardness = double.Parse(commandArgs[3]);
                if (changeTyre == "Ultrasoft")
                {
                    double grip = double.Parse(commandArgs[4]);
                    tyre = new UltrasoftTyre(tyreHardness, grip);
                }
                else
                {
                    tyre = new HardTyre(tyreHardness);
                }
                foreach (Driver driver in racingDrivers.Values)
                {
                    if (driver.Name == driversName)
                    {
                        driver.Car.Tyre = tyre;
                    }
                }
            }
            if (reasonToBox == "Refuel")
            {
                double fuelToFill = double.Parse(commandArgs[2]);
                foreach (Driver driver in racingDrivers.Values)
                {
                    if (driver.Name == driversName)
                    {
                        driver.Car.FuelAmount += fuelToFill;
                    }
                }
            }
        }

        public string CompleteLaps(List<string> commandArgs)
        {

            int numberOfLaps = int.Parse(commandArgs[0]);
            if (numberOfLaps > GlobalLapsNumber)
            {
                throw new ArgumentException("Invalid number of laps!");
            }
            foreach (var item in racingDrivers.Values)
            {
                item.TotalTime = 60 / (GlobalTrackLength / (int)item.Speed);
                item.Fuel = GlobalTrackLength * item.FuelConsumationPerKm;
                item.Car.Tyre.Degradate();
            }
            return $"Lap {numberOfLaps}/{GlobalLapsNumber}";
        }

        public string GetLeaderboard()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Lap {this.GlobalCurrentLap}/{this.GlobalLapsNumber}");

            int position = 1;
            foreach (Driver driver in racingDrivers.Values
                .OrderBy(d => d.TotalTime))
            {
                result.AppendLine($"{position} {driver.Name} {driver.TotalTime:F3}");
                position++;
            }
            
            result.Remove(result.Length - 1, 1);
            return result.ToString();
        }
    }
}