namespace TaxiIS.Models
{
    /// <summary>
    /// Класс, представляющий клиента такси.
    /// Содержит ФИО и контактный телефон.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Контактный телефон клиента
        /// </summary>
        public string Phone { get; set; } = string.Empty;
    }
}