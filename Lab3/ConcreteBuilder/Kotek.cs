using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.ConcreteBuilder
{
    class Kotek : Zabawka
    {
        private Product.Product produkt = new Product.Product();

        public override void Glowa()
        {
            produkt.Add("Jestem Kotek");
            produkt.Add("Patrzy się");



        }

        public override void Tulow()
        {
        }

        public override void KonczynyGorne()
        {
            produkt.Add("Idzie");
 

        }

        public override void KonczynyDolne()
        {
            produkt.Add("Drapie się");
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
