using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class EventForm : Form
    {
        //create a connectionstring
        String connString = "server=localhost; user id=root; database=db_calendar; sslmode=none";
        //I already created a database using xampp

        public EventForm()
        {
            InitializeComponent();
            this.Load += EventForm_Load;
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            // Давайте вызовем статические переменные, которые мы объявляем
            txdate.Text = Form1.static_month + "-" + UserControlDays.static_day + "-" + Form1.static_year;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date, event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Сохранено");
            cmd.Dispose();
            conn.Close();
        }
    }
}
