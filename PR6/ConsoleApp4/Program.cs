namespace zadacha_4
{
    interface ISpell
    {
        string Name { get; set; }
        int Knowledge { get; set; }
        void WriteInfo();
    }
    namespace zadacha_1
    {
        class Spell
        {
            public string Name { get; private set; }
            public int Knowledge { get; private set; }
            private string Effect { get; set; }
            public Spell(string name, int knowledge, string effect)
            {
                Name = name;
                Knowledge = knowledge;
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
            public int Knowledge { get; private set; }
            public Magician(string name, int knowledge)
            {
                Name = name;
                Knowledge = knowledge;
            }
            public void CastSpell(Spell spell)
            {
                if (Knowledge >= spell.Knowledge)
                {
                    Knowledge -= spell.Knowledge;
                    Console.WriteLine("{0} Пишет!", Name);
                    spell.Use();
                }
                else
                {
                    int mana = spell.Knowledge - Knowledge;
                    Console.WriteLine(
                        "Для использования {0} не хватает {1} Опыта. Пройдите курсы!",
                        spell.Name, mana);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Spell Print = new Spell("Вызов функции", 60, "Код компилируется");
                Spell vingardiumLeviosa =
                    new Spell(" 'Создать метод' ", 40, "Метод вeрно принял значение!");
                Magician garryPotter = new Magician("Максим Рязанов", 100);
                garryPotter.CastSpell(Print);
                garryPotter.CastSpell(vingardiumLeviosa);
                Console.ReadKey();
            }
        }
    }
}