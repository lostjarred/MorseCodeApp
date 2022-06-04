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
            Console.Title = "Morse Code App";
            MorseSound morseoundplayer = new MorseSound(150, 800);
            while (true)
            {
                Console.WriteLine("Welcome to my morsecode app");
                Console.WriteLine("please make a selection");
                Console.WriteLine("1.) Convert a string to morse code");
                Console.WriteLine("2.) Access test menu");
                Console.WriteLine("3.) Quit the program");
                string menuselect = Console.ReadLine();
                if (menuselect == "1")
                {
                    Console.WriteLine("Please type a message to convert");
                    string userinput = Console.ReadLine();
                    string morsecode = MorseConvert.Tomorse(MorseConvert.Sanitizestring(userinput));
                    Console.WriteLine(morsecode);
                    if (MorseConvert.Checkmorse(morsecode))
                    {
                        Console.WriteLine("Morse code contains symbols that could not be converted, they will be ignored");
                    }
                    while (true)
                    {
                        Console.WriteLine("Would you like this played ? y/n");
                        menuselect = Console.ReadLine();
                        if (menuselect == "y")
                        {
                            Console.WriteLine("beginning morsecode playback, press any key to continue");
                            Console.ReadKey();
                            morseoundplayer.Playmorse(morsecode);
                            break;
                        }
                        if (menuselect == "n")
                        {
                            break;
                        }
                    }
                }
                
                if (menuselect == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Test menu listing");
                        Console.WriteLine("1.) Test Morse Code Encoding/Playback");
                        Console.WriteLine("2.) return to main menu");
                        menuselect = Console.ReadLine();
                        if (menuselect == "1")
                        {
                            Console.WriteLine("Begining Stage 1 Encoding test");
                            string testmorsecode = MorseConvert.Tomorse(MorseConvert.Sanitizestring("hello"));
                            Console.WriteLine(testmorsecode);
                            Console.WriteLine("Begining Stage 2 Playback test");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            morseoundplayer.Playmorse(testmorsecode);
                        }
                        if (menuselect == "2")
                        {
                            break;
                        }
                    }
                }
                
                if (menuselect == "3")
                {
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
