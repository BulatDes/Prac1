using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._1
{
    class Program
    {
        static void Main (string[] args)
        {
            string name;
            double weight;
            Console.WriteLine("Введите имя Кота");
            name = Console.ReadLine();
            Console.WriteLine("Введите вес Кота");
            weight = double.Parse(Console.ReadLine());
            Cat cat = new Cat(name,weight);
            cat.Meow();
            Console.ReadKey();
        }
    }
}
