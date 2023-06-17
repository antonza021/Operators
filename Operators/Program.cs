using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            ConsoleKey input; // Создание переменной input
            RationalNumbers left = new RationalNumbers(2, 3);
            RationalNumbers right = new RationalNumbers(3, 4);  // Создание двух объектов класса RationalNumbers

            while (true)  // Бесконечный цикл работы с рациональными числами
            {
                Console.WriteLine("Выберите действие:\n1)Сложение\n2)Вычитание\n3)Умножение\n4)Деление\n5)Левая больше правой?\n" +
                                  "6)Левая меньше правой?\n7)Дроби равны?\n8)Дроби не равны?");   // Вывод на экран возможных операций

                input = Console.ReadKey().Key;   // Считывание ввода пользователя
                switch (input)  // Выполнение операции в зависимости от ввода пользователя
                {
                    case ConsoleKey.D1:
                        RationalNumbers addition = left + right;   // Выполнение операции сложения
                        Console.WriteLine($"Результат сложения: {addition}\n");
                        continue;
                    case ConsoleKey.D2:
                        RationalNumbers substraction = left - right;  // Выполнение операции вычитания
                        Console.WriteLine($"Результат вычитания: {substraction}\n");
                        continue;
                    case ConsoleKey.D3:
                        RationalNumbers multiplication = left * right;   // Выполнение операции умножения
                        Console.WriteLine($"Результат умножения: {multiplication}\n");
                        continue;
                    case ConsoleKey.D4:
                        RationalNumbers division = left / right;  // Выполнение операции деления
                        Console.WriteLine($"Результат деления: {division}\n");
                        continue;
                    case ConsoleKey.D5:
                        bool isBigger = left > right;  // Выполнение операции "левая больше правой"
                        Console.WriteLine(isBigger + "\n");
                        continue;
                    case ConsoleKey.D6:
                        bool isSmaller = left < right; // Выполнение операции "левая меньше правой"
                        Console.WriteLine(isSmaller + "\n");
                        continue;
                    case ConsoleKey.D7:
                        bool isEquals = left == right; // Выполнение операции сравнения на равенство
                        Console.WriteLine(isEquals + "\n");
                        continue;
                    case ConsoleKey.D8:
                        bool isNotEquals = left != right; // Выполнение операции сравнения на неравенство
                        Console.WriteLine(isNotEquals + "\n");
                        continue;
                    default:
                        break;
                }
                break; // Прерывание бесконечного цикла
            }
        }
    }
}
