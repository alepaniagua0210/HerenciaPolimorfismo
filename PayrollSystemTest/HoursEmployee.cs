using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    public class HoursEmployee : Empleado
    {
        private decimal wage;

        private decimal hours; 
        public HoursEmployee(string firstName, string lastName, string SCN, decimal hourlyWage, decimal hoursWorked) : base(firstName, lastName, SCN)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }

        public decimal Wage 
        { get => wage;
            set 
            {
                if (value < 0) {
                    throw new ArgumentException(nameof(value), 
                          $"{nameof(Wage)} must be >= 0");
                
                
                }


                wage = value; 
            }  
        }

        public decimal Hours 
        { get => hours; 
            set 
            {
                if (value < 0) {

                    throw new ArgumentException(nameof(value), 
                        $"{nameof(Hours)} must be >=0 and <= 168"); 
                    
                } 
                
                hours = value; 
            }
        }

        public override decimal Earnings()
        {
            if (Hours <= 40) return Wage * Hours;

            else return (40 * Wage) + ((Hours - 40) * Wage * 1.5M); 
        }

        public override string ToString()
        {
            return $"hourly employee : {base.ToString()}\n" + $"hourly wage : {Wage:C}\n hours worked {Hours:F2}";
        }
    }
}
