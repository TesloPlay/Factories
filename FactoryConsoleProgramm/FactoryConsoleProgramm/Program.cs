﻿using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FactoryConsoleProgramm;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var tanks = GetTanks();
            //var units = GetUnits();
            //var factories = GetFactories();

            //WriteListToFile<Tank>("TankList.json", tanks);
            //WriteListToFile<Unit>("UnitList.json", units);
            //WriteListToFile<Factory>("FactoryList.json", factories);

            var tanks = ReadListFromFile<Tank>("TankList");
            var units = ReadListFromFile<Unit>("UnitList");
            var factories = ReadListFromFile<Factory>("FactoryList");

            ConsoleWriter.WriteListToConsole<Tank>(tanks);

            

            #region Zad1
            //while (true)
            //{
            //    // Главное меню
            //    Console.Clear();
            //    Console.WriteLine("1. Получить имя установки по имени резервуара\n" +
            //        "2. Получить имена всех резервуаров, имена их установок и фабрик\n" +
            //        "3. Получить общую сумму загрузки всех резервуаров\n" +
            //        "4. Найти объект по наименованию в колекции\n" +
            //        "5. Завершить работу программы");
            //    switch (Console.ReadLine())
            //    {
            //        // Получение имени установки по имени резервуара
            //        case "1":
            //            Console.Clear();
            //            Console.Write("Введите название резервуара: ");
            //            try
            //            {
            //                Console.WriteLine(FindUnit(units, tanks, Console.ReadLine()).Name);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        // Получение имён всех резервуаров, установок и фабрик
            //        case "2":
            //            Console.Clear();
            //            Console.WriteLine("Резервуары:");
            //            Console.WriteLine(GetTankNamesInfo(tanks, units, factories));
            //            break;
            //        // Получение общей суммы загрузки всех резервуаров
            //        case "3":
            //            Console.Clear();
            //            Console.Write("Общая загруженность резервуаров: ");
            //            Console.WriteLine(GetTotalVolume(tanks));
            //            break;
            //        // Ищем объект по названию
            //        case "4":
            //            Console.Clear();
            //            Console.WriteLine("1. Найти резервуар\n" +
            //                "2. Найти установку\n" +
            //                "3. Найти завод");
            //            try
            //            {
            //                switch (Console.ReadLine())
            //                {
            //                    // Ищем резеруар
            //                    case "1":
            //                        Console.WriteLine("Введите название резервуара");
            //                        Tank tank = FindTankByName(tanks, Console.ReadLine());
            //                        Console.WriteLine($"Название: {tank.Name}\nОписание: {tank.Description}\nЗагруженность: {tank.Volume}\nМаксимальная загруженность: {tank.MaxVolume}");
            //                        break;
            //                    // Ищем установку
            //                    case "2":
            //                        Console.WriteLine("Введите название установки");
            //                        Unit unit = FindUnitByName(units, Console.ReadLine());
            //                        Console.WriteLine($"Название: {unit.Name}\nОписание: {unit.Description}");
            //                        break;
            //                    // Ищем завод
            //                    case "3":
            //                        Console.WriteLine("Введите название резервуара");
            //                        Factory factory = FindFactoryByName(factories, Console.ReadLine());
            //                        Console.WriteLine($"Название: {factory.Name}\nОписание: {factory.Description}");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Неверный ввод");
            //                        break;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }

            //            break;
            //        // Завершаем программу
            //        case "5":
            //            return;
            //            break;
            //        default:
            //            Console.WriteLine("Неверный ввод");
            //            break;

            //    }
            //    Console.ReadLine();
            //}
            #endregion
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

        public static void WriteListToFile<T>(string filename, List<T> values)
        {
            string serializedList = JsonSerializer.Serialize(values);
            File.WriteAllText(filename, serializedList);
        }
        public static List<T> ReadListFromFile<T>(string filename)
        {
            List<T>? values = JsonSerializer.Deserialize<List<T>>(File.ReadAllText(filename));
            if (values == null)
                throw new ArgumentNullException(nameof(values),$"Cant read file {filename}");
            return values;
        }

        //public static void WriteListToConsole<T>(List<T> values)
        //{
        //    if (values.Count() > 0)
        //        foreach (T item in values) Console.WriteLine(item.ToString());
        //    else Console.WriteLine("Список пуст");
        //}


        /// <summary>
        /// Поиск установки по названию резервуара
        /// </summary>
        /// <param name="units">коллекция установок</param>
        /// <param name="tanks">коллекция резервуаров</param>
        /// <param name="tankName">название резервуара</param>
        /// <returns>искомая установка</returns>
        public static Unit FindUnit(List<Unit> units, List<Tank> tanks, string tankName)
        {
            #region OldCode
            //int? unitId = null;
            //foreach (Tank tank in tanks)
            //{
            //    if (tank.Name == tankName)
            //    {
            //        unitId = tank.UnitId;
            //        break;
            //    }
            //}
            //if (unitId == null) throw new NullReferenceException($"Tank {tankName} dont exist");
            //foreach (Unit unit in units)
            //{
            //    if (unit.Id == unitId) return unit;
            //}
            //throw new NullReferenceException($"Unit id = {unitId} dont exist");
            #endregion

            //var findTanks = tanks.Where(item => item.Name.Equals(tankName);
            //if (findTanks.Any())
            //    return units.Where(item => item.Id.Equals(findTanks.ElementAt(0).UnitId)).ElementAt(0);
            //else throw new NullReferenceException($"Unit id = {findTanks.ElementAt(0).UnitId} dont exist");

            var findTanks = from tank in tanks where tank.Name == tankName select tank;
            if (findTanks.Any())
                return (from unit in units where unit.Id == findTanks.ElementAt(0).UnitId select unit).ElementAt(0);
            else throw new NullReferenceException($"Unit id = {findTanks.ElementAt(0).UnitId} dont exist");
        }

        /// <summary>
        /// Поиск завода по установке
        /// </summary>
        /// <param name="factories">коллекция заводов</param>
        /// <param name="unit">установка</param>
        /// <returns>искомый завод</returns>
        public static Factory FindFactory(List<Factory> factories, Unit unit)
        {
            #region  OldCode
            //foreach (Factory factory in factories)
            //{
            //    if (factory.Id == unit.FactoryId) return factory;
            //}
            //throw new NullReferenceException($"Factory id = {unit.FactoryId} dont exist");
            #endregion

            //var findFactory = factories.Where(item => item.Id == unit.FactoryId);
            //if (findFactory.Any())
            //    return findFactory.First();
            //else throw new NullReferenceException($"Factory id = {unit.FactoryId} dont exist");

            var findFactory = from factory in factories where factory.Id == unit.FactoryId select factory;
            if (findFactory.Any())
                return findFactory.First();
            else throw new NullReferenceException($"Factory id = {unit.FactoryId} dont exist");
        }

        /// <summary>
        /// Подсчитывает общую загруженность резервуаров
        /// </summary>
        /// <param name="tanks">коллекция резервуаров</param>
        /// <returns>общая загруженность резервуаров</returns>
        public static int GetTotalVolume(List<Tank> tanks)
        {
            #region OldCode
            //int totalVolume = 0;
            //foreach (Tank tank in tanks) { totalVolume += tank.Volume; }
            //return totalVolume;
            #endregion

            //return tanks.Select(tank => tank.Volume).Sum();

            return (from tank in tanks select tank.Volume).Sum();
        }

        /// <summary>
        /// Собирает названия резервуара, его установки и завода из коллекций
        /// </summary>
        /// <param name="tanks">коллекция резервуаров</param>
        /// <param name="units">коллекция установок</param>
        /// <param name="factories">коллекция заводов</param>
        /// <returns>названия резервуара, его установки и завода</returns>
        public static string GetTankNamesInfo(List<Tank> tanks, List<Unit> units, List<Factory> factories)
        {
            #region OldCode
            //StringBuilder result = new StringBuilder();
            //foreach (Tank tank in tanks)
            //{
            //    result.Append(tank.Name + "\t");
            //    foreach (Unit unit in units)
            //    {
            //        if (tank.UnitId == unit.Id)
            //        {
            //            result.Append(unit.Name + "\t");
            //            foreach (Factory factory in factories)
            //            {
            //                if (unit.FactoryId == factory.Id) result.Append(factory.Name + "\n");
            //            }
            //        }
            //    }
            //}
            //return result.ToString();
            #endregion

            StringBuilder result = new StringBuilder();
            tanks.ForEach(tank => { 
                result.Append(tank.Name + "\t");
                units.Where(unit => tank.UnitId == unit.Id).ToList().ForEach(unit => {
                    result.Append(unit.Name + "\t");
                    factories.Where(factory => factory.Id==unit.FactoryId).ToList().ForEach(factory => result.Append(factory.Name + "\n"));
                });
            });
            return result.ToString();
        }

        /// <summary>
        /// Поиск резервуара по названию
        /// </summary>
        /// <param name="tanks">коллекция резервуаров</param>
        /// <param name="tankName">название искомого резервуара</param>
        /// <returns>исомый резервуар</returns>
        public static Tank FindTankByName(List<Tank> tanks, string tankName)
        {
            #region OldCode
            //foreach (Tank tank in tanks) 
            //{ 
            //    if (tank.Name == tankName) return tank;
            //}
            //throw new NullReferenceException($"Tank {tankName} dont exist");
            #endregion

            //var findTank = tanks.Where(item => item.Name == tankName);
            //if (findTank.Any())
            //    return findTank.First();
            //else throw new NullReferenceException($"Tank {tankName} dont exist");

            var findTank = from tank in tanks where tank.Name == tankName select tank;
            if (findTank.Any())
                return findTank.First();
            else throw new NullReferenceException($"Tank {tankName} dont exist");
        }

        /// <summary>
        /// Поиск установки по названию
        /// </summary>
        /// <param name="units">коллекция установок</param>
        /// <param name="unitName">название искомой установки</param>
        /// <returns>искомая установка</returns>
        public static Unit FindUnitByName(List<Unit> units, string unitName)
        {
            #region OldCode
            //foreach (Unit unit in units)
            //{
            //    if (unit.Name == unitName) return unit;
            //}
            //throw new NullReferenceException($"Unit {unitName} dont exist");
            #endregion

            //var findUnit = units.Where(item => item.Name == unitName);
            //if (findUnit.Any())
            //    return findUnit.First();
            //else throw new NullReferenceException($"Unit {unitName} dont exist");

            var findUnit = from unit in units where unit.Name == unitName select unit;
            if (findUnit.Any())
                return findUnit.First();
            else throw new NullReferenceException($"Unit {unitName} dont exist");
        }

        /// <summary>
        /// Поиск завода по названию
        /// </summary>
        /// <param name="factories">коллекция заводов</param>
        /// <param name="factoryName">название искомого завода</param>
        /// <returns>искомый завод</returns>
        public static Factory FindFactoryByName(List<Factory> factories, string factoryName)
        {
            #region OldCode
            //foreach (Factory factory in factories)
            //{
            //    if (factory.Name == factoryName) return factory;
            //}
            //throw new NullReferenceException($"Factory {factoryName} dont exist");
            #endregion

            //var findFactory = factories.Where(item => item.Name == factoryName);
            //if (findFactory.Any())
            //    return findFactory.First();
            //else throw new NullReferenceException($"Factory {factoryName} dont exist");

            var findFactory = from factory in factories where factory.Name == factoryName select factory;
            if (findFactory.Any())
                return findFactory.First();
            else throw new NullReferenceException($"Factory {factoryName} dont exist");
        }
    }
}