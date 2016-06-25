using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person deji = new Person();

            
            deji.GoToMeeting();
            deji.Walk();
            deji.Eat();
            deji.Talk();

            Person ruth = new Person();
            ruth.Eat();


            Bird eagle = new Bird();
            Bird dove = new Bird();


        }
    }
}
