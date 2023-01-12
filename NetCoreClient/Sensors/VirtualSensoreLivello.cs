using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualSensoreLivello : ILivelloSensoreInterface, ISensorInterface
    {
        private readonly Random random;

        public VirtualSensoreLivello()
        {
            random = new Random();
        }

        public int livello()
        {
            return new Livello(random.Next(100)).Value;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(livello());
        }
    }
}
