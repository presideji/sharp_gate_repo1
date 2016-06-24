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
            Console.WriteLine("Enter your Reference Temperature");
            string roomtemp = Console.ReadLine();

            int roomtemperature = int.Parse(roomtemp);
            
            for (int i = 0; i < 20; i++)
            {
                // it keep running until i=15
                if (i == 5)
                {
                    Console.WriteLine("The AC is now switched off becos temp is"+15);
                    break;
                }
                Console.WriteLine("Hello World");

                
            }

        }

    }
}
