using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public static class MorseSound
    {
        static int ditduration = 100;
        static int morsebeepfreq = 800;

        public static void Playdit()
        {
            Console.Beep(morsebeepfreq, ditduration);
        }

        public static void Playdah()
        {
            Console.Beep(morsebeepfreq, ditduration * 3);
        }

        public static void Playmorse(string morsecode)
        {
            for (int i = 0; i < morsecode.Length; i++)
            {
                if (morsecode[i].ToString() == ".") { Playdit(); }
                if (morsecode[i].ToString() == "-") { Playdah(); }
                if (morsecode[i].ToString() == " ") { Playdit(); }
            }
        }
    }
}
