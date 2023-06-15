using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._1
{
    class Cat
    {
        private string name; // скрытое поле
        private double weight;
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                } else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат weight
            get
            {
                return weight;
            }
            // установка значения - используем проверку
            set
            {
                bool checkWeight = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                if (value <= 0) checkWeight = false;

                if (checkWeight)
                {
                    weight = value;
                } else
                {
                    Console.WriteLine($"{value} - неправильное значение веса!!!");
                }
            }
        }
        public Cat (string CatName, double CatWieght)
        {
            Name = CatName;
            Weight = CatWieght;
        }
        public void Meow ()
        {
            if (name == null || weight == 0)
            {
                Console.WriteLine("Неправильные значения");
            }
            else
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!\n {weight} МООООЙ ВЕЕЕС!!");
        }

      

    }
}
