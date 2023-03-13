
namespace zadacha_2
{
    class TS
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public TS(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytehMachina : TS
    {
        public void MusicON()
        {
            Console.WriteLine("Громко включить плохую музыку");
        }
        public PolytehMachina(string name, int speed) : base(name, speed) { }
    }
    class Airplane : TS
    {
        public void DustCrops()
        {
            Console.WriteLine("Опылить поле");
        }
        public Airplane(string name, int speed) : base(name, speed) { }
    }
    class ConcreteMixer : TS
    {
        public void CementMixer()
        {
            Console.WriteLine("Мешать бетон");
        }
        public ConcreteMixer(string name, int speed) : base(name, speed) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TS Car = new TS("Лада ВАЗ 2115", 180);
            PolytehMachina Polytech = new PolytehMachina("Политех-машина", 140);
            Polytech.MusicON();
            Airplane Boeing = new Airplane("Патриот", 1500);
            Boeing.DustCrops();
            ConcreteMixer beton = new ConcreteMixer("Добрыня-1", 10);
            beton.CementMixer();
            Console.ReadKey(true);
        }
    }
}