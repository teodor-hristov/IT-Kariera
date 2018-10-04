using System;
using System.Collections.Generic;
using System.Linq;
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
        private Vehicle.Vehicle[] garage;
        private List<Product> products;
        
        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle.Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.Garage = new Vehicle.Vehicle[this.GarageSlots];

            for (int i = 0; i < vehicles.ToList().Count; i++)
            {
                this.garage[i] = vehicles.ToList()[i];
            }
            this.Products = new List<Product>();
            
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public Vehicle.Vehicle[] Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;


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
            else if (this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            else
            {
                return this.Garage[garageSlot];
            }
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle.Vehicle vehicle = this.GetVehicle(garageSlot);

            if (!this.Garage.Any(g => g == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[garageSlot] = null;

            int freeSlot = 0;
            for (int i = 0; i < deliveryLocation.garage.Length; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    freeSlot = i;
                    break;
                }
            }

            deliveryLocation.garage[freeSlot] = vehicle;
            return freeSlot;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle.Vehicle vehicle = this.GetVehicle(garageSlot);

            int unloadedProducts = 0;
            foreach (Product product in vehicle.Trunk)
            {
                if (!vehicle.IsEmpty)
                {
                    if (!this.IsFull)
                    {
                        this.products.Add(product);
                        unloadedProducts++;
                    }
                }
            }

            return unloadedProducts;
        }
       
    }
}

