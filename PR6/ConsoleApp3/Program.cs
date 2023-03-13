
namespace zadacha_3
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public Human(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Employees : Human
    {
        public string Post { get; set; }
        public Employees(string name, int age, char gender, string post)
            : base(name, age, gender)
        {
            Post = post;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Timonov = new Human("Тимонов Иван Юрьевич", 19, 'М');
            Console.WriteLine(Timonov.Name);
            Employees Ryazanov =
                new Employees("Рязанов Максим Сергеевич", 18, 'М', "Программист С++");
            Console.WriteLine(Ryazanov.Post);
            Console.ReadKey(true);
        }
    }
}