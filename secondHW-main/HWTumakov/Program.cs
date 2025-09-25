using System;
using Bank;
using Enums;
namespace homeWork
{
    class Programm
    {
        static void Main()
        {
            //Задание 3.1 создать перечислимый тип данных - счет(текущий и сберегательный)
            //создать переменную типа пересисления, присвоить ей значение и вывести эти значения
            AccountInfo firstAccount = AccountInfo.currentAccount;
            AccountInfo secondAccount = AccountInfo.savingsAccount;
            Console.WriteLine($"currentAccount = {(int)firstAccount} ssavingsAccount = {(int)secondAccount}");
            //3.2 создвть структуру данных, которая хранит инфу о счете: номер, тип, баланс.
            //создать переменную, заплоднитб структуру
            Console.WriteLine("введите номер счета, тип счета, баланс счета");
            PersonsAccount info = new PersonsAccount()
            {
                id = Console.ReadLine(),
                type = Console.ReadLine(),
            };
            if (!float.TryParse(Console.ReadLine(), out info.balance))
            {
                Console.WriteLine("баланс введен некорректно");
            }
            else {info.Print();}
            //Задание 3.1 создать перечислимый тип вуз... . Создать структуру работник с двумя полями
            //заполнить заполнить и распечатать
            Console.WriteLine("введите имя и название вуза(KFU KHTI KAI)");
            Worker person = new Worker();
            Univirsity univirsity;
            person.name = Console.ReadLine();
            if (!Univirsity.TryParse(Console.ReadLine(), out univirsity))
            {
                Console.WriteLine("введено некорректное название вуза");
            }
            else 
            {
                
                person.workPlace = univirsity;
                person.Print();
            }


        }
    }
}
