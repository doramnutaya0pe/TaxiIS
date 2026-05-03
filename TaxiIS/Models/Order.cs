namespace TaxiIS.Models
{
    /// <summary>
    /// Класс, представляющий заказ такси.
    /// Содержит адреса подачи и назначения, дату/время, стоимость, данные водителя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Адрес подачи такси
        /// </summary>
        public string PickupAddress { get; set; } = string.Empty;

        /// <summary>
        /// Адрес назначения
        /// </summary>
        public string DestinationAddress { get; set; } = string.Empty;

        /// <summary>
        /// Дата и время заказа
        /// </summary>
        public string OrderDateTime { get; set; } = string.Empty;

        /// <summary>
        /// Стоимость поездки
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// ФИО водителя, выполняющего заказ
        /// </summary>
        public string DriverFullName { get; set; } = string.Empty;

        /// <summary>
        /// Государственный номер автомобиля
        /// </summary>
        public string LicensePlate { get; set; } = string.Empty;
    }
}