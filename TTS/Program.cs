using System.Speech.Synthesis;

#pragma warning disable CA1416 // Проверка совместимости платформы

SpeechSynthesizer synthesizer = new()
{
    Volume = 100,
    Rate = 0
};

// Synchronous
synthesizer.Speak("Кроваво-черное ничто пустилось вить систему клеток, связанных внутри, клеток, связанных внутри, клеток в едином стебле и явственно, до жути на фоне тьмы ввысь белым бил фонтан");
