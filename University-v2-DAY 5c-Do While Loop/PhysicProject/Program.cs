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
            string roomTep = Console.ReadLine();

            int bodyTemperature = int.Parse(roomTep);

            do
            {
                Console.WriteLine("Inject a patient with ansthetics who has body temp of " + bodyTemperature);
                bodyTemperature ++;
            } while (bodyTemperature <= 36);


        }

    }
}
