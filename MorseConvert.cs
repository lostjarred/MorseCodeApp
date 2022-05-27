using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public static class MorseConvert
    {
        private static string Morsedict(string letter)
        {
            //international 
            //https://en.wikipedia.org/wiki/File:Morse_comparison.svg
            if (letter == "a") { return ".-"; }
            if (letter == "b") { return "-..."; }
            if (letter == "c") { return "-.-."; }
            if (letter == "d") { return "-.."; }
            if (letter == "e") { return "."; }
            if (letter == "f") { return "..-."; }
            if (letter == "g") { return "--."; }
            if (letter == "h") { return "...."; }
            if (letter == "i") { return ".."; }
            if (letter == "j") { return ".---"; }
            if (letter == "k") { return "-.-"; }
            if (letter == "l") { return ".-.."; }
            if (letter == "m") { return "--"; }
            if (letter == "n") { return "-."; }
            if (letter == "o") { return "---"; }
            if (letter == "p") { return ".--."; }
            if (letter == "q") { return "--.-"; }
            if (letter == "r") { return ".-."; }
            if (letter == "s") { return "..."; }
            if (letter == "t") { return "-"; }
            if (letter == "u") { return "..-"; }
            if (letter == "v") { return "...-"; }
            if (letter == "w") { return ".--"; }
            if (letter == "x") { return "-..-"; }
            if (letter == "y") { return "-.--"; }
            if (letter == "z") { return "--.."; }
            if (letter == "1") { return ".----"; }
            if (letter == "2") { return "..---"; }
            if (letter == "3") { return "...--"; }
            if (letter == "4") { return "....-"; }
            if (letter == "5") { return "....."; }
            if (letter == "6") { return "-...."; }
            if (letter == "7") { return "--..."; }
            if (letter == "8") { return "---.."; }
            if (letter == "9") { return "----."; }
            if (letter == "0") { return "-----"; }
            if (letter == " ") { return "   "; }
            else {
                Console.WriteLine("Cannot convert symbol to morse --> " + letter);
                return "#"; }
        }

        public static string Tomorse(string convertstring)
        {
            string outputstring = "";
            for (int i = 0; i < convertstring.Length; i++) {
                outputstring = outputstring + Morsedict(convertstring[i].ToString()) + " ";
                Console.WriteLine("Converting symbol " + (i + 1).ToString() + "/" + convertstring.Length.ToString());
            }
            return outputstring;
        }

        public static string Sanitizestring(string incomingstring)
        {
            Console.WriteLine("Sanitizing string");
            Console.WriteLine(incomingstring + " --> " + incomingstring.ToLower());
            return incomingstring.ToLower();
        }
    }
}
