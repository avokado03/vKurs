using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    //класс методов, отвечающих за поведение приложения
    static class BehaviorLib
    {
        //переход с одной формы на другую
        static public void GoToForm(Form fOpen, Form fClose) {
            MainForm.ActiveForm.Hide();
            fOpen.ShowDialog();
            fClose.Close();
        }
        //выход из системы
        static public void ExitFromSystem(Form f) {
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.id = 0;
            Properties.Settings.Default.role = "";
            GoToForm(new SignIn(), f);
        }
    }
}
