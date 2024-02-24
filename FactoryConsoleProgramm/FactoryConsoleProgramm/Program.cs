using System.Text;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tanks = GetTanks();
            var units = GetUnits();
            var factories = GetFactories();
            Console.WriteLine(GetTankNamesInfo(tanks, units, factories));
            Console.WriteLine(GetTotalVolume(tanks));
        }

        public static List<Tank> GetTanks()
        {
            return new List<Tank> {
                new Tank(1, "Резервуар 1", "Надземный - вертикальный", 1500, 2000, 1),
                new Tank(2, "Резервуар 2", "Надземный - горизонтальный", 2500, 3000, 1),
                new Tank(3, "Дополнительный резервуар 24", "Надземный - горизонтальный", 3000, 3000, 2),
                new Tank(4, "Резервуар 35", "Надземный - вертикальный", 3000, 3000, 2),
                new Tank(5, "Резервуар 47", "Подземный - двустенный", 4000, 5000, 2),
                new Tank(6, "Резервуар 256", "Подводный", 500, 500, 3)
            };
        }
        public static List<Unit> GetUnits()
        {
            return new List<Unit>
            {
                new Unit(1, "ГФУ-2", "Газофракционирующая установка", 1),
                new Unit(2, "АВТ-6", "Атмосферно-вакуумная трубчатка", 1),
                new Unit(3, "АВТ-10", "Атмосферно-вакуумная трубчатка", 2)
            };
        }
        public static List<Factory> GetFactories()
        {
            return new List<Factory>
            {
                new Factory(1, "НПЗ№1", "Первый нефтеперерабатывающий завод"),
                new Factory(2, "НПЗ№2", "Второй нефтеперерабатывающий завод")
            };
        }
        public static Unit? FindUnit(List<Unit> units, List<Tank> tanks, string tankName)
        {
            int? unitId = null;
            foreach (Tank tank in tanks)
            {
                if (tank.Name == tankName)
                {
                    unitId = tank.UnitId;
                    break;
                }
            }
            if (unitId == null) throw new NullReferenceException($"Tank {tankName} dont exist");
            foreach (Unit unit in units)
            {
                if (unit.Id == unitId) return unit;
            }
            throw new NullReferenceException($"Unit id = {unitId} dont exist");
        }
        public static Factory FindFactory(List<Factory> factories, Unit unit)
        {
            foreach (Factory factory in factories)
            {
                if (factory.Id == unit.FactoryId) return factory;
            }
            throw new NullReferenceException($"Factory id = {unit.FactoryId} dont exist");
        }
        public static int GetTotalVolume(List<Tank> tanks)
        {
            int totalVolume = 0;
            foreach (Tank tank in tanks) { totalVolume += tank.Volume; }
            return totalVolume;
        }
        public static string GetTankNamesInfo(List<Tank> tanks, List<Unit> units, List<Factory> factories)
        {
            StringBuilder result = new StringBuilder();
            foreach (Tank tank in tanks)
            {
                result.Append(tank.Name + "\t");
                foreach (Unit unit in units)
                {
                    if (tank.UnitId == unit.Id)
                    {
                        result.Append(unit.Name + "\t");
                        foreach (Factory factory in factories)
                        {
                            if (unit.FactoryId == factory.Id) result.Append(factory.Name + "\n");
                        }
                    }
                }
            }
            return result.ToString();
        }
    }

    public class Factory
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        public Factory(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
    public class Unit
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
    }
    public class Tank
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
    }
}