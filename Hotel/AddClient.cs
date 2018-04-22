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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }


        //перетаскивание формы
        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }
        //выход из приложения
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //сворачивание активного окна
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //добавление жильца
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                string fName, lName, patp, series, number;
                try
                {
                    fName = textBoxFname.Text;
                    lName = textBoxLname.Text;
                    patp = textBoxPatr.Text;
                    series = textBoxSeries.Text;
                    number = textBoxNumber.Text;
                    string query = "INSERT INTO Client VALUES ('" + fName + "','" + lName + "','" + patp + "','" + series + "','" + number + "')";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент добавлен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //возврат в меню пользователя
        private void backButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new AdmMenu(), this);
        }
        //переход к форме редактирования клиента
        private void button1_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new EditClient(), this);
        }
    }
}
