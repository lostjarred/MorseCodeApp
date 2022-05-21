using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to my morsecode app");
                Console.WriteLine("please make a selection");
                Console.WriteLine("1.) Convert a string to morse code");
                Console.WriteLine("2.) Quit the program");
                string menuselect = Console.ReadLine();
                if (menuselect == "1")
                {
                    Console.WriteLine("Please type a message to convert");
                    string userinput = Console.ReadLine();
                    string morsecode = MorseConvert.Tomorse(userinput);
                    Console.WriteLine(morsecode);
                    Console.WriteLine("Would you like this played ? y/n");
                    menuselect = Console.ReadLine();
                    if (menuselect == "y")
                    {
                        Console.WriteLine("beging morsecode playback, press any key to continue");
                        Console.ReadKey();
                        MorseSound.Playmorse(morsecode);
                    }
                }
                if (menuselect == "2")
                {
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
