using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualSensorePressione : ISensorInterface, IPressionneSensoreInterface
    {

        private readonly Random random;

        public VirtualSensorePressione()
        {
            random = new Random();
        }

        public int Pressione()
        {
            return new Pressione(random.Next(9000)).Value;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Pressione());
        }
    }
}
