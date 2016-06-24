using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeaSharkProject.basics
{   
    /// <summary>
    /// This class is for codes that my students are using
    /// </summary>

    public class Friday

       

        

    {
        //XML Commenting

        /// <summary>
        /// This is a method that take any new student name and greet the student!
        /// </summary>
        /// <param name="newStudentName"></param>
        /// <returns></returns>


        public string GreetNewStudent(string newStudentName)
        {
            //The first line below is taken student name and printing it out on a console
            Console.WriteLine("The new student name is " + newStudentName);
            // The code below is appending student name to the greeting
            string greeting = "Welcome, " + newStudentName + " to TrainCentre Plc and it is a pleasure to have you";
            /*Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);
            Console.WriteLine("The new Syudent name is " + newStudentName);*/
            Console.WriteLine("The new Syudent name is " + newStudentName);

            return greeting;
        }

        /// <summary>
        /// This method when called, returns your account details.
        /// </summary>

        public void CheckAccountBalance(long accountNumber, string accountSortCode)
        {

            // in this case if any cndition is correct, then I will do the job below
            if ((accountNumber == 208563) || (accountSortCode == "20-28-01"))

            {

                Console.WriteLine("The balance is $5000");
            }

            // in this case if both cndition are correct, then I will do the job below
            if ((accountNumber == 20856362) && (accountSortCode == "20-28-01"))

            {
                Console.WriteLine("The balance is $5000");
            }

        }

        
        public void DoStuff(long accountNumber, string accountSortCode)
            {
            // in this case if any cndition is correct, then I will do the job below
            if (!(accountNumber != 208563) | (accountSortCode == "20-28-01"))

            {

                Console.WriteLine("The balance is $5000");
            }

            // in this case if both cndition are correct, then I will do the job below
            if ((accountNumber == 208563) & (accountSortCode == "20-28-01") & (accountNumber == 208563))

            {
                Console.WriteLine("The balance is $5000");
            }
            
        }

    public void GetNewStudentDate(string date)
    {       
            // Today's date as an example is 13-05-2016
            string[] splittedDate = date.Split(',');

            Console.WriteLine(splittedDate[0]);
            Console.WriteLine(splittedDate[1]);
            Console.WriteLine(splittedDate[2]);
            Console.WriteLine(splittedDate[3]);


        }
    }

    }





