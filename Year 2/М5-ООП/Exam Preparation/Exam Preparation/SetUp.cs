using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_Preparation.Products;
using Exam_Preparation.Storage;
using Exam_Preparation.Vehicle;

namespace Exam_Preparation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StorageMaster storageMaster = new StorageMaster();
            string[] command;

            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
                try
                {
                    switch (command[0])
                    {
                        case "AddProduct":
                            {
                                Console.WriteLine(storageMaster.AddProduct(command[1], double.Parse(command[2])));
                                break;
                            }
                        case "RegisterStorage":
                            {
                                Console.WriteLine(storageMaster.RegisterStorage(command[1], command[2]));
                                break;
                            }
                        case "SelectVehicle":
                            {
                                Console.WriteLine(storageMaster.SelectVehicle(command[1], int.Parse(command[2])));
                                break;
                            }
                        case "LoadVehicle":
                            {
                                List<string> names = new List<string>();
                                for (int i = 1; i < command.Length; i++)
                                {
                                    names.Add(command[i]);
                                }
                                Console.WriteLine(storageMaster.LoadVehicle(names));
                                break;
                            }
                        case "SendVehicleTo":
                            {
                                Console.WriteLine(storageMaster.SendVehicleTo(command[1], int.Parse(command[2]), command[3]));
                                break;
                            }
                        case "UnloadVehicle":
                            {
                                Console.WriteLine(storageMaster.UnloadVehicle(command[1], int.Parse(command[2])));
                                break;
                            }
                        case "GetStorageStatus":
                            {
                                Console.WriteLine(storageMaster.GetStorageStatus(command[1]));
                                break;
                            }
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            } while (command[0] != "END");
            Console.WriteLine(storageMaster.GetSummary());
        }
    }
}