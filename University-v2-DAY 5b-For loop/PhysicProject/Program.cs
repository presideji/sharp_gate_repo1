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
           string roomTemp = Console.ReadLine();
            int roomTemperature = int.Parse(roomTemp);
            
           for (int i = 0; i < roomTemperature; i++)
            //you can also say for (int i = 0; i < 4; i+1)
            {
                if ((i >= 4) && (i <= 6))
                {
                    Console.WriteLine("The room temp is " + i + " which is still below expectation");
                }
                
           }

       }


       }
    
}
