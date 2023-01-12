using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.ValueObjects
{
    internal class Pressione
    {
        public int Value { get; private set; }

        public Pressione(int value) { 
            this.Value = value;
        }
    }
}
