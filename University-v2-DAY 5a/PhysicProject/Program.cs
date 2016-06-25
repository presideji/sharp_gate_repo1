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
           Console.WriteLine("Enter the room temperature");
           string roomTemp = Console.ReadLine();
            int roomTemperature = int.Parse(roomTemp);
            while (roomTemperature < 20)
            {
                if (roomTemperature == 16)
                {
                    Console.WriteLine("The room Temperture is still below expectation and therefore the AC is still on");
                    Console.WriteLine("The room temperature is " + roomTemperature);
                    break;
                }
                roomTemperature = roomTemperature + 2;

                }
            }


       }
    
}
