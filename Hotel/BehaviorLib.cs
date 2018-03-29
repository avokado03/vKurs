using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    static class BehaviorLib
    {
        static public void goToForm(Form fOpen, Form fClose) {
            MainForm.ActiveForm.Hide();
            fOpen.ShowDialog();
            fClose.Close();
        } 
    }
}
