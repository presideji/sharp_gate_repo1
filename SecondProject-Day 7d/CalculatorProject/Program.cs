using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    internal class Program
    {
        //user must be able to enter input from console line
        //should be able to take integer input
        //Should be able to add whatever number a user enter
        //display result
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number please");
            string num1 = Console.ReadLine();
            int num1Int = int.Parse(num1);

            Console.WriteLine("Enter your second number please");
            string num2 = Console.ReadLine();
            int num2Int = int.Parse(num2);

            Calculator calculator = new Calculator();

           long d =  calculator.Add(num1Int, num2Int);

            Console.WriteLine("The answer is " +d);
            Console.ReadKey();








        }

       
    }


}
