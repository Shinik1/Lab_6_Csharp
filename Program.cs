using lab6;
using System;
using System.Reflection;

namespace Lab6
{
    class Program
    {
        /// <summary>
        /// Вызывает мяуканье у всех объектов в списке
        /// </summary>
        static void MakeAllMeow(List<IMeowable> list)
        {
            foreach (IMeowable item in list)
            {
                item.Meow();
            }
        }

        static void Main()
        {
            Console.WriteLine("=== Задание 1.1: Кот ===");
                        
            Console.WriteLine("Введите имя котика:");
            string catname = Console.ReadLine();
     
            Cat name  = new Cat(catname);
                    
            Console.WriteLine($"{name}");
                 
            Console.Write("");
            name.Meow();

            Console.Write("");
            name.Meow(3);

            Console.WriteLine("=== Задание 1.2: Кот ===");

            var list = new List<IMeowable>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя котика:");
                string catname2 = Console.ReadLine();
                list.Add(new Cat(catname2));
            }
            MakeAllMeow(list);

            Console.WriteLine("Тест со своим классом");
            list.Add(new Sadcat("Депрессивный Боб"));
            MakeAllMeow(list);

            Console.WriteLine("=== ЗАДАНИЕ 1.3 ===");

            Console.WriteLine("Введите имя котика:");
            string catname3 = Console.ReadLine();
            Cat catForCounting = new Cat(catname3);

            Console.WriteLine("Создан кот: " + catForCounting);

            CatCounter counter = new CatCounter(catForCounting);

            var countingList = new List<IMeowable>();
            countingList.Add(counter);

            Console.WriteLine("\nВызываем MakeAllMeow:");
            MakeAllMeow(countingList);

            Console.WriteLine("\nВызываем MakeAllMeow еще раз:");
            MakeAllMeow(countingList);

            // Узнаем количество мяуканий
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Кот мяукал " + counter.MeowCount + " раз");
            Console.WriteLine("Информация о счетчике: " + counter);

        }
    }
}