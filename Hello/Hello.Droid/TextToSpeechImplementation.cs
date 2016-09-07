using Android.Speech.Tts;
using Hello.Droid;
using System.Collections.Generic;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechImplementation))]
namespace Hello.Droid
{
    class TextToSpeechImplementation : TextToSpeechInterface
    {
        TextToSpeech speaker;
        string toSpeak;

        public void toSpeech(string sentence)
        {
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = sentence;
            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

    }
}