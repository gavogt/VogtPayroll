using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll
{
    class Employee
    {
        private string _name;
        private int _totalWorkingHours;
        private decimal _payrate;

        public Employee(string name, int totalWorkingHours, decimal payRate)
        {
            _name = name;
            _totalWorkingHours = totalWorkingHours;
            _payrate = payRate;
        }

        public Employee GetEmpInfo()
        {
            // allow user to enter employee name, total working hours and payrate

            Console.WriteLine("What is the employee's name?");
            var empName = Console.ReadLine();

            Console.WriteLine("What is the employee's total working hours?");
            var empTotalWorkingHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the employee's payrate?");
            var empPayRate = Convert.ToDecimal(Console.ReadLine());

            Employee employee = new Employee(empName, empTotalWorkingHours, empPayRate);

            return employee;

        }

        public void ComputeGrossPay(Employee employee)
        {
            // compute gross pay use formula Employee gross pay = hours worked times hourly payrate
            decimal grossPay;


        }

        public void ComputePaidFedTax()
        {
            // compute amount of money emp should pay as fed tax. use formula employee paid fed taxes = 30% of gross pay
        }

        public void ComputePaidStateTax()
        {
            // compute money which should pay as state tax. use formula emp paid state taxes 10% of gross pay
        }

        public void ComputeNetPay()
        {
            // compute net pay. use formula employee net pay = employee gross pay - (paid fed tax + paid state tax)
        }

        public void PrintEmpInfo()
        {
            // emp name
            // emp total working hours
            // emp hourly pay
            // emp paid fed taxes
            // emp paid state taxes
            // emp net pay
        }

    }
}
