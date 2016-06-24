using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharkProject.access_modifier
{
    public class Hop : Swim

    {
        /* public void GetMyNames()

       { /*
           
            // Let us instanciate swim below
            Swim swim = new Swim();
            swim.
            swim.ShowMyFirstname();
            */
        /* Swim swim = new Swim();
           swim.myLastName = "DEJ 1";
            swim.
            
    }
    */

        public void GetStuffsFromTheMainClass()
        {

            Console.WriteLine("my first name is {0}", myFirstName);
            ShowMyFirstname();

        }

    }

}

       
    
