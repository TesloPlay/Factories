using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsoleProgramm
{
    internal class Tank : IIndexedElement
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Volume { get; }
        public int MaxVolume { get; }
        public int UnitId { get; }

        public Tank(int id, string name, string description, int volume, int maxVolume, int unitId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Volume = volume;
            this.MaxVolume = maxVolume;
            this.UnitId = unitId;
        }

        public override string ToString() => $"{Id} ({Name}) ({Description}) {Volume} {MaxVolume} {UnitId}";
    }
}
