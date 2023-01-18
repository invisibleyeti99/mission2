// This program is ment to get the sum of 2 randomly rolled dice. It then shows what
// percentage of rolls each number has using astricks.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {//These are all my variable 
            int[] rolls = new int [11];
            int random1 = 0; 
            int random2 = 0;
            int totalroll = 0;
            double[] numAstricks = new double[11];
            double holder = 0;
            Random r = new Random();
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("Hello. Please enter the number of rolls.");
            string numrolls = Console.ReadLine();
            Console.WriteLine();


            //This for loop rolls 2 dice and store how many times each dice was rolled 

            for (int icount = 0; icount < Int16.Parse(numrolls); icount++)
                {
                    random1 = r.Next(6)+1;
                    random2 = r.Next(6)+1;

                    totalroll = random2 + random1;
               
                    rolls[totalroll - 2]++;

              
                
                }
            // This for loop gets the number of astricks needed to represent what percent each number was rolled.
                for (int icount = 0; icount<11; icount++)
                    {

                        rolls[icount] = rolls[icount] * 100;
                        holder = rolls[icount] / Int16.Parse(numrolls); 
                        numAstricks[icount] = Math.Round(holder);
                    }
                Console.WriteLine("DICE ROLLING SIMULATION RESULTS" +
                    "\nEach astricks represents 1 % of the total number of rolls." +
                    "\nTotal number of rolls =" + numrolls + ".");


                //This for loops places those astricks in a string and then outputs them in the console.
                for (int icount=0; icount< numAstricks.Length;icount++)
                        {
                            string PlaceHolder = "";
                            int numbers = icount + 2; 
                            for (int j = 0; j < numAstricks[icount]; j++)
                            {
                                PlaceHolder = PlaceHolder + "*";
                            }
                            Console.WriteLine(numbers + ":   " + PlaceHolder);
                        }
            
            
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

            // My computer closes the console very quickly so this just stops it from closing until i press enter.
            Console.ReadKey();
        }
    }
}
