using System;

namespace VogtPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Development Branch!");
            var employee = GetEmpInfo();

            employee.PrintEmpInfo(employee);
        }

        #region GetEmpInfo
        /// <summary>
        /// Get employee information
        /// </summary>
        /// <returns>an employee object</returns>
        public static Employee GetEmpInfo()
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
        #endregion
    }
}
