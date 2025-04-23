using System;
using System.Media;
using System.Runtime.InteropServices;

public class VoiceAudio
{
    public static void PlayGreeting()
    {
        string filePath = "greeting.wav";

        if (!System.IO.File.Exists(filePath))
        {
            Console.WriteLine("Audio file not found.");
            return;
        }

        try
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using SoundPlayer player = new SoundPlayer(filePath);
                player.Play(); // Or use PlaySync() to block until the audio is finished
            }
            else
            {
                Console.WriteLine("This audio method currently supports only Windows.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not play greeting: " + ex.Message);
        }
    }
}