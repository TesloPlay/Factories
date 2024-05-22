using System.Text;
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

            //var tanks = ReadListFromFile<Tank>("TankList");
            //var units = ReadListFromFile<Unit>("UnitList");
            //var factories = ReadListFromFile<Factory>("FactoryList");

            //ConsoleInteraction.WriteListToConsole<Tank>(tanks);

            //ConsoleInteraction.Subscribe();
            //ConsoleInteraction.ReadLine();
            //ConsoleInteraction.Unsubscribe();
            //ConsoleInteraction.ReadLine();

            #region Незавершённый код
            //var tanks = GetTanks();
            //var units = GetUnits();
            //var factories = GetFactories();
            //string filename;

            //Dictionary<int, string> mainMenu = new Dictionary<int, string>
            //{
            //    { 1, "Восстановить изначальные данные" },
            //    { 2, "Считать данные из файлов" },
            //    { 3, "Записать данные в файлы" },
            //    { 4, "Вывести данные на экран" },
            //    { 5, "Добавить новый элемент в файл" },
            //    { 6, "Изменить элемент в файле" },
            //    { 7, "Удалить элемент в файле" },
            //    { 8, "Закончить работу программы" }
            //};
            //Dictionary<int, string> chooseMenu = new Dictionary<int, string>
            //{
            //    { 1, "Заводы" },
            //    { 2, "Установки" },
            //    { 3, "Резервуары" }
            //};

            //while (true)
            //{
            //    ConsoleInteraction.WriteMenuToConsole(mainMenu);
            //    switch (ConsoleInteraction.ReadLine())
            //    {
            //        case "1":
            //            tanks = GetTanks();
            //            units = GetUnits();
            //            factories = GetFactories();
            //            break;
            //        case "2":
            //            try
            //            {
            //                var newTanks = ReadListFromFile<Tank>("TankList.json");
            //                var newUnits = ReadListFromFile<Unit>("UnitList.json");
            //                var newFactories = ReadListFromFile<Factory>("FactoryList.json");
            //                tanks = newTanks;
            //                units = newUnits;
            //                factories = newFactories;
            //                ConsoleInteraction.WriteLine("Данные успешно считаны");
            //            } catch (Exception ex)
            //            {
            //                ConsoleInteraction.WriteLine($"Не удалось считать данные: {ex.Message}");
            //            }
            //            break;
            //        case "3":
            //            try
            //            {
            //                WriteListToFile("TankList.json", tanks);
            //                WriteListToFile("UnitList.json", units);
            //                WriteListToFile("FactoryList.json", factories);
            //                ConsoleInteraction.WriteLine("Данные успешно записаны");
            //            } catch (Exception ex )
            //            {
            //                ConsoleInteraction.WriteLine($"Не удалось записать данные: {ex.Message}");
            //            }
            //            break;
            //        case "4":
            //            ConsoleInteraction.WriteLine("Заводы:");
            //            ConsoleInteraction.WriteListToConsole(factories);
            //            ConsoleInteraction.WriteLine("Установки:");
            //            ConsoleInteraction.WriteListToConsole(units);
            //            ConsoleInteraction.WriteLine("Резервуары:");
            //            ConsoleInteraction.WriteListToConsole(tanks);
            //            break;
            //        case "5":
            //            ConsoleInteraction.WriteLine("Выберите список для работы:");
            //            ConsoleInteraction.WriteMenuToConsole(chooseMenu);
            //            switch (ConsoleInteraction.ReadLine())
            //            {
            //                case "1":

            //                    break;
            //                case "2":
            //                    break;
            //                case "3":
            //                    break;
            //                default:
            //                    break;
            //            }
            //            break;
            //    }
            //}
            #endregion

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
            //    switch (ConsoleInteraction.ReadLine())
            //    {
            //        // Получение имени установки по имени резервуара
            //        case "1":
            //            Console.Clear();
            //            Console.Write("Введите название резервуара: ");
            //            try
            //            {
            //                Console.WriteLine($"Найденая установка: {FindUnit(units, tanks, ConsoleInteraction.ReadLine()).Name}");
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
            //                        Tank tank = FindTankByName(tanks, ConsoleInteraction.ReadLine());
            //                        Console.WriteLine($"Название: {tank.Name}\nОписание: {tank.Description}\nЗагруженность: {tank.Volume}\nМаксимальная загруженность: {tank.MaxVolume}");
            //                        break;
            //                    // Ищем установку
            //                    case "2":
            //                        Console.WriteLine("Введите название установки");
            //                        Unit unit = FindUnitByName(units, ConsoleInteraction.ReadLine());
            //                        Console.WriteLine($"Название: {unit.Name}\nОписание: {unit.Description}");
            //                        break;
            //                    // Ищем завод
            //                    case "3":
            //                        Console.WriteLine("Введите название резервуара");
            //                        Factory factory = FindFactoryByName(factories, ConsoleInteraction.ReadLine());
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
            //        default:
            //            Console.WriteLine("Неверный ввод");
            //            break;

            //    }
            //    Console.ReadLine();
            //}
            #endregion
        }
        public static IEnumerable<Tank> GetTanks()
        {
            List<Tank> list = new List<Tank> {
                new Tank(1, "Резервуар 1", "Надземный - вертикальный", 1500, 2000, 1),
                new Tank(2, "Резервуар 2", "Надземный - горизонтальный", 2500, 3000, 1),
                new Tank(3, "Дополнительный резервуар 24", "Надземный - горизонтальный", 3000, 3000, 2),
                new Tank(4, "Резервуар 35", "Надземный - вертикальный", 3000, 3000, 2),
                new Tank(5, "Резервуар 47", "Подземный - двустенный", 4000, 5000, 2),
                new Tank(6, "Резервуар 256", "Подводный", 500, 500, 3)
            };
            return list.AsEnumerable();
        }
        public static IEnumerable<Unit> GetUnits()
        {
            List<Unit> list = new List<Unit>
            {
                new Unit(1, "ГФУ-2", "Газофракционирующая установка", 1),
                new Unit(2, "АВТ-6", "Атмосферно-вакуумная трубчатка", 1),
                new Unit(3, "АВТ-10", "Атмосферно-вакуумная трубчатка", 2)
            };
            return list.AsEnumerable();
        }
        public static IEnumerable<Factory> GetFactories()
        {
            List<Factory> list = new List<Factory>
            {
                new Factory(1, "НПЗ№1", "Первый нефтеперерабатывающий завод"),
                new Factory(2, "НПЗ№2", "Второй нефтеперерабатывающий завод")
            };
            return list.AsEnumerable();
        }


        public static void AddNewElementToJsonFile<T>(string filename, T element)
        {
            List<T> list = ReadListFromFile<T>(filename).ToList();
            list.Add(element);
            WriteListToFile<T>(filename, list);
        }
        public static void EditElementFromJsonFile<T>(string filename, T element, int id)
        {
            List<T> list = ReadListFromFile<T>(filename).ToList();
            list[id] = element;
            WriteListToFile<T>(filename, list);
        }
        public static void DeleteElementFromJsonFile<T>(string filename, T element)
        {
            List<T> list = ReadListFromFile<T>(filename).ToList();
            list.Remove(element);
            WriteListToFile<T>(filename, list);
        }


        public static void WriteListToFile<T>(string filename, IEnumerable<T> values)
        {
            string serializedList = JsonSerializer.Serialize(values);
            File.WriteAllText(filename, serializedList);
        }
        public static IEnumerable<T> ReadListFromFile<T>(string filename)
        {
            IEnumerable<T>? values = JsonSerializer.Deserialize<IEnumerable<T>>(File.ReadAllText(filename));
            if (values == null)
                throw new ArgumentNullException(nameof(values),$"Cant read file {filename}");
            return values;
        }

        /// <summary>
        /// Поиск установки по названию резервуара
        /// </summary>
        /// <param name="units">коллекция установок</param>
        /// <param name="tanks">коллекция резервуаров</param>
        /// <param name="tankName">название резервуара</param>
        /// <returns>искомая установка</returns>
        public static Unit FindUnit(IEnumerable<Unit> units, IEnumerable<Tank> tanks, string tankName)
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
            else throw new NullReferenceException($"Unit with tank {tankName} dont exist");
        }

        /// <summary>
        /// Поиск завода по установке
        /// </summary>
        /// <param name="factories">коллекция заводов</param>
        /// <param name="unit">установка</param>
        /// <returns>искомый завод</returns>
        public static Factory FindFactory(IEnumerable<Factory> factories, Unit unit)
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
        public static int GetTotalVolume(IEnumerable<Tank> tanks)
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
        public static string GetTankNamesInfo(IEnumerable<Tank> tanks, IEnumerable<Unit> units, IEnumerable<Factory> factories)
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
            tanks.ToList().ForEach(tank => { 
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
        public static Tank FindTankByName(IEnumerable<Tank> tanks, string tankName)
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
        public static Unit FindUnitByName(IEnumerable<Unit> units, string unitName)
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
        public static Factory FindFactoryByName(IEnumerable<Factory> factories, string factoryName)
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