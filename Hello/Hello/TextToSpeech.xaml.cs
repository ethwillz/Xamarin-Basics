using System;

using Xamarin.Forms;

namespace Hello
{
    public partial class TextToSpeech : ContentPage
    {
        public TextToSpeech()
        {
            InitializeComponent();
        }

        public void convert()
        {
            String words = sentence.Text;
            DependencyService.Get<TextToSpeechInterface>().toSpeech(words);
        }
    }
}
