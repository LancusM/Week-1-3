using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Excercise 3,
            //Initial title/prompt
            Console.WriteLine("Interest Calculator Program");
            //Asks for Principal
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            //assigns user input to principal variable of int
            //converts the readable line to int with the convert, making it able to do math later
            int principal = Convert.ToInt32(Console.ReadLine());
            //Asks for Interest Rate
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)?");
            //assigns user input to rate variable
            //the float variable requires the different parse to convert it, I learned
            float rate = float.Parse(Console.ReadLine());
            //Asks for loan period
            Console.WriteLine("What is the period of the loan in years?");
            //assigns user input to time variable
            //same as principal, converting to int
            int time = Convert.ToInt32(Console.ReadLine());
            //This changes the int values of
            float floatPrin = principal;
            float floatTime = time;

            float interest = 0;

            interest = principal * rate * time;

            Console.WriteLine("Total Interest of Loan is: " + interest + " dollars.");
        }
    }
}
