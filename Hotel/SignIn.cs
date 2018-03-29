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
using System.Data.Sql;

namespace Hotel
{
    public partial class SignIn : Form
    {
        public SignIn()
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
        //возврат к главной форме
        private void buttonBack_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new MainForm(), this);
        }
        //вход в систему
        private void signInButton_Click(object sender, EventArgs e)
        {
            string login, pass, query;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                try
                {
                    login = textBoxLogin.Text;
                    pass = textBoxPass.Text;
                    query = "SELECT * FROM [User] WHERE Login collate Cyrillic_General_CS_AS = '" + login + "' AND Pass collate Cyrillic_General_CS_AS = '" + pass + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) {
                        reader.Read();
                        Properties.Settings.Default.id = reader.GetInt32(0);
                        Properties.Settings.Default.login = reader.GetString(1);
                        Properties.Settings.Default.role = reader.GetString(4);
                    }
                    string role = Properties.Settings.Default.role;
                    switch (role) {
                        case "director":
                            BehaviorLib.GoToForm(new DirMenu(), this);
                            break;
                        case "adm":
                            BehaviorLib.GoToForm(new AdmMenu(), this);
                            break;
                        default:
                            MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Ошибка базы данных"+ex,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
