using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    public static class MorseSound
    {
        static int ditduration = 150;
        static int dahduration = ditduration * 3;
        static int morsebeepfreq = 800;

        public static void Playdit()
        {
            Console.WriteLine("Playing Dit");
            Console.Beep(morsebeepfreq, ditduration);
        }

        public static void Playdah()
        {
            Console.WriteLine("Playing Dah");
            Console.Beep(morsebeepfreq, dahduration);
        }

        public static void Playspace()
        {
            Console.WriteLine("Playing Space");
            System.Threading.Thread.Sleep(ditduration);

        }

        public static void Playmorse(string morsecode)
        {
            for (int i = 0; i < morsecode.Length; i++)
            {
                Console.WriteLine("Curent Playing symbol " + (i + 1).ToString() + "/" + morsecode.Length.ToString());
                if (morsecode[i].ToString() == ".") { Playdit(); }
                if (morsecode[i].ToString() == "-") { Playdah(); }
                if (morsecode[i].ToString() == " ") { Playspace(); }
                System.Threading.Thread.Sleep(ditduration + 50);
            }
        }
    }
}
