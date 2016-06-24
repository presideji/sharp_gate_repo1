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

           Console.WriteLine("enter your choice of meal");
           int mealChoice = 5;
           switch (mealChoice)
           {
                case 1:
                   Console.WriteLine("The price is $500");
                   break;

                case 2:
                    Console.WriteLine("The price is $300");
                    break;
                default:
                   Console.WriteLine("That food is not sold here and we don't have proce for it");
                   break;
           }
       }
    }
}
