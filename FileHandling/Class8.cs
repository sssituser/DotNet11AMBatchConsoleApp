using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
namespace FileHandling
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Text To Speak : ");
            string text= Console.ReadLine();
            SpeechSynthesizer sp=new SpeechSynthesizer();
            sp.Volume = 90;
            sp.Rate = -10;
            sp.SelectVoiceByHints(VoiceGender.Female);
            sp.Speak(text);
           
        }
    }
}
