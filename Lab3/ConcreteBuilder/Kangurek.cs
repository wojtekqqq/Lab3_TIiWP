using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.ConcreteBuilder
{
    class Kangurek : Zabawka
    {
        private Product.Product produkt = new Product.Product();

        public override void Glowa()
        {
            produkt.Add("Jestem Kangurek");
            produkt.Add("Śpi");

        }

        public override void Tulow()
        {
        }

        public override void KonczynyGorne()
        {
            produkt.Add("Macha łapkami");
            

        }

        public override void KonczynyDolne()
        {
            produkt.Add("Skacze (nogi się ruszają)");
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
