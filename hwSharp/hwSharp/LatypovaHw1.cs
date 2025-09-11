using System;                
using System.Threading;      // dlya 19

namespace Latypova
{
    
    class hwsharp
    {
        static void Main()
        {
            // ----------------------------
            // ЗАДАНИЕ 1
            // ----------------------------
            {
                // Math.E — e)
                double e = Math.E;
                double answer = Math.Round(e, 1);
                Console.WriteLine("1) e округлённое до 1 знака: " + answer);
            }

            // ----------------------------
            // ЗАДАНИЕ 2
            // ----------------------------
            {
                Console.WriteLine("\n2)");
                Console.WriteLine(50);   
                Console.Write(10);       
                Console.WriteLine();     
            }

            // ----------------------------
            // ЗАДАНИЕ 3
            // ----------------------------
            {
                Console.WriteLine("\n3) ввод 4 чисел:");
                double a1 = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble строка в число
                double a2 = Convert.ToDouble(Console.ReadLine());
                double a3 = Convert.ToDouble(Console.ReadLine());
                double a4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a1);
                Console.WriteLine(a2);
                Console.WriteLine(a3);
                Console.WriteLine(a4);
            }

            // ----------------------------
            // ЗАДАНИЕ 4
            // ----------------------------
            {
                Console.WriteLine("\n4) ввод +10:");
                double n4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(n4 + 10); 
            }

