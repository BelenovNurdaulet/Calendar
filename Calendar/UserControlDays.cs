using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//UserControlDays - пользовательский элемент управления для отображения дней месяца.

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=localhost; user id=root; database=db_calendar; sslmode=none";
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)//логика для отображения номера дня
        { 
            lbdays.Text = numday+"";
            displayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        { //Обработчик события нажания События
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }
        private void displayEvent() //Метод для отображения событий
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();

            string sql = "SELECT * FROM tbl_calendar where date = ?";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("date", Form1.static_month + "-" + lbdays.Text + "-" + Form1.static_year);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // Установить текст элемента управления события в значение события
                // из базы данных
                lblevent.Text = reader["event"].ToString();
            }

            reader.Dispose();
            cmd.Dispose();

            conn.Close();
        }

        private void lbevent_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
