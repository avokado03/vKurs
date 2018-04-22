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
    public partial class EditClient : Form
    {
        public EditClient()
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
        //загрузка информации о клиентах
        private void EditClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientPasDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter1.Fill(this.clientPasDataSet.Client);

        }
        //выбор клиента из списка
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxEdit.SelectedValue);
            var client = clientPasDataSet.Client.Where(i => i.Id_Client == id)
                .Select(c => new { c.FirstName, c.SecondName, c.Patronymic, c.PassportSeries, c.PassportNumber }).ToList().SingleOrDefault();
            textBoxFname.Text = Convert.ToString(client.FirstName);
            textBoxLname.Text = Convert.ToString(client.SecondName);
            textBoxPatr.Text = Convert.ToString(client.Patronymic);
            textBoxSeries.Text = Convert.ToString(client.PassportSeries);
            textBoxNumber.Text = Convert.ToString(client.PassportNumber);
        }
        //возврат к форме добавления пользователя
        private void backButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new AddClient(), this);
        }
        //редактирование клиента
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                string fName, lName, patp, series, number;
                try {
                    fName = textBoxFname.Text;
                    lName = textBoxLname.Text;
                    patp = textBoxPatr.Text;
                    series = textBoxSeries.Text;
                    number = textBoxNumber.Text;
                    string query = "UPDATE Client SET FirstName='" + fName + "', SecondName='" + lName 
                        + "', Patronymic='" + patp + "', PassportSeries='" + series + "', PassportNumber='" + number + "'"
                        +" WHERE Id_Client="+ Convert.ToInt32(comboBoxEdit.SelectedValue);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о клиенте отредактирована!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}