﻿using System;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;

namespace TodoParse.WinPhone81
{
    public class Speech : ITextToSpeech
    {
        public async void Speak(string text)
        {
            using (var speech = new SpeechSynthesizer())
            {
                var stream = await speech.SynthesizeTextToStreamAsync(text);
                var mediaElement = new MediaElement();
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }
    }
}
