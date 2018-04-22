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
    public partial class RegClient : Form
    {
        public RegClient()
        {
            InitializeComponent();
        }
        //расчет суммы к оплате
        private void GetCoast() {
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;
            TimeSpan days = to - from;
            double price = roomDataSet.Rooms.Where(i => i.Id_rooms == Convert.ToInt32(comboBoxRoom.SelectedValue))
                                      .Select(i => i.Price).SingleOrDefault();
            if (days.Days == 0)
                textBoxCoast.Text = (price).ToString();
            else
                textBoxCoast.Text = (price * days.Days).ToString();
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
        //загрузка данных о клиентах и комнатах
        private void RegClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.roomDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.clientDataSet.Client);

        }
        //возврат в меню пользователя
        private void buttonBack_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new AdmMenu(), this);
        }
        //регистрация постояльца
        private void signInButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                try {
                    int client = Convert.ToInt32(comboBoxClient.SelectedValue);
                    int room = Convert.ToInt32(comboBoxRoom.SelectedValue);
                    DateTime from = dateTimePickerFrom.Value;
                    DateTime to = dateTimePickerTo.Value;
                    double coast = Convert.ToDouble(textBoxCoast.Text);
                    int admId = Properties.Settings.Default.id;
                    string query = "INSERT INTO Orders VALUES("+admId+","+client+","+room+",'"+from+"','"+to+"',"+coast+")";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    string queryUpd = "UPDATE Rooms SET Is_busy = 1 WHERE Id_rooms=" + room;
                    MessageBox.Show("Регистрация постояльца прошла успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //расчет суммы при изменении комнаты
        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCoast();
            bool busy = roomDataSet.Rooms.Where(i => i.Id_rooms == Convert.ToInt32(comboBoxRoom.SelectedValue))
                .Select(r => r.Is_busy).SingleOrDefault();
            if (busy)
            {
                MessageBox.Show("Комната занята!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                signInButton.Enabled = false;
            }
        }
        //расчет суммы при изменении даты въезда
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            GetCoast();
        }
        //расчет суммы при изменении даты выезда
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            GetCoast();
        }
    }
}
