using Enums;
namespace Bank
{

    struct PersonsAccount
    {
        public string id;
        public string type;
        public float balance;

        public void Print()
        {
            Console.WriteLine($"номер = {id}, тип = {type} баланс = {balance}");
        }

    }


    struct Worker
    {
        public string name;
        public Univirsity workPlace;

        public void Print()
        {
            Console.WriteLine($"имя = {name}, место работы = {workPlace}");
        }
    }
}
