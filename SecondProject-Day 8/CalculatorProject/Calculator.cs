using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator
    {
        private int _x;
        private int _y;
        public static int serialNo = 12502;


        public Calculator(int x, int y)

        {
            this._x = x;
            this._y = y;
           
        }
        

        public static long Add(int a, int b)

        {
               //int x = 4;
            // int y = 3;
        long ans = a + b;
            return ans;
        }

                 public long Multiply()
                 {

                     int j = (_x*_y) + Calculator.serialNo;

                     return j;

            //int x = 2;
            // int y = 4;
        }

            public long Divide()
            {

                long j = _x/_y;
                // int a = x/y;
                return j;



            }

    }
}
