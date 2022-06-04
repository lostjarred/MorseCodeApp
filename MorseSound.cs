using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public class MorseSound
    {
        static int ditlength;
        static int dahlength;
        static int morsebeepfreq;

        public MorseSound(int ditduration, int morsefreq)
        {
            ditlength = ditduration;
            dahlength = ditlength * 3;
            morsebeepfreq = morsefreq;
        }
        

        public static void Playdit()
        {
            Console.WriteLine("Playing Dit");
            Console.Beep(morsebeepfreq, ditlength);
        }

        public static void Playdah()
        {
            Console.WriteLine("Playing Dah");
            Console.Beep(morsebeepfreq, dahlength);
        }

        public static void Playspace()
        {
            Console.WriteLine("Playing Space");
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
