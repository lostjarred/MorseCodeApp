using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MorseCodeAPP
{
    public class MorseSound
    {
        SignalGenerator morsegenerator;
        ISampleProvider ditsample;
        ISampleProvider datsample;
        int ditlength;
        int dahlength;
        int morsebeepfreq;
        bool debug;
        WaveOutEvent waveoutput;


        public MorseSound(int ditduration, int morsefreq, bool debugmode)
        {
            ditlength = ditduration;
            dahlength = ditlength * 3;
            morsebeepfreq = morsefreq;
            debug = debugmode;
            morsegenerator = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = morsefreq,
                Type = SignalGeneratorType.Sin
            };
            ditsample = morsegenerator.Take(TimeSpan.FromMilliseconds(ditduration));
            datsample = morsegenerator.Take(TimeSpan.FromMilliseconds(dahlength));
            waveoutput = new WaveOutEvent();
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
