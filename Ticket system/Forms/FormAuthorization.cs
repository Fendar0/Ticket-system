using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_system
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            string login = tbLogIn.Text.ToString();
            string password = tbPassword.Text.ToString();
            this.Close();
            Hide();
            Program.authentication.Authen(password, login);            
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
