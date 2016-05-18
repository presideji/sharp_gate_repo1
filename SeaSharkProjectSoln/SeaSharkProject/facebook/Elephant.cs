using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharkProject.facebook
{
    public class Elephant
    {
        //looking at constructors. now lets look at what constructors do that 
        //i do not like. lets assign a value to the string.
        private string _firstStudentName;
        private string _secondStudentName;
        private string _thirdStudentName;
        private string _fourthStudentName;
        //now lets go and instanciate elephant. lick on Program.cs


        //public Elephant()
        //if we don't know the name we can code as below
        public Elephant(string firststudentName, string secondStudentName, string thirdStudentname, string fourthStudentName)
        {
            //  _firstStudentName = "Andre";
            //  _secondStudentName = "Bukky";
            //  _thirdStudentName = "JohnBull";
            //  _fourthStudentName = "Johnson";
            _firstStudentName = firststudentName;
            _secondStudentName = secondStudentName;
            _thirdStudentName = thirdStudentname;
            _fourthStudentName = fourthStudentName;

        }
        public string GetFirstStudentName()

        {
            return _firstStudentName;
            //it will pick value in the string and return it.
            //lets go to Program,cs now



        }

    }
}
