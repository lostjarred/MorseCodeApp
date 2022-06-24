using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public class MorseSound
    {
        int ditlength;
        int dahlength;
        int morsebeepfreq;
        bool debug;


        public MorseSound(int ditduration, int morsefreq, bool debugmode)
        {
            ditlength = ditduration;
            dahlength = ditlength * 3;
            morsebeepfreq = morsefreq;
            debug = debugmode;
        }
        

        public void Playdit()
        {
            if (debug) { Console.WriteLine("Playing Dit"); }
            Console.Beep(morsebeepfreq, ditlength);
        }

        public void Playdah()
        {
            if (debug) { Console.WriteLine("Playing Dah"); }
            Console.Beep(morsebeepfreq, dahlength);
        }

        public void Playspace()
        {
            if (debug) { Console.WriteLine("Playing Space"); }
            System.Threading.Thread.Sleep(ditlength);

        }

        public void Playmorse(string morsecode)
        {
            for (int i = 0; i < morsecode.Length; i++)
            {
                Console.WriteLine("Curent Playing symbol " + (i + 1).ToString() + "/" + morsecode.Length.ToString());
                if (morsecode[i].ToString() == ".") { Playdit(); }
                if (morsecode[i].ToString() == "-") { Playdah(); }
                if (morsecode[i].ToString() == " ") { Playspace(); }
                if (morsecode[i].ToString() == "#") { Console.WriteLine("unknown symbol, ignoring"); }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
