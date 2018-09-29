using System;
using System.Collections.Generic;
using System.Text;
using Exam_Preparation.Vehicle;


namespace Exam_Preparation.Storage
{
    abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private List<Vehicle.Vehicle> garage;
        private List<Product> products;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle.Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.Garage = new List<Vehicle.Vehicle>(GarageSlots);
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public List<Vehicle.Vehicle> Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public bool IsFull
        {
            get
            {
                if(this.Garage.Count == this.GarageSlots)
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
                return isFull;
            }
            set { isFull = value; }
        }

        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Vehicle.Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            else if (!IsFull)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            else
            {
                return this.Garage[garageSlot];
            }
        }
    }
}
