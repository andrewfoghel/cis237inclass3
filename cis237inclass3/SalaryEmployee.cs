using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Variables
        private decimal _weeklySalary;

        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //Methods
        public string NameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        //Constructor
        public SalaryEmployee(string FirstName, string LastName,
            DateTime StartDate, decimal WeeklySalary)
            //This next part calls the parent classes constructor so that we dont't have
            //to repeat the work that the parent constructor is doing.
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base() { }
    }
}
