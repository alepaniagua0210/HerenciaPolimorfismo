using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    public class SalariedEmployee : Empleado
    {

        private decimal weeklySalary; 
        public SalariedEmployee(string firstName, string lastName, string SCN, decimal weeklySalary) : base(firstName, lastName, SCN)
        {
            this.weeklySalary = weeklySalary;

        }

        public decimal WeeklySalary 
        {
            get 
            { 
                return weeklySalary; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                          $"{nameof(weeklySalary)} must be >= 0");
                
                }
                weeklySalary = value;
            } 
            
        }
        public override decimal Earnings() => weeklySalary;

        public override string ToString()
        {
            return $"salaried emloyee : {base.ToString()}\n" + $"week salary : {weeklySalary: C}"; 
        }


    }
}
