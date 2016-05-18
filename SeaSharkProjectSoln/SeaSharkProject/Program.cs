using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;

namespace SeaSharkProject
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Elephant elephant = new Elephant();
            Elephant elephant = new Elephant("Edwin", "Loveth", "Anney", "Hitler");
            //now lets go back to elephant in facebook--Elephant

            string name =  elephant.GetFirstStudentName();
            Console.WriteLine(name);

            Elephant pigeon = new Elephant("Avan Rolf", "Jeff Morgan", "Roy Fielding", "David cameron");
            string name1 = pigeon.GetFirstStudentName();
            Console.WriteLine(name1);

        }
    }
}
