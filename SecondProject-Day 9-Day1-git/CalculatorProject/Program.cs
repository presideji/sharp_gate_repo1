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

            Console.WriteLine(Calculator.serialNo);

            long n = Calculator.Add(5, 2);
           

            Calculator calculator = new Calculator(num1Int, num2Int);

          // long d =  calculator.Add(num1Int, num2Int);
            long d = calculator.Multiply();
            Console.WriteLine("The answer is " +d);

            long d1 = calculator.Divide();
            Console.WriteLine("The answer is " + d1);
            Console.ReadKey();
            







        }

       
    }


}
