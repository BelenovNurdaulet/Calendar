using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EventForm - класс формы для добавления событий в календарь.
namespace Calendar
{
    
    public partial class Form1 : Form //Определяет класс Form1, который является частичным классом формы Form
    {
        //Cтрока подключения к базе данных MySQL:
        String connString = "server=localhost; user id=root; database=db_calendar; sslmode=none";
        int month, year; //переменные для хранения текущего месяца и года.

        public static int static_month, static_year; //статические переменные для хранения месяца и года

        //Обработчик события загрузки формы:
        private void Form1_Load(object sender, EventArgs e)//Метод, вызываемый при загрузке формы.
        {
            displaDays(); //Вызывает метод для отображения дней месяца.
            CheckEventsForToday();
        }
        private void CheckEventsForToday()
        {
            //Объект возвращает текущую дату
            DateTime today = DateTime.Today;

            //Подключение к базе данных:
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            //Подготовка SQL-запроса:
            string sql = "SELECT event FROM tbl_calendar WHERE date = ?";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("date", today.ToString("MM-dd-yyyy"));
            //Выполнение запроса и получение результата:
            object result = cmd.ExecuteScalar();

            //Проверка наличия событий и вывод уведомления:
            if (result != null)
            {
                // Если есть событие на сегодня, отобразите уведомление
                MessageBox.Show("Cобытие на сегодня\n" +  result.ToString());
            }
            //Закрытие соединения и освобождение ресурсов:
            cmd.Dispose();
            conn.Close();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + DateTime.Now.Year;

            static_month= month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1); // Получаем первый день месяца
            int days = DateTime.DaysInMonth(year, month);           //
            
            //Получаем количество дней в месяце
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));  // Получаем день недели первого дня

            // Создаем пустой пользовательский элемент управления (код не показан)
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank(); //пользовательский элемент управления для отображения дней месяца.
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {

                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }
     
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }
        //Обработчик события для кнопки "Вперед":
        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1); // Получаем первый день месяца
            int days = DateTime.DaysInMonth(year, month);           // Получаем количество дней в месяце
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));  // Получаем день недели первого дня

            // Создаем пустой пользовательский элемент управления (код не показан)
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {

                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }
        //Обработчик события для кнопки "Назад":
        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1); // Получаем первый день месяца
            int days = DateTime.DaysInMonth(year, month);           // Получаем количество дней в месяце
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));  // Получаем день недели первого дня

            // Создаем пустой пользовательский элемент управления (код не показан)
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {

                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
