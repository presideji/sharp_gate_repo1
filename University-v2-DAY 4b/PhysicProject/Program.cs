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
       public static void Main(string[] args)
       {
           Console.WriteLine("Enter your name password: ");
            string customerName = Console.ReadLine();

            if (customerName.Equals("dj"))
           {
               Console.WriteLine("You live in UK");
           }
            else if (customerName.Equals("tope"))
            {
                Console.WriteLine("Lives in london");
            }
            else
            {
                Console.WriteLine("There is no such person in the class");
            }
       }
    }
}
