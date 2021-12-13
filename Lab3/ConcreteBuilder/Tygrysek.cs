using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.ConcreteBuilder
{
    class Tygrysek : Zabawka
    {
        private Product.Product produkt = new Product.Product();

        public override void Glowa()
        {
            produkt.Add("Jestem tygrysek");
        }

        public override void Tulow()
        {
        }

        public override void KonczynyGorne()
        {
            produkt.Add("Odgania łapą muchy");
            produkt.Add("Lewa łapka rusza się");

        }

        public override void KonczynyDolne()
        {
            produkt.Add("Biegnie");
        }

        public override void Ogon()
        {
            produkt.Add("Ogon kiwa się");
        }

        public override Product.Product GetResult()
        {
            return produkt;
        }
    }
}
