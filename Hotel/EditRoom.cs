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
    public partial class EditRoom : Form
    {
        public EditRoom()
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
        //загрузка данных о комнате
        private void EditRoom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.roomDataSet.Rooms);

        }
        //выбор комнаты
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = roomDataSet.Rooms.Where(i => i.Id_rooms == Convert.ToInt32(comboBox1.SelectedValue))
                .Select(r => new {r.Name,r.Comment,r.Price }).ToList().SingleOrDefault();
            textBoxName.Text = room.Name;
            textBoxComment.Text = room.Comment;
            textBoxPrice.Text = (room.Price).ToString();
        }
        //редактирование комнаты
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string name, comment;
                double price;
                try
                {
                    name = textBoxName.Text;
                    comment = textBoxComment.Text;
                    price = Convert.ToDouble(textBoxPrice.Text);
                    string query = "UPDATE Rooms SET Name = '" + name + "', Comment='" + comment + "',Price=" + price
                        + " WHERE Id_rooms = " + Convert.ToInt32(comboBox1.SelectedValue);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Комната отредактирована", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //возврат к форме добавления комнаты
        private void backButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new AddRoom(), this);
        }
    }
}
