using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using PhysicProject.Optics;


namespace PhysicProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string studentName = Console.ReadLine();

            string name = "i am from this place and i love this city";

            foreach (var number in name)
            {
                Console.WriteLine("Character in Student name is " + number);


            }

            Console.ReadLine();

        }

    }
}
