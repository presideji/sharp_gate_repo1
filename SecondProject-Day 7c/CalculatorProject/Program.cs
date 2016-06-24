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
          
            Compute compute = new Compute();  //instatiation
            compute.Add(8, 2);
         }

       
    }


}
