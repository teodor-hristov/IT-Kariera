using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._6
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee(string employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment)
        : base(employeeID, employeeAddress, employeeName)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;
        }

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }

        public override double CalculateSalary(int workingHours)
        {
            double temp = 250 + workingHours * 20;
            return temp;
        }

        public override string GetDepartment() => this.EmployeeDepartment;


        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Employee position: {EmployeeTask}");
        }
    }
}
