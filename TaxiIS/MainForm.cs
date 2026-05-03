using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TaxiIS.Models;

namespace TaxiIS
{
    /// <summary>
    /// Главная форма приложения «ИС Такси».
    /// Предоставляет интерфейс для управления заказами и клиентами:
    /// добавление, редактирование, удаление, поиск, фильтрация,
    /// экспорт в PDF, сохранение и загрузка базы данных.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект базы данных, содержащий коллекции заказов, водителей и клиентов
        /// </summary>
        private DataBase _data;

        /// <summary>
        /// Последний выбранный заказ в таблице. Используется для редактирования и удаления.
        /// </summary>
        private Order _lastOrder;

        /// <summary>
        /// Последний выбранный клиент в таблице. Используется для редактирования и удаления.
        /// </summary>
        private Client _lastClient;

        /// <summary>
        /// Конструктор главной формы.
        /// Инициализирует компоненты, блокирует элементы управления до создания/открытия БД,
        /// настраивает диалоги открытия и сохранения файлов.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BlockAll(true);
            labelSearchCount.Text = "";
            labelSearchCountClients.Text = "";

            // Настройка диалогов открытия и сохранения файлов
            openFileDialog1.Filter = "База данных (*" + DataBase.FileExtension + ")|*" + DataBase.FileExtension;
            openFileDialog1.DefaultExt = DataBase.FileExtension;
            saveFileDialog1.Filter = "База данных (*" + DataBase.FileExtension + ")|*" + DataBase.FileExtension;
            saveFileDialog1.DefaultExt = DataBase.FileExtension;
        }

        /// <summary>
        /// Блокирует или разблокирует основные элементы управления при отсутствии открытой БД.
        /// При block=true: меню создания/открытия активно, остальное заблокировано.
        /// При block=false: меню создания/открытия заблокировано, остальное активно.
        /// </summary>
        /// <param name="block">true — нет открытой БД, false — БД открыта</param>
        void BlockAll(bool block)
        {
            tabControl1.Enabled = !block;
            createDBToolStripMenuItem.Enabled = block;
            openDBToolStripMenuItem.Enabled = block;
            deleteDBToolStripMenuItem.Enabled = !block;
            saveDBToolStripMenuItem.Enabled = !block;
            driversToolStripMenuItem.Enabled = !block;
        }

        /// <summary>
        /// Блокирует или разблокирует поля редактирования заказа и кнопки "Редактировать"/"Удалить".
        /// Активны только когда выбран заказ в таблице.
        /// </summary>
        /// <param name="block">true — нет выбранного заказа, false — заказ выбран</param>
        void BlockEditOrders(bool block)
        {
            textBoxEditPickup.Enabled = !block;
            textBoxEditDestination.Enabled = !block;
            textBoxEditDateTime.Enabled = !block;
            numericUpDownEditPrice.Enabled = !block;
            comboBoxEditDriver.Enabled = !block;
            buttonEdit.Enabled = !block;
            buttonDelete.Enabled = !block;
        }

        /// <summary>
        /// Обновляет таблицу заказов: очищает и заполняет данными из коллекции _data.GetOrders().
        /// Очищает поля поиска и фильтрации заказов.
        /// </summary>
        void UpdateOrdersTable()
        {
            dataGridViewOrders.Rows.Clear();
            foreach (Order order in _data.GetOrders())
            {
                dataGridViewOrders.Rows.Add(
                    order.PickupAddress,
                    order.DestinationAddress,
                    order.OrderDateTime,
                    order.Price,
                    order.DriverFullName,
                    order.LicensePlate
                );
            }
            textBoxSearch.Text = "";
            textBoxFilter.Text = "";
            labelSearchCount.Text = "";
        }

        /// <summary>
        /// Обновляет таблицу клиентов: очищает и заполняет данными из коллекции _data.GetClients().
        /// Очищает поля поиска и фильтрации клиентов.
        /// </summary>
        void UpdateClientsTable()
        {
            dataGridViewClients.Rows.Clear();
            foreach (Client client in _data.GetClients())
            {
                dataGridViewClients.Rows.Add(client.FullName, client.Phone);
            }
            textBoxSearchClients.Text = "";
            textBoxFilterClients.Text = "";
            labelSearchCountClients.Text = "";
        }

        /// <summary>
        /// Обновляет обе таблицы: заказы и клиенты.
        /// </summary>
        void UpdateAllTables()
        {
            UpdateOrdersTable();
            UpdateClientsTable();
        }

        /// <summary>
        /// Заполняет выпадающие списки водителей (для добавления и редактирования заказа)
        /// актуальными данными из базы. Формат: "ФИО (Госномер)".
        /// </summary>
        void UpdateDriverComboBoxes()
        {
            comboBoxAddDriver.Items.Clear();
            comboBoxEditDriver.Items.Clear();
            foreach (Driver driver in _data.GetDrivers())
            {
                string displayText = driver.FullName + " (" + driver.LicensePlate + ")";
                comboBoxAddDriver.Items.Add(displayText);
                comboBoxEditDriver.Items.Add(displayText);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить" для заказа.
        /// Проверяет заполнение всех полей, извлекает данные о водителе из выпадающего списка,
        /// добавляет новый заказ в базу данных и обновляет таблицу.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_data == null) return;

            string pickup = textBoxAddPickup.Text.Trim();
            string destination = textBoxAddDestination.Text.Trim();
            string dateTime = textBoxAddDateTime.Text.Trim();
            decimal price = numericUpDownAddPrice.Value;

            if (pickup == "" || destination == "" || dateTime == "" || price <= 0)
            {
                MessageBox.Show("Все поля должны быть заполнены, стоимость больше 0", "Ошибка");
                return;
            }

            if (comboBoxAddDriver.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите водителя", "Ошибка");
                return;
            }

            // Извлечение ФИО и госномера из строки вида "Иванов (А123ВС)"
            string selectedDriverText = comboBoxAddDriver.SelectedItem.ToString();
            string driverName = selectedDriverText.Split('(')[0].Trim();
            string licensePlate = selectedDriverText.Split('(')[1].Replace(")", "").Trim();

            _data.GetOrders().Add(new Order
            {
                PickupAddress = pickup,
                DestinationAddress = destination,
                OrderDateTime = dateTime,
                Price = price,
                DriverFullName = driverName,
                LicensePlate = licensePlate
            });

            UpdateOrdersTable();

            // Очистка полей добавления
            textBoxAddPickup.Text = "";
            textBoxAddDestination.Text = "";
            textBoxAddDateTime.Text = "";
            numericUpDownAddPrice.Value = 0;
            comboBoxAddDriver.SelectedIndex = -1;
        }

        /// <summary>
        /// Обработчик выбора строки в таблице заказов.
        /// Если строка не выбрана — очищает поля редактирования и блокирует их.
        /// Если строка выбрана — заполняет поля редактирования данными заказа
        /// и разблокирует кнопки "Редактировать" и "Удалить".
        /// </summary>
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                _lastOrder = null;
                BlockEditOrders(true);
                return;
            }

            BlockEditOrders(false);

            string pickup = Convert.ToString(dataGridViewOrders.CurrentRow.Cells[0].Value);
            string destination = Convert.ToString(dataGridViewOrders.CurrentRow.Cells[1].Value);
            string dateTime = Convert.ToString(dataGridViewOrders.CurrentRow.Cells[2].Value);
            decimal price = Convert.ToDecimal(dataGridViewOrders.CurrentRow.Cells[3].Value);
            string driverName = Convert.ToString(dataGridViewOrders.CurrentRow.Cells[4].Value);
            string plate = Convert.ToString(dataGridViewOrders.CurrentRow.Cells[5].Value);

            textBoxEditPickup.Text = pickup;
            textBoxEditDestination.Text = destination;
            textBoxEditDateTime.Text = dateTime;
            numericUpDownEditPrice.Value = price;

            // Выбор водителя в комбобоксе
            string driverText = driverName + " (" + plate + ")";
            comboBoxEditDriver.SelectedIndex = comboBoxEditDriver.Items.IndexOf(driverText);

            _lastOrder = _data.GetOrders().FirstOrDefault(o =>
                o.PickupAddress == pickup &&
                o.DestinationAddress == destination &&
                o.OrderDateTime == dateTime &&
                o.Price == price &&
                o.DriverFullName == driverName &&
                o.LicensePlate == plate);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Редактировать" для заказа.
        /// Проверяет заполнение полей, извлекает данные водителя,
        /// удаляет старую запись, добавляет обновлённую и обновляет таблицу.
        /// </summary>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_lastOrder == null) return;

            string pickup = textBoxEditPickup.Text.Trim();
            string destination = textBoxEditDestination.Text.Trim();
            string dateTime = textBoxEditDateTime.Text.Trim();
            decimal price = numericUpDownEditPrice.Value;

            if (pickup == "" || destination == "" || dateTime == "" || price <= 0)
            {
                MessageBox.Show("Все поля должны быть заполнены, стоимость больше 0", "Ошибка");
                return;
            }

            if (comboBoxEditDriver.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите водителя", "Ошибка");
                return;
            }

            string selectedDriverText = comboBoxEditDriver.SelectedItem.ToString();
            string driverName = selectedDriverText.Split('(')[0].Trim();
            string licensePlate = selectedDriverText.Split('(')[1].Replace(")", "").Trim();

            _data.GetOrders().Remove(_lastOrder);
            _data.GetOrders().Add(new Order
            {
                PickupAddress = pickup,
                DestinationAddress = destination,
                OrderDateTime = dateTime,
                Price = price,
                DriverFullName = driverName,
                LicensePlate = licensePlate
            });

            _lastOrder = null;
            UpdateOrdersTable();
            BlockEditOrders(true);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить" для заказа.
        /// Удаляет выбранный заказ из базы данных и обновляет таблицу.
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_lastOrder == null) return;
            _data.GetOrders().Remove(_lastOrder);
            _lastOrder = null;
            UpdateOrdersTable();
            BlockEditOrders(true);
        }

        /// <summary>
        /// Поиск заказов по выбранному критерию.
        /// Подсвечивает жёлтым цветом строки, содержащие искомый текст.
        /// Выводит количество найденных совпадений.
        /// </summary>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            string searchText = textBoxSearch.Text.ToLower();
            string criterion = comboBoxFilter.Text;

            // Сброс цвета всех строк на белый
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                labelSearchCount.Text = "";
                return;
            }

            int count = 0;
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                bool match = false;
                switch (criterion)
                {
                    case "Адрес подачи":
                        match = Convert.ToString(row.Cells[0].Value).ToLower().Contains(searchText);
                        break;
                    case "Адрес назначения":
                        match = Convert.ToString(row.Cells[1].Value).ToLower().Contains(searchText);
                        break;
                    case "Дата и время":
                        match = Convert.ToString(row.Cells[2].Value).ToLower().Contains(searchText);
                        break;
                    case "Стоимость":
                        match = Convert.ToString(row.Cells[3].Value).Contains(searchText);
                        break;
                    case "Водитель":
                        match = Convert.ToString(row.Cells[4].Value).ToLower().Contains(searchText);
                        break;
                    case "Госномер":
                        match = Convert.ToString(row.Cells[5].Value).ToLower().Contains(searchText);
                        break;
                }
                if (match)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                    count++;
                }
            }
            labelSearchCount.Text = "Найдено: " + count;
        }

        /// <summary>
        /// Фильтрация заказов по выбранному критерию.
        /// Отображает в таблице только записи, удовлетворяющие условию фильтрации.
        /// Выводит количество отфильтрованных записей от общего числа.
        /// </summary>
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            string filterText = textBoxFilter.Text.ToLower();
            string criterion = comboBoxFilter.Text;

            dataGridViewOrders.Rows.Clear();

            if (string.IsNullOrEmpty(filterText))
            {
                UpdateOrdersTable();
                labelSearchCount.Text = "";
                return;
            }

            int count = 0;
            foreach (Order order in _data.GetOrders())
            {
                bool match = false;
                switch (criterion)
                {
                    case "Адрес подачи":
                        match = order.PickupAddress.ToLower().Contains(filterText);
                        break;
                    case "Адрес назначения":
                        match = order.DestinationAddress.ToLower().Contains(filterText);
                        break;
                    case "Дата и время":
                        match = order.OrderDateTime.ToLower().Contains(filterText);
                        break;
                    case "Стоимость":
                        match = order.Price.ToString().Contains(filterText);
                        break;
                    case "Водитель":
                        match = order.DriverFullName.ToLower().Contains(filterText);
                        break;
                    case "Госномер":
                        match = order.LicensePlate.ToLower().Contains(filterText);
                        break;
                }
                if (match)
                {
                    dataGridViewOrders.Rows.Add(
                        order.PickupAddress,
                        order.DestinationAddress,
                        order.OrderDateTime,
                        order.Price,
                        order.DriverFullName,
                        order.LicensePlate
                    );
                    count++;
                }
            }
            labelSearchCount.Text = "Отфильтровано: " + count + " из " + _data.GetOrders().Count;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить клиента".
        /// Проверяет заполнение полей и уникальность телефона,
        /// добавляет нового клиента в базу данных и обновляет таблицу.
        /// </summary>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (_data == null) return;

            string name = textBoxClientName.Text.Trim();
            string phone = textBoxClientPhone.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
                return;
            }

            if (_data.GetClients().Any(c => c.Phone == phone))
            {
                MessageBox.Show("Клиент с таким телефоном уже существует", "Ошибка");
                return;
            }

            _data.GetClients().Add(new Client
            {
                FullName = name,
                Phone = phone
            });

            UpdateClientsTable();
            textBoxClientName.Text = "";
            textBoxClientPhone.Text = "";
        }

        /// <summary>
        /// Обработчик выбора строки в таблице клиентов.
        /// Заполняет поля ввода данными выбранного клиента.
        /// </summary>
        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null)
            {
                _lastClient = null;
                textBoxClientName.Text = "";
                textBoxClientPhone.Text = "";
                return;
            }

            string name = Convert.ToString(dataGridViewClients.CurrentRow.Cells[0].Value);
            string phone = Convert.ToString(dataGridViewClients.CurrentRow.Cells[1].Value);

            textBoxClientName.Text = name;
            textBoxClientPhone.Text = phone;

            _lastClient = _data.GetClients().FirstOrDefault(c =>
                c.FullName == name && c.Phone == phone);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Редактировать" для клиента.
        /// Проверяет заполнение полей и уникальность телефона (исключая текущего клиента).
        /// Удаляет старую запись, добавляет обновлённую и обновляет таблицу.
        /// </summary>
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (_lastClient == null) return;

            string name = textBoxClientName.Text.Trim();
            string phone = textBoxClientPhone.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
                return;
            }

            if (_data.GetClients().Any(c => c.Phone == phone && c != _lastClient))
            {
                MessageBox.Show("Клиент с таким телефоном уже существует", "Ошибка");
                return;
            }

            _data.GetClients().Remove(_lastClient);
            _data.GetClients().Add(new Client
            {
                FullName = name,
                Phone = phone
            });

            _lastClient = null;
            UpdateClientsTable();
            textBoxClientName.Text = "";
            textBoxClientPhone.Text = "";
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить" для клиента.
        /// Удаляет выбранного клиента из базы данных и обновляет таблицу.
        /// </summary>
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (_lastClient == null) return;
            _data.GetClients().Remove(_lastClient);
            _lastClient = null;
            UpdateClientsTable();
            textBoxClientName.Text = "";
            textBoxClientPhone.Text = "";
        }

        /// <summary>
        /// Поиск клиентов по выбранному критерию.
        /// Подсвечивает жёлтым цветом строки, содержащие искомый текст.
        /// Выводит количество найденных совпадений.
        /// </summary>
        private void textBoxSearchClients_TextChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            string searchText = textBoxSearchClients.Text.ToLower();
            string criterion = comboBoxFilterClients.Text;

            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                labelSearchCountClients.Text = "";
                return;
            }

            int count = 0;
            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                bool match = false;
                switch (criterion)
                {
                    case "ФИО":
                        match = Convert.ToString(row.Cells[0].Value).ToLower().Contains(searchText);
                        break;
                    case "Телефон":
                        match = Convert.ToString(row.Cells[1].Value).ToLower().Contains(searchText);
                        break;
                }
                if (match)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                    count++;
                }
            }
            labelSearchCountClients.Text = "Найдено: " + count;
        }

        /// <summary>
        /// Фильтрация клиентов по выбранному критерию.
        /// Отображает в таблице только записи, удовлетворяющие условию фильтрации.
        /// Выводит количество отфильтрованных записей от общего числа.
        /// </summary>
        private void textBoxFilterClients_TextChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            string filterText = textBoxFilterClients.Text.ToLower();
            string criterion = comboBoxFilterClients.Text;

            dataGridViewClients.Rows.Clear();

            if (string.IsNullOrEmpty(filterText))
            {
                UpdateClientsTable();
                labelSearchCountClients.Text = "";
                return;
            }

            int count = 0;
            foreach (Client client in _data.GetClients())
            {
                bool match = false;
                switch (criterion)
                {
                    case "ФИО":
                        match = client.FullName.ToLower().Contains(filterText);
                        break;
                    case "Телефон":
                        match = client.Phone.ToLower().Contains(filterText);
                        break;
                }
                if (match)
                {
                    dataGridViewClients.Rows.Add(client.FullName, client.Phone);
                    count++;
                }
            }
            labelSearchCountClients.Text = "Отфильтровано: " + count + " из " + _data.GetClients().Count;
        }

        /// <summary>
        /// Обработчик пункта меню "Создать базу данных".
        /// Создаёт новую пустую базу данных, разблокирует элементы управления,
        /// обновляет таблицы и выпадающие списки водителей.
        /// </summary>
        private void createDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data = new DataBase();
            BlockAll(false);
            UpdateAllTables();
            UpdateDriverComboBoxes();
            MessageBox.Show("Новая база данных создана", "Информация");
        }

        /// <summary>
        /// Обработчик пункта меню "Открыть базу данных".
        /// Открывает диалог выбора файла, загружает данные из JSON-файла,
        /// разблокирует интерфейс и обновляет все таблицы.
        /// </summary>
        private void openDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _data = new DataBase();
            try
            {
                _data.Load(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось открыть файл. Возможно, он повреждён.", "Ошибка");
                return;
            }

            BlockAll(false);
            UpdateAllTables();
            UpdateDriverComboBoxes();
        }

        /// <summary>
        /// Обработчик пункта меню "Сохранить базу данных".
        /// Открывает диалог сохранения файла и сохраняет текущие данные в JSON-формате.
        /// </summary>
        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null)
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка");
                return;
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            _data.Save(saveFileDialog1.FileName);
            MessageBox.Show("База данных сохранена", "Информация");
        }

        /// <summary>
        /// Обработчик пункта меню "Удалить базу данных".
        /// Удаляет текущую базу данных из оперативной памяти,
        /// очищает таблицы и блокирует элементы управления.
        /// </summary>
        private void deleteDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null) return;
            _data = null;
            dataGridViewOrders.Rows.Clear();
            dataGridViewClients.Rows.Clear();
            BlockAll(true);
            MessageBox.Show("База данных удалена из памяти", "Информация");
        }

        /// <summary>
        /// Обработчик пункта меню "Экспорт в PDF".
        /// Формирует PDF-отчёт со списком всех заказов в виде таблицы.
        /// Отчёт содержит: заголовок, дату формирования, шапку таблицы и данные.
        /// </summary>
        private void exportPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null || _data.GetOrders().Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта", "Ошибка");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF файлы (*.pdf)|*.pdf",
                FileName = "Отчёт_Такси_" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(
                        iTextSharp.text.PageSize.A4, 10, 10, 20, 20);
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Шрифт с поддержкой русского языка
                    string fontPath = @"C:\Windows\Fonts\Arial.ttf";
                    iTextSharp.text.pdf.BaseFont baseFont = iTextSharp.text.pdf.BaseFont.CreateFont(
                        fontPath, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);

                    // Заголовок
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Отчёт по заказам такси", titleFont);
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(title);

                    // Дата формирования
                    iTextSharp.text.Font dateFont = new iTextSharp.text.Font(baseFont, 11);
                    iTextSharp.text.Paragraph datePara = new iTextSharp.text.Paragraph(
                        "Дата формирования: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"), dateFont);
                    datePara.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(datePara);

                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // Таблица
                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(6);
                    table.WidthPercentage = 100;
                    float[] widths = new float[] { 2f, 2f, 2f, 1f, 2f, 1.5f };
                    table.SetWidths(widths);

                    // Заголовки столбцов
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
                    string[] headers = { "Адрес подачи", "Адрес назначения", "Дата и время", "Стоимость", "Водитель", "Госномер" };

                    foreach (string header in headers)
                    {
                        iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase(header, headerFont));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200);
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // Данные заказов
                    iTextSharp.text.Font cellFont = new iTextSharp.text.Font(baseFont, 9);
                    foreach (Order order in _data.GetOrders())
                    {
                        table.AddCell(new iTextSharp.text.Phrase(order.PickupAddress, cellFont));
                        table.AddCell(new iTextSharp.text.Phrase(order.DestinationAddress, cellFont));
                        table.AddCell(new iTextSharp.text.Phrase(order.OrderDateTime, cellFont));
                        table.AddCell(new iTextSharp.text.Phrase(order.Price.ToString("F2") + " руб.", cellFont));
                        table.AddCell(new iTextSharp.text.Phrase(order.DriverFullName, cellFont));
                        table.AddCell(new iTextSharp.text.Phrase(order.LicensePlate, cellFont));
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("PDF-отчёт сохранён:\n" + saveDialog.FileName, "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании PDF:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик пункта меню "Выход". Завершает работу приложения.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработчик пункта меню "Водители".
        /// Открывает форму управления списком водителей.
        /// После закрытия формы обновляет выпадающие списки водителей в заказах.
        /// </summary>
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null)
            {
                MessageBox.Show("Сначала создайте или откройте базу данных", "Ошибка");
                return;
            }

            DriversForm driversForm = new DriversForm(_data);
            driversForm.ShowDialog();
            UpdateDriverComboBoxes();
        }
    }
}