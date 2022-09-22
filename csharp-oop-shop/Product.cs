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
    internal abstract class Product
    {
        protected int _idCoount = 0;
        protected string _typeCode;
        public int Id { get;}
        public string Code { get;}
        public string Name { get ; set; }
        public int Quantity { get; set; }
        public decimal PriceUnitary { get; set; }
        public int Iva { get; set; }


        protected Product()
        {
            Id = ++_idCoount;
        }

        protected Product( string name, int quantity, decimal priceUnitary, int iva) :this()
        {
            _typeCode = "00";
            Code = FullCode();
            Name = name;
            Quantity = quantity;
            PriceUnitary = priceUnitary;
            Iva = iva;
        }

        //Calcolo il prezzo Complessivo in base alla quantitá 
        protected float Taxbase()
        {
            return (float)PriceUnitary * Quantity;
        }

        // calcolo tasse
        public float Taxes()
        {
            return Taxbase() * (Iva / 100.0f);
        }

        // prezzo finale a cui devo aggiugnere il contenitore
        public virtual float TaxPrice()
        {
            return Taxbase() + Taxes();
        }

        // Äccessioria per stampa a Schermo
        public string FullName()
        {
            return $"{Code} | {Name}";
        }


        //Genera il codice articolo
        private string FullCode()
        {
            string factoryCode = "9555432";
            return factoryCode + Convert.ToString(Id).PadLeft(4,'0')+ _typeCode;
        }

    }
}
