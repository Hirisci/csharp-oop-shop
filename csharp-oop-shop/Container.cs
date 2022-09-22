using System.Diagnostics;
using System.Reflection.Metadata;

namespace csharp_oop_shop
{
    internal class Container : Product
    {
        public int Capacity { get; set; }
        public Container(string name, int quantity, decimal priceUnitary, int iva, int capacity)
            :base(name, quantity, priceUnitary, iva)
        {
            Capacity = capacity;
        }
    }
}