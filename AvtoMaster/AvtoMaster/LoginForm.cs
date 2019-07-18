using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMaster
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminForm examp = new AdminForm();
            examp.FormClosed += Examp_FormClosed;
            examp.Show();
        }

        private void User_Click(object sender, EventArgs e)
        {
            Hide();
            UserForm examp = new UserForm();
            examp.FormClosed += Examp_FormClosed;
            examp.Show();
        }

        private void Examp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
