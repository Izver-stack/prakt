namespace zadacha_2
{
    class Package
    {
        public string Description { get; private set; }
        public int Weight { get; private set; }
        public Package(string description, int weight)
        {
            Description = description;
            Weight = weight;
        }
    }
    class Otpravka
    {
        private const int Limit = 20;
        private static int LimitWeight;

        public void SendPackage(Package package)
        {
            LimitWeight += package.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine(
                    "Ошибка! Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.",
                                  package.Description, package.Weight);
            }
        }
    }
    class mail
    {
        static void Main(string[] args)
        {
            Package package_1 = new Package("Легкая посылка #1", 5);
            Package package_2 = new Package("Тяжелая посылка #2", 10);
            Otpravka sendingService = new Otpravka();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey();
        }
    }
}