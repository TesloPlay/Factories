using System.Xml;

namespace Events
{
    internal class Program
    {
        public delegate void ReadingDelegate(int arg);
        static public event ReadingDelegate OnRead;
        static void Main(string[] args)
        {
            UserEnteredNumberEventArgs UENEA = new UserEnteredNumberEventArgs();
            OnRead += UENEA.WhenAndWhatWasReaded;

            while (true)
            {
                var line = Console.ReadLine();
                if (int.TryParse(line, out int num)) UENEA.WhenAndWhatWasReaded(num);
            }
        }
    }

    internal class UserEnteredNumberEventArgs
    {
        public int Input { get; set; }
        public DateTime EnteredAt { get; set; }
        
        public void WhenAndWhatWasReaded(int number)
        {
            Input = number;
            EnteredAt = DateTime.Now;
            Console.WriteLine($"Пользователь ввёл <{Input}> в <{EnteredAt}>");
        }
    }
}
