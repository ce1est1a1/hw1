using System;
using System.Security.AccessControl;
using Enums;
using Struct;


namespace Latypova
{
    internal class LatypovaCode
    {
        static void Main(string[] args)
        {
            // ----------------------------
            // 1ST
            // ----------------------------
            
            Console.WriteLine("\n1)");
            Console.WriteLine("Целочисленные");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
            Console.WriteLine("Вещественные");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");
            Console.WriteLine("Символьный");
            Console.WriteLine($"char – {(int)char.MaxValue} – {(int)char.MinValue}");
            Console.WriteLine("Логический");
            Console.WriteLine($"bool - true - false");
            
            // ----------------------------
            // 2ND
            // ----------------------------
            
            Console.WriteLine("\n2)");
            Console.Write("Введите имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите город: ");
            string userCite = Console.ReadLine();
            int userAge;
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (int.TryParse(Console.ReadLine(), out userAge) && userAge > 0 && userAge < 101)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            int userPCode;
            while (true)
            {
                Console.Write("Введите PIN-код(3 цифры): ");
                if (int.TryParse(Console.ReadLine(), out userPCode) && userPCode >= 0 && userPCode <= 999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            string name = userName;
            string city = userCite;
            int age = userAge;
            int pin = userPCode;
            Console.WriteLine();
            Console.WriteLine($"Имя: {name}\n" + $"Город: {city}\n" + $"Возраст: {age}\n" + $"PIN: {pin}");

            // ----------------------------
            // 3RD
            // ----------------------------
            
            Console.WriteLine("\n3)");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string res = "";
            for (int i = 0; i < input.Length; i++)
            {
                char u = input[i]; //получаем символ по индексу i
                if (char.IsLower(u))
                {
                    res += char.ToUpper(u);
                }
                else
                {
                    res += char.ToLower(u);
                }

            }
            Console.WriteLine($"Результат: {res}");
            
            // ----------------------------
            // 4TH
            // ----------------------------
            
            Console.WriteLine("\n4)");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string pod = Console.ReadLine();
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(pod, index)) != -1)
            {
                count++;
                index += pod.Length; //сдвигает позицию поиска за найденную подстроку
            }
            Console.WriteLine($"Кол-во вхождений: {count}");

            // ----------------------------
            // 5TH
            // ----------------------------
            
            Console.WriteLine("\n5)");
            Console.Write("Обычная цена: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Цена со скидкой: ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("Стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            int save = normPrice - salePrice;
            int bottle = holidayPrice / save;
            Console.WriteLine($"Нужно бутылок: {bottle}");

            // ----------------------------
            // 6TH
            // ----------------------------
            
            Console.WriteLine("\n6)");
            Drink[] drinks =
            {
                new Drink {Name="Пива)",Percent=6},
                new Drink {Name="Ягер",Percent=33},
                new Drink {Name="Самогон",Percent=45},
                new Drink {Name="Кола зиро",Percent=0}    
            };
            Student[] students =
            {
                new Student {LastName= "Правин",FirstName="Александр", ID=1,Category=Alco.alkash,DrinkType=drinks[2],RR=500},
                new Student {LastName= "Поторак",FirstName="Станислав", ID=2,Category=Alco.lyubitel,DrinkType=drinks[1],RR=300},
                new Student {LastName= "Кудряшев",FirstName="Роман", ID=3,Category=Alco.redkoPyet,DrinkType=drinks[0],RR=600},
                new Student {LastName= "Левин",FirstName="Александр", ID=4,Category=Alco.nix,DrinkType=drinks[3],RR=1500},
                new Student {LastName = "Лудоволков", FirstName = "Афоня", ID=5,Category=Alco.lyubitel,DrinkType=drinks[2],RR=200}
            };
            double obshRR = 0;
            double obshAl = 0;
            for (int i = 0;i < students.Length; i++)
            {
                obshRR += students[i].RR;
                obshAl += students[i].alcV;
            }
            Console.WriteLine($"Общий объем: {obshRR} мл");
            Console.WriteLine($"Общий алкогооль: {obshAl} мл");
            for (int i = 0; i < students.Length; i++) 
            {
                double vPercent = students[i].RR / obshRR * 100;
                double alcPercent = 0;
                if (obshAl>0)
                {
                    alcPercent = students[i].alcV / obshAl * 100;
                }
                Console.WriteLine($"{students[i].LastName}, {vPercent:F1}% жидкости, {alcPercent:F1}% алкоголя");
            }
            

        }
    }
}
