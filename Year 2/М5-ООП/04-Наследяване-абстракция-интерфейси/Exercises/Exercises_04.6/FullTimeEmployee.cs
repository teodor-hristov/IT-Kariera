using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._6
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(string employeeID,string employeeName,string employeeAddress,string employeePosition,string employeeDepartment)
        :base(employeeID,employeeAddress,employeeName)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        public override double CalculateSalary(int workingHours)
        {
            double temp = 250 + workingHours * 10.80;
            return temp;
        }

        public override string GetDepartment() => this.EmployeeDepartment;
        

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Employee position: {EmployeePosition}" +
                $"\n Employee department: {EmployeeDepartment}");
        }
    }
}
