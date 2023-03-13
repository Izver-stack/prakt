
namespace zadacha_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = { ' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?' };
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class TEST
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("Обещать – дело господское, исполнять – холопское."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("5Лу4чше с5ини4ца в2 ру6ках, 4че5м жу8ра1вль в н5е6бе."));
            Console.ReadKey(true);
        }
    }
}
