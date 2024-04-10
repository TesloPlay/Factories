using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    internal class Unit
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int FactoryId { get; }

        public Unit(int id, string name, string description, int factoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.FactoryId = factoryId;
        }

        public override string ToString() => $"{Id} ({Name}) ({Description}) {FactoryId}";
    }
}
