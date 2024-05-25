using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Interfface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = accountController.login(loginName.Text, loginPassword.Text);

            if (loginName.Text == account.Name && loginPassword.Text == account.Password)
            {
                loggedMessage.Text = $"You have been successfully logged as {account.Name}";
                loggedMessage.ForeColor = Color.Red;
            }
            else
            {
                loggedMessage.Text = "Enter name and password to login";
                loggedMessage.ForeColor = Color.Green;
            }

        }
    }
}
