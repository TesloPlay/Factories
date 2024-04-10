using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealsProgramm
{
    internal class Deal
    {
        public int Sum { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }

        public override string ToString() => $"{Sum} {Id} {Date}";
    }
}
