using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Builder
{
    abstract class Zabawka
    {
        public abstract void Glowa();
        public abstract void Tulow();
        public abstract void KonczynyDolne();
        public abstract void KonczynyGorne();
        public abstract void Ogon();
        public abstract Product.Product GetResult();
    }
}
