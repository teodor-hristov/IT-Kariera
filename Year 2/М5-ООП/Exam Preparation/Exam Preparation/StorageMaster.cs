using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Exam_Preparation.Products;
using Exam_Preparation.Storage;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation
{
    public class StorageMaster
    {
        static List<Product> pool = new List<Product>();
        static KeyValuePair<string, int> currentVehicle = new KeyValuePair<string, int>();
        static Dictionary<string, Storage.Storage> storages = new Dictionary<string, Storage.Storage>();

        public string AddProduct(string type, double price)
        {
            string result = string.Empty;
            try
            {
                Product product = null;
                switch (type)
                {
                    case "Gpu":
                        product = new Gpu(price);
                        break;
                    case "HardDrive":
                        product = new HardDrive(price);
                        break;
                    case "Ram":
                        product = new Ram(price);
                        break;
                    case "SolidStateDrive":
                        product = new SolidStateDrive(price);
                        break;
                }
                if (pool == null)
                {
                    throw new InvalidOperationException("Invalid product type!");
                }
                pool.Add(product);
                result = $"Added {type} to pool";
            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";
            }
            return result;
        }
        public string RegisterStorage(string type, string name)
        {
            string result = string.Empty;
            try
            {
                Type storageType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);

                if (storageType == null)
                {
                    throw new InvalidOperationException("Invalid storage type!");
                }
                var storage = (Storage.Storage)Activator.CreateInstance(storageType, new object[] { name });
                storages.Add(name, storage);
                result = $"Registered {name}";
            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";
            }
            return result.Trim();
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            string result = String.Empty;
            try
            {
                var current = storages[storageName].GetVehicle(garageSlot);
                currentVehicle = new KeyValuePair<string, int>(storageName, garageSlot);

                result = $"Selected {current.GetType().Name}";

            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";

            }
            return result;
        }

        public string LoadVehicle(IEnumerable<string> products)
        {
            string result = string.Empty;
            int loadedProductsCount = 0;
            try
            {
                foreach (var productName in products)
                {
                    if (!pool.Any(x => x.GetType().Name == productName))
                    {
                        throw new InvalidOperationException($"{productName} is out of stock!");
                    }
                    else
                    {
                        var product = pool.Last(x => x.GetType().Name == productName);

                        storages[currentVehicle.Key].GetVehicle(currentVehicle.Value).LoadProduct(product);
                        loadedProductsCount++;
                        pool.Remove(product);
                    }
                }
                result = $"Loaded {loadedProductsCount}/{products.Count()} products into {storages[currentVehicle.Key].GetVehicle(currentVehicle.Value).GetType().Name}";

            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";

            }
            return result;
        }
        public string UnloadVehicle(string storageName, int garageSlot)
        {
            string result = string.Empty;
            try
            {
                int unloadedProductsCount = storages[storageName].UnloadVehicle(garageSlot);
                result = $"Unloaded {unloadedProductsCount}/{storages[storageName].Products.Count} products at {storageName}";
            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";

            }
            return result;
        }
        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            string result = string.Empty;

            try
            {

                if (!storages.ContainsKey(sourceName))
                {
                    throw new InvalidOperationException("Invalid source storage!");
                }
                if (!storages.ContainsKey(destinationName))
                {
                    throw new InvalidOperationException("Invalid destination storage!");
                }
                Vehicle.Vehicle vehicleType = storages[sourceName].GetVehicle(sourceGarageSlot);
                int destinationGarageSlot = storages[sourceName].SendVehicleTo(sourceGarageSlot, storages[destinationName]);
                result = $"Sent {vehicleType.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
            }
            catch (Exception e)
            {
                result = $"Error: {e.Message}";

            }
            return result;

        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sb = new StringBuilder();
            Storage.Storage storage = null;

            foreach (var item in storages)
            {
                if(item.Key == storageName)
                {
                    storage = item.Value;
                    break;
                }
            }

            double allProductsWeight = storage.Products.Sum(p => p.Weight);
            var sortedProducts = storage
                .Products
                .GroupBy(c => c.GetType().Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .ToList();

            List<string> sortedProductsToString = new List<string>();
            foreach (var product in sortedProducts.OrderByDescending(p => p.Count).ThenBy(p => p.Name))
            {
                sortedProductsToString.Add($"{product.Name} ({product.Count})");
            }

            sb.AppendLine(string.Format("Stock ({0}/{1}): [{2}]", allProductsWeight, storage.Capacity, string.Join(", ", sortedProductsToString)));

            List<string> vehicleInGarage = new List<string>();
            foreach (Vehicle.Vehicle vehicl in storage.Garage)
            {
                if (vehicl == null)
                {
                    vehicleInGarage.Add("empty");
                }
                else
                {
                    vehicleInGarage.Add(vehicl.GetType().Name);
                }
            }

            sb.AppendLine(string.Format("Garage: [{0}]", string.Join("|", vehicleInGarage)));
            return sb.ToString().Trim();


        }
        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var storage in storages.OrderByDescending(x => x.Value.Products.Sum(p => p.Price)))
            {
                sb.AppendLine($"{storage.Key}:");
                sb.AppendLine($"Storage worth: ${storage.Value.Products.Sum(x => x.Price):F2}");
            }
            return sb.ToString();
        }
    }
}
