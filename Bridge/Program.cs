using System;
using Bridge.Platform;
using Bridge.Transmissions;

namespace Bridge
{
    internal class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde ...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde ...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitles();
            live.Comments();
            live.Result();
        }
        static void Main(string[] args)
        {
            StartLiveAdvanced(new Youtube());
            StartLiveAdvanced(new Facebook());
            StartLive(new TwichTV());
        }
    }
}
