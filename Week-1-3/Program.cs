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
            //Excercise 3, user inputs value of principal, rate, and time, and the code calculates and outputs the interest.
            //Initial title/prompt
            Console.WriteLine("Interest Calculator Program");
            //Asks for Principal value
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            /* Initially, I used int and Convert.ToInt32 for both principal and time, but after learning that they all must be the same variable type,
            I thought it made sense to make them all float and calculate it with those. */
            //Takes user input, parses/converts it into float variable, into prinicpal value
            float principal = float.Parse(Console.ReadLine());
            //Asks for Interest Rate, changing percent into decimal
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)?");
            //Takes user input, parses/converts it into float variable, into rate value
            //I now know this one necessitates the parse, as the decimal conversion of the user input differs from the int variable
            float rate = float.Parse(Console.ReadLine());
            //Asks for loan period
            Console.WriteLine("What is the period of the loan in years?");
            //Takes user input, parses/converts it into float variable, into time value
            float time = float.Parse(Console.ReadLine());
            /* Creates interest variable for the later equation. I'm not sure if I should've declared it higher, but it is here
            as a float variable to work with the others */
            float interest = 0;
            // The actual equation, using the instructions of how to find interest
            interest = principal * rate * time;
            //Displays the calculation result.
            Console.WriteLine("Total Interest of Loan is: " + interest + " dollars.");
        }
    }
}
