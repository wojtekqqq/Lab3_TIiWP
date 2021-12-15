using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Product
{
    class Product
    {
        List<string> czesci = new List<string>();

        public void Add(string czesc)
        {
            czesci.Add(czesc);
        }

        public string Show(int przycisk)
        {
            try
            {
                string akcja = czesci[przycisk];
                Console.WriteLine(akcja);
                return akcja;
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie ma takiego przycisku, kończymy zabawę.");
                return null;

                /*                Console.WriteLine(e);
                                throw;*/
            }
        }
    }
}
