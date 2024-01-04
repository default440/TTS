using System.Speech.Synthesis;

#pragma warning disable CA1416 // Проверка совместимости платформы

namespace TTS.Synthesizers
{
    internal class MicrosoftSpeechSynthesizer : ISynthesizer
    {
        private readonly SpeechSynthesizer _speechSynthesizer;

        /// <summary>
        /// 
        /// </summary>
        internal MicrosoftSpeechSynthesizer() {
            _speechSynthesizer = new()
            {
                Volume = 100,
                Rate = 0
            };

            _speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        void ISynthesizer.Speak(string textToSpeak)
        {
            _speechSynthesizer.Speak(textToSpeak);
        }
    }
}
