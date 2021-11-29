using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.ConcreteBuilder
{
    class Niedzwiadek : Zabawka
    {
        private Product.Product produkt = new Product.Product();

        public override void Glowa()
        {
            produkt.Add("Jestem niedźwiadek");
        }

        public override void Tulow()
        {
        }

        public override void KonczynyGorne()
        {
            produkt.Add("Prawa łapka rusza się");
            produkt.Add("Lewa łapka rusza się");

        }

        public override void KonczynyDolne()
        {
        }

        public override void Ogon()
        {
        }

        public override Product.Product GetResult()
        {
            return produkt;
        }
    }
}
