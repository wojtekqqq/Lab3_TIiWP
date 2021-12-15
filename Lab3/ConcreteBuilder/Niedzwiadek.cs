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
            produkt.Add("");
            produkt.Add("Jestem niedźwiadek");
            produkt.Add("Głowa kręci się");

        }

        public override void Tulow()
        {
        }
        public override void KonczynyDolne()
        {
        }

        public override void KonczynyGorne()
        {
            produkt.Add("Prawa łapka rusza się");
            produkt.Add("Lewa łapka rusza się");
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
