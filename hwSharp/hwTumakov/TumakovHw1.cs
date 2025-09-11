using System;

namespace Tumakov
{
    class hwsharp
    {
        static void Main()
        {
            // ----------------------------
            // ЗАДАНИЕ 2.1 (1)
            // ----------------------------
            {
                Console.WriteLine("1) как тебя зовут?");
                string name = Console.ReadLine();                 
                Console.WriteLine("привет " + name + "!");       
            }

            // ----------------------------
            // ЗАДАНИЕ 2.2 (2)
            // ----------------------------
            {
                Console.WriteLine("\n2) введи двва числа:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("resultat: " + number1 / number2); 
                }
                catch
                {
                    Console.WriteLine("на 0 не делится");                   // ошибка
                }
            }

            // ----------------------------
            // ЗАДАНИЕ 2.1 (3)
            // ----------------------------
            {
                Console.WriteLine("\n3) введи букву:");
                string input = Console.ReadLine();      
                char word = input[0];                   
                char nextChar = (char)(word + 1);       
                Console.WriteLine("некст: " + nextChar);
            }


            // ----------------------------
            // ЗАДАНИЕ 2.2 (4)
            // ----------------------------
            {
                Console.WriteLine("\n4) Введите a, b, c для квадратного уравнения:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double D = b * b - 4 * a * c;                   
                if (D < 0)
                {
                    Console.WriteLine("Нет вещественных корней");
                }
                else if (D == 0)
                {
                    double x0 = -b / (2 * a);                  // один корень
                    Console.WriteLine("Один корень: " + x0);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a); // два корня
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Два корня: " + x1 + " и " + x2);
                }
            }

            // конец)
            Console.WriteLine("\nГотово. Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
