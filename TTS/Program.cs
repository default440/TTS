using TTS.Synthesizers;

const string testText = "Кроваво-черное ничто пустилось вить систему клеток, связанных внутри, клеток, связанных внутри, клеток в едином стебле и явственно, до жути на фоне тьмы ввысь белым бил фонтан";

ISynthesizer microsoftSpeechSynthesizer = new MicrosoftSpeechSynthesizer();
ISynthesizer voiceRssSynthesizer = new VoiceRssSynthesizer();

Console.WriteLine("Select your speech synthesizer:");
Console.WriteLine("\t 1: MicrosoftSpeechSynthesizer");
Console.WriteLine("\t 2: VoiceRssSynthesizer");

var selectedSynthesizer = Console.Read() - 48;

switch (selectedSynthesizer)
{
    case 1:
        microsoftSpeechSynthesizer.Speak(testText);
        break;
    case 2:
        voiceRssSynthesizer.Speak(testText);
        break;
    default:
        Console.WriteLine($"\nError: {selectedSynthesizer} is unavalable");
        break;
}
