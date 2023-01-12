
namespace NetCoreClient.ValueObjects
{
    internal class Livello
    {
        public int Value { get; private set; }

        public Livello(int Value) {
            this.Value = Value;
        }
    }
}
