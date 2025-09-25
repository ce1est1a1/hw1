using System;
using Enums;
using Struct;

namespace Tumakov
{
    internal class TumakovCode
    {
        static void Main(string[] args)
        {
            // ----------------------------
            // 1ST
            // ----------------------------
            
            Console.WriteLine("\n1)");
            AccountType account = AccountType.Current;
            Console.WriteLine($"Account type: {account}");
            
            // ----------------------------
            // 2ND
            // ----------------------------
            
            Console.WriteLine("\n2)");
            bankData account1;
            account1.Number = 111;
            account1.Type = "Current";
            account1.Balance = 12344321;
            Console.WriteLine($"Number: {account1.Number}");
            Console.WriteLine($"Type: {account1.Type}");
            Console.WriteLine($"Balance: {account1.Balance}");
            
            // ----------------------------
            // 3RD
            // ----------------------------
            
            Console.WriteLine("\n3)");
            Worker worker;
            worker.Name = "Daniil";
            worker.University = Uni.КГУ;
            Console.WriteLine($"Worker: {worker.Name}");
            Console.WriteLine($"University: {worker.University}");

        }
    }
}
