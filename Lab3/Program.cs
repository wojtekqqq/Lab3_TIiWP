using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Lab3.Builder;
using Lab3.ConcreteBuilder;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> buttons = new List<int>();
            buttons.Add(1);
            buttons.Add(2);
            buttons.Add(3);
            buttons.Add(4);

            Director.Director director = new Director.Director();
            Console.WriteLine("Wybierz zwierzaka:");
            foreach (var value in Enum.GetValues(typeof(AnimalType)))
            {
                Console.WriteLine("{0,3} {1}",
                    (int)value, ((AnimalType)value));
            }


            var choose = Convert.ToInt32(Console.ReadLine());
            var choosen = AnimalFactory.createAnimal((AnimalType)choose);
            director.Construct(choosen);
            int idbutton = 1;
            
            Product.Product p1 = choosen.GetResult();
            p1.Show(idbutton);


            Console.WriteLine("Dostępne przyciski do zabawy");
            foreach (var button in buttons)
            {
                Console.WriteLine(button);
            }
            Console.WriteLine("Użycie przycisku spoza zakresu kończy zabawę");
            Console.WriteLine("Podaj nr przycisku");
            idbutton = Convert.ToInt32(Console.ReadLine());
            p1.Show(idbutton);

            while (buttons.Contains(idbutton))
            {
                Console.WriteLine("Podaj nr przycisku");
                idbutton = Convert.ToInt32(Console.ReadLine());
                p1.Show(idbutton); }
        }
    }
}
