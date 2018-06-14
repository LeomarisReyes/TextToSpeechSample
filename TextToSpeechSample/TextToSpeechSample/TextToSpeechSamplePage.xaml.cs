using System;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TextToSpeechSample
{
    public partial class TextToSpeechSamplePage : ContentPage
    {
        public TextToSpeechSamplePage()
        {
            InitializeComponent();


            if(Device.RuntimePlatform == Device.iOS)
            {
                this.Padding = new Thickness(0, 40, 0, 0);
            } 

        }
         
        private async void Speech_Cliked(object sender, EventArgs e)
        {
            //await CrossTextToSpeech.Current.Speak(TextToSpeech.Text,
                                                  //null,
                                                  //(float)sldTone.Value,
                                                  //(float)sldSpeed.Value,
                                                  //(float)sldVolume.Value);

            await CrossTextToSpeech.Current.Speak(TextToSpeech.Text,
                                                  null,
                                                  (float)sldTone.Value,
                                                  (float)sldSpeed.Value,
                                                  (float)sldVolume.Value);
        }
    }
}
