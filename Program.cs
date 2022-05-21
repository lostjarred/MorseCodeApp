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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Please type a message to convert");
            string userinput = Console.ReadLine();
            string morsecode = MorseConvert.Tomorse(userinput);
            Console.WriteLine("beging morsecode playback, press any key to continue");
            Console.ReadKey();
            MorseSound.Playmorse(morsecode);


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
