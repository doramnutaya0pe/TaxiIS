using System;
using System.Linq;
using System.Windows.Forms;
using TaxiIS.Models;

namespace TaxiIS
{
    /// <summary>
    /// Форма для управления списком водителей такси.
    /// Позволяет добавлять, редактировать и удалять записи о водителях
    /// (ФИО, марка автомобиля, государственный регистрационный номер).
    /// </summary>
    public partial class DriversForm : Form
    {
        /// <summary>
        /// Ссылка на объект базы данных, содержащий коллекции заказов, водителей и клиентов
        /// </summary>
        private DataBase _data;

        /// <summary>
        /// Последний выбранный водитель в таблице. Используется для редактирования и удаления.
        /// Если ни одна строка не выбрана — равен null.
        /// </summary>
        private Driver _lastDriver;

        /// <summary>
        /// Конструктор формы. Принимает объект базы данных, обновляет таблицу
        /// и блокирует кнопки редактирования/удаления до выбора водителя.
        /// </summary>
        /// <param name="data">Объект базы данных, с которым работает форма</param>
        public DriversForm(DataBase data)
        {
            InitializeComponent();
            _data = data;
            UpdateTable();
            BlockEdit(true);
        }

        /// <summary>
        /// Блокирует или разблокирует кнопки "Редактировать" и "Удалить".
        /// Кнопки активны только когда выбран водитель в таблице.
        /// </summary>
        /// <param name="block">
        /// true — заблокировать кнопки (нет выбранного водителя);
        /// false — разблокировать кнопки (водитель выбран)
        /// </param>
        void BlockEdit(bool block)
        {
            buttonEditDriver.Enabled = !block;
            buttonDeleteDriver.Enabled = !block;
        }

        /// <summary>
        /// Очищает все поля ввода (ФИО, марка авто, госномер)
        /// </summary>
        void ClearFields()
        {
            textBoxDriverName.Text = "";
            textBoxCarModel.Text = "";
            textBoxLicensePlate.Text = "";
        }

        /// <summary>
        /// Обновляет таблицу водителей: очищает и заново заполняет
        /// данными из коллекции _data.GetDrivers(). После обновления очищает поля ввода.
        /// </summary>
        void UpdateTable()
        {
            dataGridViewDrivers.Rows.Clear();
            foreach (Driver driver in _data.GetDrivers())
            {
                dataGridViewDrivers.Rows.Add(driver.FullName, driver.CarModel, driver.LicensePlate);
            }
            ClearFields();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить".
        /// Проверяет заполнение всех полей, проверяет уникальность госномера,
        /// добавляет нового водителя в базу данных и обновляет таблицу.
        /// </summary>
        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            string name = textBoxDriverName.Text.Trim();
            string car = textBoxCarModel.Text.Trim();
            string plate = textBoxLicensePlate.Text.Trim();

            if (name == "" || car == "" || plate == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
                return;
            }

            // Проверка на дубликат госномера (берем водителя и сравниваем его госномер с тем что ввел пользователь
            if (_data.GetDrivers().Any(d => d.LicensePlate == plate))
            {
                MessageBox.Show("Водитель с таким госномером уже существует", "Ошибка");
                return;
            }

            _data.GetDrivers().Add(new Driver //добавляем нового водителя в общий список
            {
                FullName = name,
                CarModel = car,
                LicensePlate = plate
            });

            UpdateTable();
        }

        /// <summary>
        /// Обработчик выбора строки в таблице водителей.
        /// Если строка не выбрана — очищает поля и блокирует кнопки редактирования/удаления.
        /// Если строка выбрана — заполняет поля ввода данными водителя
        /// и разблокирует кнопки "Редактировать" и "Удалить".
        /// </summary>
        private void dataGridViewDrivers_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.CurrentRow == null)
            {
                _lastDriver = null;
                BlockEdit(true);
                ClearFields();
                return;
            }

            BlockEdit(false);

            string name = Convert.ToString(dataGridViewDrivers.CurrentRow.Cells[0].Value);
            string car = Convert.ToString(dataGridViewDrivers.CurrentRow.Cells[1].Value);
            string plate = Convert.ToString(dataGridViewDrivers.CurrentRow.Cells[2].Value);

            textBoxDriverName.Text = name;
            textBoxCarModel.Text = car;
            textBoxLicensePlate.Text = plate;

            //находим объект водителя в списке и сохраняем в _lastDriver, первое удовлетворение условию
            _lastDriver = _data.GetDrivers().FirstOrDefault(d =>
                d.FullName == name && d.CarModel == car && d.LicensePlate == plate);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Редактировать".
        /// Проверяет заполнение полей и уникальность госномера (исключая текущего водителя).
        /// Удаляет старую запись, добавляет обновлённую и обновляет таблицу.
        /// </summary>
        private void buttonEditDriver_Click(object sender, EventArgs e)
        {
            if (_lastDriver == null) return;

            string name = textBoxDriverName.Text.Trim();
            string car = textBoxCarModel.Text.Trim();
            string plate = textBoxLicensePlate.Text.Trim();

            if (name == "" || car == "" || plate == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
                return;
            }

            // Проверка на дубликат госномера (исключая текущего водителя)
            if (_data.GetDrivers().Any(d => d.LicensePlate == plate && d != _lastDriver))
            {
                MessageBox.Show("Водитель с таким госномером уже существует", "Ошибка");
                return;
            }

            _data.GetDrivers().Remove(_lastDriver); //удаляем старое
            _data.GetDrivers().Add(new Driver //добавляем новое
            {
                FullName = name,
                CarModel = car,
                LicensePlate = plate
            });

            _lastDriver = null;
            UpdateTable();
            BlockEdit(true);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить".
        /// Удаляет выбранного водителя из базы данных и обновляет таблицу.
        /// После удаления поля ввода очищаются, кнопки блокируются.
        /// </summary>
        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            if (_lastDriver == null) return;

            _data.GetDrivers().Remove(_lastDriver);
            _lastDriver = null;
            UpdateTable();
            BlockEdit(true);
        }        
    }
}