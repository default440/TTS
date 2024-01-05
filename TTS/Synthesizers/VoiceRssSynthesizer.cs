using NAudio.Wave;

namespace TTS.Synthesizers
{
    /// <summary>
    /// Синтезатор на основе запросов к https://www.voicerss.org/.
    /// </summary>
    /// <remarks>
    /// Для работы необходимо добавить переменную среды VoiceRSS_API_KEY и положить в ней API_KEY от https://www.voicerss.org/.
    /// </remarks>
    internal class VoiceRssSynthesizer : ISynthesizer
    {
        private readonly string _voiceRssUrl = "http://api.voicerss.org/?";
        private readonly string _language = "ru-ru";
        
        private string _apiKey = string.Empty;
        private VoiceType _voiceType;

        /// <summary>
        /// ctor.
        /// </summary>
        internal VoiceRssSynthesizer(VoiceType voice = VoiceType.Marina) {
            _apiKey = Environment.GetEnvironmentVariable("VoiceRSS_API_KEY") ?? string.Empty;
            _voiceType = voice;
        }

        ///<inheritdoc/>
        void ISynthesizer.Speak(string textToSpeak)
        {
            string url = $"{_voiceRssUrl}key={_apiKey}&hl={_language}&v={_voiceType}&src={textToSpeak}";
            
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WasapiOut())
            {
                wo.Init(mf);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        internal enum VoiceType
        {
            Olga,
            Marina,
            Peter
        }
    }
}
