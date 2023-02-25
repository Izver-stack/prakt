// See https://aka.ms/new-console-template for more information
Car vaz2115 = new Car();
vaz2115.name = "Ваз 2115";
vaz2115.speed = 100;
vaz2115.Print();

Car priora = new Car();
priora.name = "Лада Приора";
priora.speed = 140;
priora.Print();

Car astra = new Car();
astra.name = "Опель Астра";
astra.speed = 190;
astra.Print();

Car lamba = new Car();
lamba.name = "Ламборгини урус";
lamba.speed = 40;
lamba.Print();

Console.WriteLine($"гоночки");
if (vaz2115.speed> priora.speed)
{
    Console.WriteLine($"ВАЗ 21115 пришел первым");
}

if (priora.speed> astra.speed)
{
    Console.WriteLine($"Приора пришла второй");
}

if (astra.speed> lamba.speed)
{
    Console.WriteLine($"ВАЗ 21115 пришла третьей, а ламба последней");
}

class Car
{
    public string name;
    public int speed;
    public void Print()
    {
        Console.WriteLine($"Название автомобиля: {name}");
        Console.WriteLine($"Максимальная скорость: {speed} км/ч");
    }
}

