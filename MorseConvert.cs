using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public class MorseConvert
    {
        static MorseDict_International internationdict = new MorseDict_International();

        public static string Tomorse(string convertstring)
        {
            string outputstring = "";
            string convertcharstring = "";
            for (int i = 0; i < convertstring.Length; i++) {
                convertcharstring = convertstring[i].ToString();
                if (internationdict.getmorsecode(convertcharstring) == "#")
                {
                    outputstring = outputstring + internationdict.getmorsecode(convertcharstring);
                }
                else{
                    outputstring = outputstring + internationdict.getmorsecode(convertcharstring) + " ";
                }
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

        public static bool Checkmorse(string morse)
        {
            bool result = false;
            for (int i = 0; i < morse.Length; i++)
            {
                if (morse[i].ToString() == "#") {
                    result = true;
                }
            }
            return result;
        }
    }
}
