using System;
using Bridge.Transmissions;

namespace Bridge.Platform
{
    public class Live : ITransmission
    {
        protected IPlatform platform;
        public Live(IPlatform platform)
        {
            this.platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma {platform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ******");
        }
    }
}
