using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    public delegate void ConsoleReadHandler(string? readedLine);

    static class ConsoleInteraction
    {
        public static event ConsoleReadHandler? OnRead;
        static public void WriteMenuToConsole(Dictionary<int, string> menu)
        {
            foreach (var pair in menu) Console.WriteLine($"{pair.Key}. {pair.Value}");
        }
        static public void WriteListToConsole<T>(IEnumerable<T> values)
        {
            if (values.Count() > 0)
                foreach (T item in values) Console.WriteLine(item.ToString());
            else Console.WriteLine("Список пуст");
        }
        static public void WriteLine(string? line)
        {
            Console.WriteLine(line);
        }
        static public string? ReadLine()
        {
            string? line = Console.ReadLine();
            if (OnRead != null) OnRead.Invoke(line);
            return line;
        }
        static public void ConsoleReadCheck(string? readedLine)
        {
            Console.WriteLine($"Пользователь ввёл <{readedLine}> в <{DateTime.Now}>");
        }
        static public void Subscribe() { OnRead += ConsoleReadCheck; }
        static public void Unsubscribe() { OnRead -= ConsoleReadCheck; }
    }
}
 