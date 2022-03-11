using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32( Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("Factorial of " + number.ToString() + "=" + factorial.ToString());
        }

        public static double Factorial(int number)
        {
            if(number == 0)
                return 1;

            return number * Factorial(number - 1);          
        }



    }
}
