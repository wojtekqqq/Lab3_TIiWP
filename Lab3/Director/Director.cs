using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;

namespace Lab3.Director
{
    class Director
    {
        public void Construct(Zabawka zwierzak)
        {
           zwierzak.Glowa();
           zwierzak.Tulow();
           zwierzak.KonczynyDolne();
           zwierzak.KonczynyGorne();
           zwierzak.Ogon();
        }
    }
}
