
namespace NetCoreClient.ValueObjects
{
    internal class Temperatura
    {
        public int Value { get; private set; }
        public Temperatura(int value) {
            this.Value = value;
        }
    }
}
