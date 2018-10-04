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
        private Vehicle.Vehicle[] garage;
        private List<Product> products;
        
        public Storage(string name, int capacity, int garageSlots,params Vehicle.Vehicle[] vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.Garage = vehicles;
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

        public bool IsFull
        {
            get
            {
                if (this.Garage.Length == this.GarageSlots)
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

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle.Vehicle vehicle = this.GetVehicle(garageSlot);
            if (this.IsFull == false)
            {
                for (int i = 0; i < deliveryLocation.Garage.Length; i++)
                {
                    if (deliveryLocation.Garage[i] == null)
                    {

                        deliveryLocation.Garage[i] = vehicle;
                        deliveryLocation.GarageSlots--;
                        this.Garage[garageSlot] = null;
                        this.GarageSlots++;
                        return i;
                    }
                }
            }

            throw new InvalidOperationException("No room in garage!");

        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.GarageSlots >= garageSlot) throw new InvalidOperationException("Storage is full!");
            else
            {
                int brProducts = 0;
                while (GetVehicle(garageSlot).IsEmpty != false)
                {
                    this.Products.Add(GetVehicle(garageSlot).Unload());
                    brProducts++;
                }
                return brProducts;
            }
        }

    }
}

