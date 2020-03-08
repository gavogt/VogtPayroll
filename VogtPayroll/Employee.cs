using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll
{
    class Employee
    {
        // Fields
        private string _name;
        private int _totalWorkingHours;
        private decimal _payrate;

        // CTOR
        public Employee(string name, int totalWorkingHours, decimal payRate)
        {
            _name = name;
            _totalWorkingHours = totalWorkingHours;
            _payrate = payRate;
        }

        #region ComputeGrossPay
        /// <summary>
        /// Computes gross pay
        /// </summary>
        /// <returns>gross pay</returns>
        private decimal ComputeGrossPay()
        {
            // compute gross pay use formula Employee gross pay = hours worked times hourly payrate
            decimal grossPay;

            grossPay = _totalWorkingHours * _payrate;

            return grossPay;

        }
        #endregion

        #region ComputePaidFedTax
        /// <summary>
        /// Computes paid federal tax
        /// </summary>
        /// <returns>paid fed tax</returns>
        private decimal ComputePaidFedTax()
        {
            decimal grossPay;
            decimal paidFedTax;
            // compute amount of money emp should pay as fed tax. use formula employee paid fed taxes = 30% of gross pay

            grossPay = ComputeGrossPay();

            paidFedTax = grossPay * .30m;

            return paidFedTax;

        }
        #endregion

        #region ComputePaidStateTax
        /// <summary>
        /// Computes paid state tax
        /// </summary>
        /// <returns>paid state tax</returns>
        private decimal ComputePaidStateTax()
        {
            decimal grossPay;
            decimal paidStateTax;
            // compute money which should pay as state tax. use formula emp paid state taxes 10% of gross pay

            grossPay = ComputeGrossPay();

            paidStateTax = grossPay * .10m;

            return paidStateTax;

        }
        #endregion

        #region ComputeNetPay
        /// <summary>
        /// Computes net pay
        /// </summary>
        /// <returns>net pay</returns>
        private decimal ComputeNetPay()
        {
            decimal grossPay;
            decimal netPay;
            decimal paidFedTax;
            decimal paidStateTax;
            // compute net pay. use formula employee net pay = employee gross pay - (paid fed tax + paid state tax)

            grossPay = ComputeGrossPay();
            paidFedTax = ComputePaidFedTax();
            paidStateTax = ComputePaidStateTax();

            netPay = grossPay - (paidFedTax + paidStateTax);

            return netPay;

        }
        #endregion region

        #region PrintEmpInfo
        /// <summary>
        /// Prints employee information
        /// </summary>
        /// <param name="employee">employee object passed in</param>
        public void PrintEmpInfo(Employee employee)
        {
            // emp name
            // emp total working hours
            // emp hourly pay
            // emp paid fed taxes
            // emp paid state taxes
            // emp net pay
            Console.WriteLine($"Employee name: {employee._name}");
            Console.WriteLine($"Employee total working hours: {employee._totalWorkingHours}");
            Console.WriteLine($"Employee payrate: {employee._payrate}");
            Console.WriteLine($"Federal Taxes Paid: {ComputePaidFedTax()}");
            Console.WriteLine($"State Taxes Paid: {ComputePaidStateTax()}");
            Console.WriteLine($"Netpay: {ComputeNetPay()}");

        }
        #endregion

    }
}
