using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharkProject.calf
{
    class CalfRunner
    {

        public void CRunner()
        {
            Console.WriteLine("Please enter your first number?");
            string number1 = Console.ReadLine();
            double num1 = double.Parse(number1);

            Console.WriteLine("Please select what would you like to do");
            Console.WriteLine("please select +, -, /");
            string operatorInCal = Console.ReadLine();


            Console.WriteLine("Please enter your second number?");
            string number2 = Console.ReadLine();
            double num2 = double.Parse(number2);

            LogicOperation casio = new LogicOperation(num1, num2); // instanciation
            //or instanciation of a class. once this process happens an object
            // is created.

            //LogicOperation sharp = new LogicOperation(num1, num2);
            //sharp here is another new object. different object can be created but you 
            //cannot create same object twice


            if (operatorInCal.Equals("+"))
            {
                double an = casio.Add();
                Console.WriteLine(an);


            }
            else if (operatorInCal.Equals("/"))
            {
                double an = casio.Divide();
                Console.WriteLine(an);
            }
            else
            {
                throw new Exception("There is no such operation in this software");

            }
        }
    }
}


     


