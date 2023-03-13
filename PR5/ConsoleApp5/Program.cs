

namespace zadacha_5
{
    interface ISpell
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    namespace zadacha_1
    {
        class Spell
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            private string Effect { get; set; }
            public Spell(string name, int mana, string effect)
            {
                Name = name;
                Mana = mana;
                Effect = effect;
            }
            public void Use()
            {
                Console.WriteLine(Effect);
            }
        }
        class Magician
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            public Magician(string name, int mana)
            {
                Name = name;
                Mana = mana;
            }
            public void CastSpell(Spell spell)
            {
                if (Mana >= spell.Mana)
                {
                    Mana -= spell.Mana;
                    Console.WriteLine("{0} колдует!", Name);
                    spell.Use();
                }
                else
                {
                    int mana = spell.Mana - Mana;
                    Console.WriteLine(
                        "Для использования {0} не хватает {1} единиц маны. Хлебните зелья!",
                        spell.Name, mana);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Spell alohomora = new Spell("Алохомора", 60, "Замок открывается!");
                Spell vingardiumLeviosa = new Spell("Вингардиум Левиоса", 40, "Предмет поднимается в воздух!");
                Magician garryPotter = new Magician("Гарри Поттер", 100);
                garryPotter.CastSpell(alohomora);
                garryPotter.CastSpell(vingardiumLeviosa);
                Console.ReadKey();
            }
        }
    }
}