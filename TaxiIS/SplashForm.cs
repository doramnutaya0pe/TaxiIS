using System;
using System.Windows.Forms;

namespace TaxiIS
{
    /// <summary>
    /// Форма-заставка, отображаемая при запуске приложения.
    /// Показывает информацию об авторе и теме проекта.
    /// Через 3 секунды автоматически открывает главную форму.
    /// </summary>
    public partial class SplashForm : Form
    {
        /// <summary>
        /// Конструктор формы-заставки
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик тика таймера. Закрывает заставку и открывает главную форму.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //останавливаем
            Hide(); //скрываем

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog(); //отображаем

            Close(); //закрываем
        }
    }
}