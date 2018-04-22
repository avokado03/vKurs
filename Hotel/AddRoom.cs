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
    public partial class AddRoom : Form
    {
        public AddRoom()
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
        //добавить номер
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                string name, comment;
                double price;
                try {
                    name = textBoxName.Text;
                    comment = textBoxComment.Text;
                    price = Convert.ToDouble(textBoxPrice.Text);
                    string query = "INSERT INTO Rooms VALUES ('"+name+"', 0, '"+comment+"'," + price+")";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Комната добавлена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //переход к форме редактирования комнаты
        private void button1_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new EditRoom(), this);
        }
    }
}