            // ----------------------------
            // ЗАДАНИЕ 5
            // ----------------------------
            {
                Console.WriteLine("\n5) x в радианах:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("cos(x) = " + Math.Cos(x)); 
            }

            // ----------------------------
            // ЗАДАНИЕ 6
            // ----------------------------
            {
                Console.WriteLine("\n6) a (bols osn), b (mensh osn), h:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                // боковая сторона: koren(h^2 + ((a-b)/2)^2)
                double side = Math.Sqrt(h * h + Math.Pow((a - b) / 2.0, 2));
                Console.WriteLine("периметр = " + (a + b + 2 * side));
            }

            // ----------------------------
            // ЗАДАНИЕ 7
            // ----------------------------
            {
                Console.WriteLine("\n7)");
                Console.WriteLine("Мир Труд Май");   
                Console.WriteLine("Мир");
                Console.WriteLine("\tТруд");       
                Console.WriteLine("\t\tМай");
            }

            // ----------------------------
            // ЗАДАНИЕ 8
            // ----------------------------
            {
                Console.WriteLine("\n8) vvod 2 chisel:");
                double first = Convert.ToDouble(Console.ReadLine());
                double second = Convert.ToDouble(Console.ReadLine());
                // reverse vvivod
                Console.WriteLine(second);
                Console.WriteLine(first);
            }

            // ----------------------------
            // ЗАДАНИЕ 9
            // ----------------------------
            {
                Console.WriteLine("\n9) любое число:");
                string input9 = Console.ReadLine(); 
                Console.WriteLine("вы ввели число " + input9); 
            }

            // ----------------------------
            // ЗАДАНИЕ 10
            // ----------------------------
            {
                Console.WriteLine("\n10) квадратное уравнение. ввод a, b, c:");
                double qa = Convert.ToDouble(Console.ReadLine());
                double qb = Convert.ToDouble(Console.ReadLine());
                double qc = Convert.ToDouble(Console.ReadLine());
                double D = qb * qb - 4 * qa * qc;               // дискриминант
                if (D > 0)
                {
                    double x1 = (-qb + Math.Sqrt(D)) / (2 * qa); // два разных корня
                    double x2 = (-qb - Math.Sqrt(D)) / (2 * qa);
                    Console.WriteLine("два корня: " + x1 + " и " + x2);
                }
                else if (D == 0)
                {
                    double x0 = -qb / (2 * qa);                 // один корень
                    Console.WriteLine("один корень: " + x0);
                }
                else
                {
                    Console.WriteLine("нет вещественных корней"); // когда D < 0
                }
            }

            // ----------------------------
            // ЗАДАНИЕ 11
            // ----------------------------
            {
                Console.WriteLine("\n11) два целых числа:");
                int in1 = Convert.ToInt32(Console.ReadLine());
                int in2 = Convert.ToInt32(Console.ReadLine());
                // среднее арифметическое — (a+b)/2.0 (делим на 2.0 чтобы получить double)
                Console.WriteLine("avg: " + ((in1 + in2) / 2.0));
                // среднее геометрическое — sqrt(a*b)
                Console.WriteLine("avg: " + Math.Sqrt(in1 * (double)in2));
            }

            // ----------------------------
            // ЗАДАНИЕ 12
            // ----------------------------
            {
                Console.WriteLine("\n12) введите x1, y1, x2, y2:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());
                // расстояние между точками по формуле
                double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("rasstoyanie: " + dist);
            }

            // ----------------------------
            // ЗАДАНИЕ 13
            // ----------------------------
            {
                Console.WriteLine("\n13) ввести a, b, c:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                // а) (a,b,c) -> (b,a,c)
                Console.WriteLine("а) " + b + ", " + a + ", " + c);
                // б) (a,b,c) -> (a,c,b)
                Console.WriteLine("б) " + a + ", " + c + ", " + b);
                // в) (a,b,c) -> (c,a,b)
                Console.WriteLine("в) " + c + ", " + a + ", " + b);
            }

            // ----------------------------
            // ЗАДАНИЕ 14
            // ----------------------------
            {
                Console.WriteLine("\n14) целое колво секунд:");
                int n = Convert.ToInt32(Console.ReadLine());
                int hours = n / 3600;                     // часы
                int minutes = (n % 3600) / 60;           // остаток минут
                int seconds = n % 60;                    // остаток секунд
                Console.WriteLine("часы: " + hours);
                Console.WriteLine("минуты: " + minutes);
                Console.WriteLine("секунды: " + seconds);
            }

            // ----------------------------
            // ЗАДАНИЕ 15
            // ----------------------------
            {
                Console.WriteLine("\n15) Пример: shirina=543, dlina=130");
                int shirina = 543;
                int dlina = 130;
                int s1 = shirina * dlina;               // площадь прямоугольника
                int s2 = dlina * dlina;                 // площадь квадрата со стороной dlina
                int count = s1 / s2;                    // целое количество квадратов
                Console.WriteLine("квадратиков вот стока: " + count);
            }

            // ----------------------------
            // ЗАДАНИЕ 16
            // ----------------------------
            {
                Console.WriteLine("\n16) введите трехзначное число:");
                int number = Convert.ToInt32(Console.ReadLine());
                // last — последняя цифра, firstTwo — первые две цифры
                int last = number % 10;
                int firstTwo = number / 10;
                int result = last * 100 + firstTwo;     // переставляем цифры
                Console.WriteLine("Результат: " + result);
            }

            // ----------------------------
            // ЗАДАНИЕ 17
            // ----------------------------
            {
                Console.WriteLine("\n17) целое n > 999:");
                int n = Convert.ToInt32(Console.ReadLine());
                // number_a — сотни последней тройки: (n % 1000) / 100
                int number_a = (n % 1000) / 100;
                // number_b — часть слева от трёх последних цифр: n / 1000
                int number_b = n / 1000;
                Console.WriteLine("number_a = " + number_a);
                Console.WriteLine("number_b = " + number_b);
            }

            // ----------------------------
            // ЗАДАНИЕ 18
            // ----------------------------
            {
                Console.WriteLine("\n18) как тебя ховут");
                string name1 = Console.ReadLine();
                Console.WriteLine("a) тебя зовут: " + name1); // ответ а)
                Console.WriteLine("как еще раз зовут");
                string name2 = Console.ReadLine();
                Console.WriteLine("b) привет " + name2); // ответ б)
            }

            // ----------------------------
            // ЗАДАНИЕ 19
            // ----------------------------
            {
                Console.WriteLine("\n19) тарантиновский диалог):");
                string hi = Console.ReadLine();                   
                Console.WriteLine("как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine("привет " + name + "(спроси про тайную комнату))");
                string q1 = Console.ReadLine();
                Console.WriteLine("да, (спроси могу ли показать)");
                string q2 = Console.ReadLine();
                Console.WriteLine("нет(");                         
                Thread.Sleep(5000);                                // думает
                Console.Write("но могу показать): ");
                // случайный цвет
                Random run = new Random();
                Console.ForegroundColor = (ConsoleColor)run.Next(0, 16);
                Console.ResetColor();                             // дефолт цвет
            }

            // ----------------------------
            // ЗАДАНИЕ 20 a) и b)
            // ----------------------------
            {
                // a) — генерируем штрихкод
                Console.WriteLine("\n20 a) генерация штрихкода:");
                Random rnd = new Random();
                string code = "";
                for (int i = 0; i < 12; i++)
                {
                    code += rnd.Next(0, 10).ToString(); // добавляем случайную цифру 0..9
                }
                Console.WriteLine("штрихкод: " + code);

                // считаем сумму: чётные позиции +1, нечётные +3 (индекс с 0)
                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    int d = code[i] - '0';            // из символа в цифру
                    if (i % 2 == 0) sum += d;         // чётные 
                    else sum += d * 3;                // нечётные 
                }
                int check = (10 - (sum % 10)) % 10;    // контрольная цифра
                Console.WriteLine("контрольная цифра: " + check);

                // b) ввод
                Console.WriteLine("\n20 b) введи 12 цифр:");
                string userCode = Console.ReadLine() ?? "";
                if (userCode.Length == 12)
                {
                    int sum2 = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        int d = userCode[i] - '0';
                        if (i % 2 == 0) sum2 += d;
                        else sum2 += d * 3;
                    }
                    int check2 = (10 - (sum2 % 10)) % 10;
                    Console.WriteLine("контрольная цифра: " + check2);
                }
                else
                {
                    Console.WriteLine("введено не 12 символов, некст.");
                }
            }

            // конец
            Console.WriteLine("\nГотово. Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
