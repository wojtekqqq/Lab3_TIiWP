using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.ConcreteBuilder
{
    class Piesek : Zabawka
    {
        private Product.Product produkt = new Product.Product();

        public override void Glowa()
        {
            produkt.Add("");
            produkt.Add("Jestem Piesek");
            produkt.Add("Szczeka");
        }

        public override void Tulow()
        {
        }
        public override void KonczynyDolne()
        {
            produkt.Add("Siada");

        }

        public override void KonczynyGorne()
        {
        }

        public override void Ogon()
        {
            produkt.Add("Merda ogonem (ogon rusza się)");
        }

        public override Product.Product GetResult()
        {
            return produkt;
        }
    }
}
