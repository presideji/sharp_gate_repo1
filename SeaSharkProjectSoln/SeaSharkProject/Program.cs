using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaLionProject.fish;
using SeaSharkProject.access_modifier;
using SeaSharkProject.basics;
using SeaSharkProject.calf;
using SeaSharkProject.facebook;
using SeaSharkProject.gettersAndSetters;

namespace SeaSharkProject
{
    class Program
    {

        public static void Main(string[] args)
        {

            Eagle eagle = new Eagle();

           string result =  eagle.eaglename;
            Console.WriteLine(result);



        }

    }


}


