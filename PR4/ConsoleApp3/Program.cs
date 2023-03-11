
namespace zadacha_3
{
    class Orc
    {
        private static int Count;
        public static int totalGolD { get; private set; }
        public int StealGolD { get; private set; }
        public Orc()
        {
            Count++;
            totalGolD += 2;
            if (Count > 5)
            {
                StealGolD += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            Console.WriteLine(Orc.totalGolD);
            Orc orc_2 = new Orc();
            Orc orc_3 = new Orc();
            Console.WriteLine(Orc.totalGolD);
            Orc orc_4 = new Orc();
            Orc orc_5 = new Orc();
            Orc orc_6 = new Orc();
            Console.WriteLine(orc_6.StealGolD);
            Console.ReadKey(true);
        }
    }
}