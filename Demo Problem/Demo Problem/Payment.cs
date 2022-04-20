using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Problem
{
    internal class Payment
    {
        public void monthlyPayment(double p, double y, double r)
        {
            double rateOfIntrest = r / (12 * 100);
            double n = 12 * y;
            double payment = (p * rateOfIntrest) / (1 - Math.Pow((1 + rateOfIntrest), (-n)));
            Console.WriteLine( "Monthly Payment Is " +payment);
            
        }
    }
}
