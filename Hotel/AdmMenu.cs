using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AdmMenu : Form
    {
        public AdmMenu()
        {
            InitializeComponent();
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
        //перетаскивание формы
        private void AdmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //выход из системы
        private void exitButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.ExitFromSystem(this);
        }
        //переход к форме добавления клиента
        private void addRoomButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new AddClient(), this);
        }
        //переход к форме регистрации клиента
        private void editRoomButton_Click(object sender, EventArgs e)
        {
            BehaviorLib.GoToForm(new RegClient(), this);
        }
    }
}
