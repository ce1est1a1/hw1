using System;
using Structs;

namespace homeWork
{
    class Programm
    {
        static void Main()
        {
            //выводит название максимальное и минимальное значение для всех значимыи типов данных
            Console.WriteLine($"SByte минимальное значение {SByte.MinValue} максимальное значение {SByte.MaxValue}\n");
            Console.WriteLine($"Byte минимальное значение {Byte.MinValue} максимальное значение {Byte.MaxValue}\n");
            Console.WriteLine($"Int16 минимальное значение {Int16.MinValue} максимальное значение {Int16.MaxValue}\n");
            Console.WriteLine($"UInt16 минимальное значение {UInt16.MinValue} максимальное значение {UInt16.MaxValue}\n");
            Console.WriteLine($"Int32 минимальное значение {Int32.MinValue} максимальное значение {Int32.MaxValue}\n");
            Console.WriteLine($"UInt32 минимальное значение {UInt32.MinValue} максимальное значение {UInt32.MaxValue}\n");
            Console.WriteLine($"Int64 минимальное значение {Int64.MinValue} максимальное значение {Int64.MaxValue}\n");
            Console.WriteLine($"UInt64 минимальное значение {UInt64.MinValue} максимальное значение {UInt64.MaxValue}\n");
            Console.WriteLine($"Char минимальное значение U+0000 максимальное значение U+FFFF\n");
            Console.WriteLine($"Single минимальное значение {Single.MinValue} максимальное значение {Single.MaxValue}\n");
            Console.WriteLine($"Double минимальное значение {Double.MinValue} максимальное значение {Double.MaxValue}\n");
            Console.WriteLine($"Boolean True/False\n");
            Console.WriteLine($"Decimal минимальное значение {Decimal.MinValue} максимальное значение {Decimal.MaxValue}\n");
            Console.WriteLine($"IntPtr минимальное и максимальное числа зависят от разрядности системы\n");
            Console.WriteLine($"UIntPtr минимальное и максимальное числа зависят от разрядности, не имеет знака\n");
            // создать переменную. которая принимает некоьорые значения
            // после выводит их в правильном форате
            Console.WriteLine("введите имя, город, пин-код и дату рождения(гггг, мм, дд)");
            Person person = new Person()
            {
                name = Console.ReadLine(),
                town = Console.ReadLine()
            };
            if (!UInt16.TryParse(Console.ReadLine(), out person.pin) || (1000 >= person.pin && person.pin >= 10000) || !DateTime.TryParse(Console.ReadLine(), out person.birthday) || person.birthday > DateTime.Today)
            {
                Console.WriteLine("данные введены неверно\n");
            }
            else {person.Print();}
            //изменить регстр
            Console.WriteLine("введите строку, поменяет регистр");
            string str = Console.ReadLine();
            string upper = str.ToUpper();
            string lower = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == upper[i])
                {
                    Console.Write(lower[i]);
                }
                else {Console.Write(upper[i]);}
            }
            Console.WriteLine();
            //ввежиье строку и полжстроку, выведет кол во вхождений
            Console.WriteLine("введите строку и подстроку");
            str = Console.ReadLine();
            string subString = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i <= str.Length - subString.Length; i++)
            {   
                if (str.Substring(i, subString.Length) == subString)
                {
                    counter++;
                }
            }
            Console.WriteLine($"количество вхождений подстроки в строку {counter}");
            //принимает ценубутылки, скидку, цену на отпуск
            Console.WriteLine("введите цену бутылки, скидку, цену отпуска");
            float normPrice;
            float salePrice;
            float holidayPrice;
            if (!float.TryParse(Console.ReadLine(), out normPrice) || normPrice % 1 != 0 || !float.TryParse(Console.ReadLine(), out salePrice) || !float.TryParse(Console.ReadLine(), out holidayPrice) || salePrice % 1 != 0 || holidayPrice % 1 != 0 || (normPrice == 0 && salePrice == 0))
            {
                 Console.WriteLine("данные введены неверно \n");
            }
            else if(salePrice == 0) {Console.WriteLine("скидка равно 0, вы не сможете заработать на отпуск\n");}
            else if (normPrice == 0) {Console.WriteLine("такого не бывает\n");}
            else 
            {
                Console.Write("чтобы поехать на отпуск нужно продать ");
                Console.WriteLine((holidayPrice / (normPrice * (salePrice / 100))) % 1 == 0 ? (int)(holidayPrice / (normPrice * (salePrice / 100))): (int)(holidayPrice / (normPrice * (salePrice / 100))) + 1);
                Console.WriteLine();
            }
            //стедунты
            Form[] group = new Form[5];
            Form student0 = new Form()
            {
                name = "Миша",
                lastName = "Крюков",
                id = "0000",
                birthday = new DateTime(2007, 10, 03),
                category = "a-студент алкоголик",
                drunk = 3.42f
            };

            Form student1 = new Form()
            {
                name = "Иван",
                lastName = "Сашин",
                id = "0001",
                birthday = new DateTime(2007, 08, 22),
                category = "a-студент алкоголик",
                drunk = 2.3f
            };

            Form student2 = new Form()
            {
                name = "Максим",
                lastName = "Златоруков",
                id = "0002",
                birthday = new DateTime(2007, 08, 03),
                category = "d-студент не пьет",
                drunk = 4
            };

            Form student3 = new Form()
            {
                name = "Андрей",
                lastName = "Тимошин",
                id = "0003",
                birthday = new DateTime(2007, 09, 14),
                category = "b-любитель выпить но не алкоголик",
                drunk = 4
            };

            Form student4 = new Form()
            {
                name = "Максим",
                lastName = "Бананьев",
                id = "0004",
                birthday = new DateTime(2006, 10, 22),
                category = "c-студент пьет по праздникам",
                drunk = 0.8f 
            };
            
            group = [student0, student1, student2, student3, student4];
            Drinks drinks = new Drinks();
            float capacity = 0;
            float alcoholCapcty = 0;
            foreach (Form student in group)
            {
                capacity += student.drunk;
            }
            Console.WriteLine($"общий объем выпитого студнтами {capacity}");

            foreach (Form student in group)
            {
                if (student.category[0] == 'a') {alcoholCapcty += student.drunk * drinks.ohota;}
                else if (student.category[0] == 'b') {alcoholCapcty += student.drunk * drinks.hoegaarden;}
                else if (student.category[0] == 'c') {alcoholCapcty += student.drunk * drinks.veuveClicqut;}
                else if (student.category[0] == 'd') {alcoholCapcty += student.drunk * drinks.limonad;}
            }

            Console.WriteLine($"объем чистого алкоголя, который выпили студенты {alcoholCapcty}\n");
            foreach (Form student in group)
            {
                if (student.category[0] == 'a') {Console.WriteLine($"{student.lastName} {student.name} выпил {alcoholCapcty / (student.drunk * drinks.ohota)} процентов всего алкоголя");}
                else if (student.category[0] == 'b') {Console.WriteLine($"{student.lastName} {student.name} выпил {alcoholCapcty / (student.drunk * drinks.hoegaarden)} процентов всего алкоголя");}
                else if (student.category[0] == 'c') {Console.WriteLine($"{student.lastName} {student.name} выпил {alcoholCapcty / (student.drunk * drinks.veuveClicqut)} процентов всего алкоголя");}
                else if (student.category[0] == 'd') {Console.WriteLine($"{student.lastName} {student.name} пил лимонад");}
            }
            Console.WriteLine(); 
            foreach (Form student in group)
            {
                Console.WriteLine($"{student.lastName} {student.name} выпил {capacity / student.drunk} процентов от объема выпитого");
            }
            
        }
    }
}
