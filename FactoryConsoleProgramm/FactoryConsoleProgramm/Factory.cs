using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    public class Factory
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public Factory(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public override string ToString() => $"{Id} ({Name}) ({Description})";
    }
}
