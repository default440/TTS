using TTS.Synthesizers;

const string testText = "Кроваво-черное ничто пустилось вить систему клеток, связанных внутри, клеток, связанных внутри, клеток в едином стебле и явственно, до жути на фоне тьмы ввысь белым бил фонтан";

ISynthesizer synthesizer = new MicrosoftSpeechSynthesizer();

// Synchronous
synthesizer.Speak(testText);
