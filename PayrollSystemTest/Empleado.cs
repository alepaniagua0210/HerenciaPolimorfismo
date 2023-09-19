using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    public abstract class Empleado
    {
        public string PrimerNombre { get;} 
        
        public string SegundoNombre { get;}

        public string SocialSecurityNumber { get;}

        public Empleado(string firstName, string lastName, string SCN) {
        
            firstName = PrimerNombre;

            lastName = SegundoNombre;

            SCN = SocialSecurityNumber;
        }

        // return string representation of Employee object, using properties 
        public override string ToString()
        {
            return $"{PrimerNombre} {SegundoNombre}\n" + 
                   $"social security number : {SocialSecurityNumber}"; 
        }

        public abstract decimal Earnings();

    }
}
