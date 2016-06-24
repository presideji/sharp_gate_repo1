using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Compute
    {
        private int _a;
        private int _b;
        public Compute()

        {
            _a = 5;
            _b = 10;

        }


       /* public void Add()
        {
            int a = 100;
            double b = 50;

            double c = a + b;

            Console.WriteLine("The answer is" +c);

        }
        */
       /* public void Add(int a, int b)
        {
           double c = a + b;

            Console.WriteLine("The answer is " + c);

        }
        */
        public double Add(int a, int b)
        {
            double c = a + b;
            return c;



        }

    }
}
