namespace Structs
{
    struct Person
    {
        public string name;
        public string town;
        public DateTime birthday;
        public UInt16 pin;
        public void Print()
        {
            Console.WriteLine($"{name}, {town}, {pin}, {(int)((DateTime.Today - birthday).Days / 365.25)}\n");
        }
    }

    struct Form
    {
        public string name;
        public string lastName;
        public string id;
        public DateTime birthday;
        public string category;
        public float drunk;
    }
    
    struct Drinks
    {
        public float hoegaarden;
        public Byte limonad;
        public float veuveClicqut;
        public float ohota;
        public float jagermeister; 

        public Drinks()
        {
            hoegaarden = 0.046f;
            limonad = 0;
            veuveClicqut = 0.12f;
            ohota = 0.08f;
        }

    }
}
