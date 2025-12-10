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
            Console.WriteLine("Введите номер задания 1,2 ");
            string choose = Console.ReadLine();
            switch (choose)
                {
                case "1":
                    {
                        Console.WriteLine("Задание 1.1: Кот");

                        Console.WriteLine("Введите имя котика:");
                        string catname = Console.ReadLine();

                        Cat name = new Cat(catname);

                        Console.WriteLine($"{name}");

                        Console.Write("");
                        name.Meow();

                        Console.Write("");
                        name.Meow(3);

                        Console.WriteLine("Задание 1.2: Кот");

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

                        Console.WriteLine("ЗАДАНИЕ 1.3");

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
                                            
                        Console.WriteLine("\nРезультат:");
                        Console.WriteLine("Кот мяукал " + counter.MeowCount + " раз");
                        Console.WriteLine("Информация о счетчике: " + counter);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Задание 2.1 Дроби");
                                                
                        Console.WriteLine("Введите первую дробь:");
                        Console.Write("Числитель: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        int d1 = int.Parse(Console.ReadLine());
                                               
                        Console.WriteLine("\nВведите вторую дробь:");
                        Console.Write("Числитель: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        int d2 = int.Parse(Console.ReadLine());
                                                
                        Console.WriteLine("\nВведите третью дробь:");
                        Console.Write("Числитель: ");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        int d3 = int.Parse(Console.ReadLine());
                                              
                        Fraction f1 = new Fraction(n1, d1);
                        Fraction f2 = new Fraction(n2, d2);
                        Fraction f3 = new Fraction(n3, d3);

                        Console.WriteLine($"\nСозданы дроби:");
                        Console.WriteLine($"f1 = {f1}");
                        Console.WriteLine($"f2 = {f2}");
                        Console.WriteLine($"f3 = {f3}");

                        Console.WriteLine("\nОперации");
                        Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
                        Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
                        Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
                        Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
                                            
                        Console.WriteLine("\nЦепочка f1.sum(f2).div(f3).minus(5)");
                        Fraction result = f1.Sum(f2).Div(f3).Minus(5);
                        Console.WriteLine($"Результат: {result}");

                        Console.WriteLine("\nСравнение");
                        Console.WriteLine($"f1 равно f2? Ответ: {f1.Equals(f2)}");

                        Console.WriteLine("\nКлонирование");
                        Fraction clone = (Fraction)f1.Clone();
                        Console.WriteLine($"Оригинал: {f1}");
                        Console.WriteLine($"Клон: {clone}");

                        Console.WriteLine("\nВещественное значение");
                        Console.WriteLine($"f1 как вещественное: {f1.ToDouble()}");

                        Console.WriteLine("\nПереопределение");
                        Console.WriteLine("Укажите новый числитель для f1 ");
                        int num;
                        num = int.Parse(Console.ReadLine());
                        f1.SetNumerator(num);
                        Console.WriteLine("Укажите новый знаменатель для f1 ");
                        int den;
                        den = int.Parse(Console.ReadLine());
                        f1.SetDenominator(den);
                        Console.WriteLine(f1);
                        break;
                    }
            }
            

        }
    }
}