using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Liquid : Product
    {
        public Container Container { get; set; }

        public Liquid(string name, int quantity, decimal priceUnitary, int iva, int capacity, Container container) 
            : base(name, quantity, priceUnitary, iva)
        {
            Container = container;
        }

        public override float TaxPrice()
        {
            return base.TaxPrice() + Container.TaxPrice();
        }
        
    }
}
