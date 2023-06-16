using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            ConsoleKey input;
            RationalNumbers left = new RationalNumbers(2, 3);
            RationalNumbers right = new RationalNumbers(3, 4);

            while (true)
            {
                Console.WriteLine("Выберите действие:\n1)Сложение\n2)Вычитание\n3)Умножение\n4)Деление\n5)Левая больше правой?\n" +
                                  "6)Левая меньше правой?\n7)Дроби равны?\n8)Дроби не равны?");

                input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        RationalNumbers addition = left + right;
                        Console.WriteLine($"Результат сложения: {addition}\n");
                        continue;
                    case ConsoleKey.D2:
                        RationalNumbers substraction = left - right;
                        Console.WriteLine($"Результат вычитания: {substraction}\n");
                        continue;
                    case ConsoleKey.D3:
                        RationalNumbers multiplication = left * right;
                        Console.WriteLine($"Результат умножения: {multiplication}\n");
                        continue;
                    case ConsoleKey.D4:
                        RationalNumbers division = left / right;
                        Console.WriteLine($"Результат деления: {division}\n");
                        continue;
                    case ConsoleKey.D5:
                        bool isBigger = left > right;
                        Console.WriteLine(isBigger + "\n");
                        continue;
                    case ConsoleKey.D6:
                        bool isSmaller = left < right;
                        Console.WriteLine(isSmaller + "\n");
                        continue;
                    case ConsoleKey.D7:
                        bool isEquals = left == right;
                        Console.WriteLine(isEquals + "\n");
                        continue;
                    case ConsoleKey.D8:
                        bool isNotEquals = left != right;
                        Console.WriteLine(isNotEquals + "\n");
                        continue;
                    default:
                        break;
                }
                break;
            }
        }
    }
}