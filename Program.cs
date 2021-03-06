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
            bool debugmode = false;

            MorseSound morseoundplayer = new MorseSound(80, 800, debugmode);
            MorseConvert morseconverter = new MorseConvert();
            
            Console.Title = "Morse Code App";
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
                    string morsecode = morseconverter.Tomorse(morseconverter.Sanitizestring(userinput));
                    Console.WriteLine(morsecode);
                    if (morseconverter.Checkmorse(morsecode))
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
                        Console.WriteLine("2.) Test Morse Code Decode");
                        Console.WriteLine("3.) return to main menu");
                        menuselect = Console.ReadLine();
                        if (menuselect == "1")
                        {
                            Console.WriteLine("Begining Stage 1 Encoding test");
                            string testmorsecode = morseconverter.Tomorse(morseconverter.Sanitizestring("hello!!!"));
                            Console.WriteLine(testmorsecode);
                            Console.WriteLine("Begining Stage 2 Playback test");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            morseoundplayer.Playmorse(testmorsecode);
                        }
                        
                        if (menuselect == "2")
                        {
                            Console.WriteLine(morseconverter.MorseDecode(".... . .-.. .-.. --- "));
                        }
                        
                        if (menuselect == "3")
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
