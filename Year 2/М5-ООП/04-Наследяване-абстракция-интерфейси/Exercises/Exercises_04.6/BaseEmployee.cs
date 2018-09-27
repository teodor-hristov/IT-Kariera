using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._6
{
    abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.EmployeeAddress = employeeAddress;
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }

        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine($"Employee name: {EmployeeName} " +
                $"\n Employee address: {EmployeeAddress}" +
                $"\n Employee ID: {EmployeeID}");
        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment();



    }
}
