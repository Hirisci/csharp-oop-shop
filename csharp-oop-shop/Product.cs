using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        public string Code { get;}
        public string Name { get ; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Iva { get; set; }


        public Product(string name, string description, decimal price, int iva)
        {
            Code = FullCode();
            Name = name;
            Description = description;
            Price = price;
            Iva = iva;
        }

        private int GetRndCode()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10_000_000);
        }

        public string TaxPrice()
        {
            return String.Format("{0:F2}", Price * (1 + ((decimal)Iva / 100)));
        }

        public string FullName()
        {
            return $"{Code} | {Name}";
        }

        private string FullCode()
        {
            return GetRndCode().ToString().PadLeft( 8 , '0');
        }

    }
}
