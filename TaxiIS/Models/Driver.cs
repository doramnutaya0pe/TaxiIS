namespace TaxiIS.Models
{
    /// <summary>
    /// Класс, представляющий водителя такси.
    /// Содержит ФИО, марку автомобиля и государственный регистрационный номер.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// ФИО водителя
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public string CarModel { get; set; } = string.Empty;

        /// <summary>
        /// Государственный регистрационный номер автомобиля
        /// </summary>
        public string LicensePlate { get; set; } = string.Empty;
    }
}