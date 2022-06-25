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
    class NAudioBeep
    {
        public static void test()
        {
            var sine20Seconds = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.Sin
            }.Take(TimeSpan.FromMilliseconds(80));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(10);
                }
            }
        }
    }
}
