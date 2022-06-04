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

        public string Tomorse(string convertstring)
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

        public string MorseDecode(string convertstring)
        {
            //need to get a section of morse code,these int hold start and end point of string
            int morsestart = 0;
            int morsestop = 0;
            string morsecodefrag = "";
            string outputstring = "";

            //for loop to go though string
            for (int i = 0; i < convertstring.Length; i++)
            {
                //need to search for spaces
                //if found update morsestop
                if (convertstring[i].ToString() == " ")
                {
                    morsestop = i;
                    //small for loop to build string of morse fragment
                    Console.WriteLine("Found morse fragment");
                    for(int mf = morsestart; mf < morsestop; mf++)
                    {
                        morsecodefrag = morsecodefrag + convertstring[mf].ToString();
                    }
                    Console.WriteLine(morsecodefrag);
                    string morseletter = internationdict.getletter(morsecodefrag);
                    Console.WriteLine("Decoding --> " + morseletter);
                    outputstring = outputstring + morseletter;
                    morsecodefrag = "";
                    morsestart = (i + 1);
                }
            }
            return outputstring;
        }

        public string Sanitizestring(string incomingstring)
        {
            Console.WriteLine("Sanitizing string");
            Console.WriteLine(incomingstring + " --> " + incomingstring.ToLower());
            return incomingstring.ToLower();
        }

        public bool Checkmorse(string morse)
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
