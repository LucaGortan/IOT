using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualSensoreTemperatura : ITemperaturaSensoreInterface, ISensorInterface
    {
        private readonly Random random;

        public VirtualSensoreTemperatura()
        {
            random = new Random();
        }

        public int Temp()
        {
            return new Temperatura(random.Next(130)).Value;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Temp());
        }
    }
}
