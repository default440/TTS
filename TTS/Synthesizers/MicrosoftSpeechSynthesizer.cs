using System.Speech.Synthesis;

#pragma warning disable CA1416 // Проверка совместимости платформы

namespace TTS.Synthesizers
{
    /// <summary>
    /// Адаптер для класса System.Speech.Synthesis.SpeechSynthesizer.
    /// </summary>
    /// <remarks>
    /// Работает только с Windows.
    /// </remarks>
    internal class MicrosoftSpeechSynthesizer : ISynthesizer
    {
        private readonly SpeechSynthesizer _speechSynthesizer;

        /// <summary>
        /// ctor.
        /// </summary>
        internal MicrosoftSpeechSynthesizer() {
            _speechSynthesizer = new()
            {
                Volume = 100,
                Rate = 0
            };

            _speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        /// <inheritdoc/>
        void ISynthesizer.Speak(string textToSpeak)
        {
            _speechSynthesizer.Speak(textToSpeak);
        }
    }
}
