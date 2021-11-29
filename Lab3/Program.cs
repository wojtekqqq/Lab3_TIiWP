using System;
using Lab3.Builder;
using Lab3.ConcreteBuilder;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Director.Director director = new Director.Director();
            Zabawka z1 = new Niedzwiadek();

            director.Construct(z1);
            Product.Product p1 = z1.GetResult();
            p1.Show(1);
        }
    }
}
