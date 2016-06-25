using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using PhysicProject.Optics;


namespace PhysicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition, Multiplication, Division, Substraction, Modulus

            short num1 = 2;
            int num2 = 1000;
            double num3 = 50;

            //  double ans = num1 + num2 + num3;
            // double ans = num1 * num2 * num3;
            // double ans = num1 * num2 / num3;
            double ans = num1 + num2 - num3;
            Console.WriteLine(ans);


        }
    }
}
