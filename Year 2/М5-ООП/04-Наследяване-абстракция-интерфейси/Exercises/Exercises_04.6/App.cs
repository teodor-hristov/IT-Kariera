using System;

namespace Exercises_04._6
{
    class App
    {
        static void Main()
        {
            BaseEmployee contractEmployee = new ContractEmployee("1","Ernest", "Lovec, Bulgaria street","Cleaning bathroom","Lovec");

            Console.WriteLine("Contract employee");
            contractEmployee.Show();
            contractEmployee.CalculateSalary(400);
            contractEmployee.GetDepartment();

            BaseEmployee fullTimeEmployee = new FullTimeEmployee("2", "Radoslav", "Sofia, Green srt 15", "CEO", "Sofia");
            Console.WriteLine("Full time employee");
            fullTimeEmployee.Show();
            fullTimeEmployee.CalculateSalary(400);
            fullTimeEmployee.GetDepartment();
           

        }
    }
}
