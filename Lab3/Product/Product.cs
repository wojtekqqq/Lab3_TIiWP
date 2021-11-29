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
            string akcja = czesci[przycisk];
            /*            
                        Console.WriteLine("\nZabawka");

                        foreach (string czesc in czesci)
                        {
                            Console.WriteLine(czesc);
                        }*/
            Console.WriteLine(akcja);
            return akcja;
        }
    }
}
