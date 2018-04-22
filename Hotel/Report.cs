using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }


        //перемещение формы
        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }
        //закрытие приложения
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //сворачивание активного окна
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //создание отчета
        private void signInButton_Click(object sender, EventArgs e)
        {
            DateTime dtStart = dateTimePicker1.Value;
            DateTime dtEnd = dateTimePicker2.Value;
            string query =
                "select u.Name as Администратор, c.FirstName + c.SecondName as Клиент, r.Name as Комната,"+
                "o.Begin_Date as Заезд, o.End_Date as Выезд, o.Coast as Стоимость"+
                " from Orders as o"+
                " join [User] as u on o.Id_Admin = u.Id_user"+
                " join Client as c on o.Id_Client = c.Id_Client"+
                " join Rooms as r on o.Id_Rooms = r.Id_rooms"+
                " where o.Begin_Date >= '"+dtStart+"' and o.End_Date <= '"+dtEnd+"'";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    double coast = 0;
                    dataGridViewReport.DataSource = dt;
                    foreach (DataGridViewRow r in dataGridViewReport.Rows)
                    {
                        coast += Convert.ToDouble(r.Cells[5].Value);
                    }
                    label4.Text = coast.ToString();
                }
                catch(Exception ex) {
                    MessageBox.Show("Ошибка базы данных\n"+ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        //возврат в меню пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new DirMenu(), this);
        }
    }
}
