using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    public delegate string? ConsoleRead();

    internal class ConsoleWriter
    {
        public static event ConsoleRead OnRead;
        static public void WriteListToConsole<T>(List<T> values)
        {
            if (values.Count() > 0)
                foreach (T item in values) Console.WriteLine(item.ToString());
            else Console.WriteLine("Список пуст");
        }
        static public string? ConsoleReadNum()
        {
            string? line = Console.ReadLine();
            int result;
            if (line == null || int.TryParse(line, out result)) return null;
            Console.WriteLine($"Пользователь ввёл число {result} в {DateTime.Now.TimeOfDay}");
            return line;
        }
    }
}
 