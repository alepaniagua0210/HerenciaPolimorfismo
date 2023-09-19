using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    public class ComissionEmployee : Empleado
    {
        private decimal grossSales;

        private decimal comissionRate;
        public ComissionEmployee(string firstName, string lastName, string SCN, decimal grossSales, decimal comissionRate) : base(firstName, lastName, SCN)
        {
            GrossSales = grossSales;
            ComissionRate = comissionRate;  

        }

        public decimal GrossSales { get => grossSales;
            set 
            {
                if (value < 0) {
                    throw new ArgumentException(nameof(value), $"{nameof(GrossSales)} must be >=0"); 
                
                }
                grossSales = value;
            }
        }
        public decimal ComissionRate { get => comissionRate;
            set
            {
                if (value <= 0 || value >= 1) {

                    throw new ArgumentException(nameof(value), $"{nameof(ComissionRate)} must be >=0 and < 1 ");
                }
                comissionRate = value;
            }
        }

        public override decimal Earnings() => ComissionRate * GrossSales;


        public override string ToString() => $"comission employee : {base.ToString()}\n" + $"gross sales : {GrossSales:C}\n" +
            $"comission rate : {ComissionRate:F2}\n";
       

    }
}
