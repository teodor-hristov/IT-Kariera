using System;
using System.Linq;

namespace Exercises_04._3
{
    class SetUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] command;
            Circle circle;
            Square square;
            Triangle triangle;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine()
                                .Split(" ")
                                .ToArray();

                switch(command[0]){
                    case "Circle":
                         circle = new Circle(command[1], int.Parse(command[2]));
                        Console.WriteLine(circle.ToString());
                        break;
                    case "Square":
                        square = new Square(command[1], int.Parse(command[2]));
                        Console.WriteLine(square.ToString());
                        break;
                    case "Triangle":
                        triangle = new Triangle(command[1], int.Parse(command[2]));
                        Console.WriteLine(triangle.ToString());
                        break;
                }
            }
            


        }
    }
}
