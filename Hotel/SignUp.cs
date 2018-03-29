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
    public partial class SignUp : Form
    {
        public SignUp()
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
        //сворачивание активного окно
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //возврат к главной форме
        private void buttonBack_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new MainForm(), this);
        }
        //регистрация в системе
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string login, pass, name, query, repeatQuery;
            string role = "adm";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString)) {
                try
                {
                    login = textBoxLogin.Text;
                    pass = textBoxPass.Text;
                    name = textBoxName.Text;
                    bool flag = false;
                    repeatQuery = "SELECT Login FROM [User]";
                    connection.Open();
                    SqlCommand repeat = new SqlCommand(repeatQuery, connection);
                    SqlDataReader repeatReader = repeat.ExecuteReader();
                    if (repeatReader.HasRows)
                    {
                        string currentLogin = "";
                        int i = 0;
                        while (repeatReader.Read())
                        {
                            currentLogin = repeatReader.GetString(i);
                            i++;
                            if (currentLogin == login)
                            {
                                MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        query = "INSERT INTO [User] VALUES ('" + login + "','" + pass + "','" + name + "','" + role + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Ошибка базы данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
