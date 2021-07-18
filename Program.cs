using System;
using static System.Console;

/*
 * NASR BIN SAFWAN
 * ITP - SUMMER 2021
 */

namespace madlibs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variables
            string sunny;
            string run;
            string good;
            string icecream;
            string occupation;


            //input!
            WriteLine("Enter an ADJECTIVE:");
            sunny = ReadLine();

            WriteLine("Enter a VERB:");
            run = ReadLine();

            WriteLine("Enter an ADJECTIVE:");
            good = ReadLine();

            WriteLine("Enter a NOUN:");
            icecream = ReadLine();

            WriteLine("Enter an OCCUPATION:");
            occupation = ReadLine();

            //story
            WriteLine($"On {sunny} days like these after you've gone for a {run}, it's {good} to get some {icecream} from" +
                $" the local {occupation}.");

            WriteLine("Press any key to exit");
            ReadKey();
        }
    }
}
