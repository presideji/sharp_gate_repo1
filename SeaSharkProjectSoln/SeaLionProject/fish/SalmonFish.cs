using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaLionProject.fish
{
   public class SalmonFish
    {

        protected string myFirstName = "deji";
        private string myLastName = "Aki";
        private string myNickName = "DJ";



        public void ShowMyFirstname()
        // the zero in the bracket below is called interpolation. this means.
        // at the run time of the belwo take whatsoever is in "myFirstName"
        // and put it in {0}
        // you can place another interpolation. Just put one in the bracket.
        {
            Console.WriteLine("My First name is {0} and my Last name is{1} with Nick name as {2}", myFirstName,
                myLastName, myNickName);
            Console.WriteLine("My real age is {0}", CalculateMyAge());
        }

        private int CalculateMyAge()

        {
            int ageConstant = 55;
            int myAge = ageConstant - 23;
            return myAge;

        }


    }
}
