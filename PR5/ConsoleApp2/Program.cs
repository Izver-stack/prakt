namespace zadacha_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Arabic : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Ас-саляму алейкум");
        }
    }
    class Español : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("hola");
        }
    }
    class Polish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Cześć");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Arabic());
            greetings.Add(new Español());
            greetings.Add(new Polish());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}
