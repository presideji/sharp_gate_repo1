using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaLionProject.fish;

namespace SeaSharkProject.access_modifier
{
    //Access mofifier talks about classes, methods and fields(but lets call it 
    // variables)
    //Anytime you create variable in C # it stays without access modifiers. this is becos
    // theywant you to decide how the class will be

     public class Swim :SalmonFish
     {

         public void SeaLionStuff()

         {
            //Console.WriteLine("This is the lion firstname {0}", ); 

           // SalmonFish salFish = new SalmonFish();
             //salFish.ShowMyFirstname();

             Console.WriteLine(myFirstName);
         }
    }
}

