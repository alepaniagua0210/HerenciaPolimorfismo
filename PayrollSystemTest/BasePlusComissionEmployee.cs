using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    public class BasePlusComissionEmployee : ComissionEmployee
    {
        private decimal baseSalary; 
        public BasePlusComissionEmployee(string firstName, string lastName, string SCN, decimal grossSales, decimal comissionRate,
            decimal baseSlary) 
            : base(firstName, lastName, SCN, grossSales, comissionRate)
        {

            BaseSalary = baseSalary;

        }

        public decimal BaseSalary 
        {
            get => baseSalary;
            set
            {
                if (value < 0) {
                    throw new ArgumentException(nameof(value), $"{nameof(BaseSalary)} must be >=0");

                }

                baseSalary = value;
            } 
        }

        public override decimal Earnings() => BaseSalary + base.Earnings();

        public override string ToString() => $"base salaried {base.ToString()}\n " + $"base salary : {BaseSalary:C}";
    }
}
