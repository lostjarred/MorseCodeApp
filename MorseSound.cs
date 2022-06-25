using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MorseCodeAPP
{
    public class MorseSound
    {
        SignalGenerator morsegenerator;
        ISampleProvider ditsample;
        ISampleProvider dahsample;
        int ditlength;
        int dahlength;
        bool debug;


        public MorseSound(int ditduration, int morsefreq, bool debugmode)
        {
            ditlength = ditduration;
            dahlength = ditlength * 3;
            debug = debugmode;
            morsegenerator = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = morsefreq,
                Type = SignalGeneratorType.Sin
            };
        }
        

        public void Playdit()
        {
            ditsample = morsegenerator.Take(TimeSpan.FromMilliseconds(ditlength));
            if (debug) { Console.WriteLine("Playing Dit"); }
            using (var wo = new WaveOutEvent())
            {
                wo.Init(ditsample);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(10);
                }
            }
        }

        public void Playdah()
        {
            dahsample = morsegenerator.Take(TimeSpan.FromMilliseconds(dahlength));
            if (debug) { Console.WriteLine("Playing Dah"); }
            using (var wo = new WaveOutEvent())
            {
                wo.Init(dahsample);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(10);
                }
            }
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
            }
        }
    }
}
