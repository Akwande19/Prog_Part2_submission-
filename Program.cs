using ProgPOE;

class Program
{
    static void Main(string[] args)
    {
        VoiceAudio.PlayGreeting();
        Art.DisplayLogo();

        ChatBot bot = new ChatBot();
        bot.Run();
    }
}