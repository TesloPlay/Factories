using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    internal interface IIndexedElement
    {
        public int Id { get; }
        public string Name { get; }

        string ToString();
    }
}
