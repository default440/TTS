﻿namespace TTS.Synthesizers
{
    /// <summary>
    /// Интерфейс для синтезатора речи.
    /// </summary>
    internal interface ISynthesizer
    {
        /// <summary>
        /// Метод преобразования текста в речь.
        /// </summary>
        /// <param name="textToSpeak">Текст для преобразования.</param>
        internal Task Speak(string textToSpeak);
    }
}
