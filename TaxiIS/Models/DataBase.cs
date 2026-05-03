using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaxiIS.Models
{
    /// <summary>
    /// Класс базы данных. Хранит коллекции заказов, водителей и клиентов в оперативной памяти.
    /// Обеспечивает сохранение данных в JSON-файл и загрузку из файла.
    /// </summary>
    public class DataBase
    {
        /// <summary>
        /// Расширение файла базы данных
        /// </summary>
        public static readonly string FileExtension = ".DataBase";

        private List<Order> _orders;
        private List<Driver> _drivers;
        private List<Client> _clients;

        /// <summary>
        /// Конструктор. Создаёт пустые коллекции заказов, водителей и клиентов.
        /// </summary>
        public DataBase()
        {
            _orders = new List<Order>();
            _drivers = new List<Driver>();
            _clients = new List<Client>();
        }

        /// <summary>
        /// Получить список всех заказов
        /// </summary>
        public List<Order> GetOrders() { return _orders; }

        /// <summary>
        /// Получить список всех водителей
        /// </summary>
        public List<Driver> GetDrivers() { return _drivers; }

        /// <summary>
        /// Получить список всех клиентов
        /// </summary>
        public List<Client> GetClients() { return _clients; }

        /// <summary>
        /// Загружает базу данных из JSON-файла.
        /// Ожидает три строки: заказы, водители, клиенты.
        /// </summary>
        /// <param name="path">Путь к файлу базы данных</param>
        public void Load(string path)
        {
            TextReader reader = null; //инструмент для чтения текстового файла
            try
            {
                reader = new StreamReader(path); //открываем
                string line1 = reader.ReadLine(); //читаем
                string line2 = reader.ReadLine();
                string line3 = reader.ReadLine();

                if (line1 == null || line2 == null || line3 == null)
                    throw new InvalidDataException("Файл базы данных повреждён");

                //превращает JSON-строку обратно в список заказов, если JSON сломан или null, то пустой список
                _orders = JsonSerializer.Deserialize<List<Order>>(line1) ?? new List<Order>();
                _drivers = JsonSerializer.Deserialize<List<Driver>>(line2) ?? new List<Driver>();
                _clients = JsonSerializer.Deserialize<List<Client>>(line3) ?? new List<Client>();
            }
            finally
            {
                reader?.Close(); //если не null закрываем файл
            }
        }

        /// <summary>
        /// Сохраняет базу данных в JSON-файл.
        /// Записывает три строки: заказы, водители, клиенты.
        /// </summary>
        /// <param name="path">Путь к файлу для сохранения</param>
        public void Save(string path)
        {
            TextWriter writer = null; //инструмент для записи
            try
            {
                string ordersJson = JsonSerializer.Serialize(_orders); //превращает список объектов в JSON-строку
                string driversJson = JsonSerializer.Serialize(_drivers);
                string clientsJson = JsonSerializer.Serialize(_clients);

                writer = new StreamWriter(path); //открываем
                writer.WriteLine(ordersJson); //записываем
                writer.WriteLine(driversJson);
                writer.WriteLine(clientsJson);
            }
            finally
            {
                writer?.Close(); //закрываем
            }
        }
    }
}