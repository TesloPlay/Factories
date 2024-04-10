using System.Text.Json;
using System.Text.Json.Nodes;

namespace DealsProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deals:");
            IList<Deal> deals = ReadDealsFromFile("JSON_sample_1.json");
            WriteListToConsole(deals);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Numbers of Deals:");
            WriteListToConsole(GetNumbersOfDeals(deals));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Sum by Month:");
            WriteListToConsole(GetSumByMonth(deals));
        }

        static void WriteListToConsole<T>(IList<T> list)
        {
            foreach (var item in list)
                Console.WriteLine(item.ToString());
        }

        static IList<Deal> ReadDealsFromFile(string path)
        {
            return JsonSerializer.Deserialize<IList<Deal>>(File.ReadAllText(path));
        }

        static IList<string> GetNumbersOfDeals(IEnumerable<Deal> deals)
        {
            var selected = from deal in deals where deal.Sum >= 100 select deal;
            selected = selected.OrderBy(deal => deal.Date).Take(5);
            return selected.OrderBy(item => item.Sum).Reverse().Select(item => item.Id).ToList();
        }

        record SumByMonth(DateTime Month, int Sum)
        {
            public override string ToString() => $"{Month} {Sum}";
        };
        static IList<SumByMonth> GetSumByMonth(IEnumerable<Deal> deals)
        {
            DateTime now = DateTime.Now;
            var sums = deals.GroupBy(item => item.Date.Month).Select(item => new SumByMonth(new DateTime(now.Year,item.Key,now.Day), item.AsEnumerable().Select(deal => deal.Sum).Sum()));
            return sums.ToList();
        }
    }
}