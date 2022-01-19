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
    public partial class FormEditOrganization : Form
    {
        Organization organization;
        public FormEditOrganization(Organization org)
        {
            InitializeComponent();
            organization = org;

            tbTitle.Text = organization.Title;
            tbphone.Text = organization.PhoneNumber;
            tbEmail.Text = organization.Email;

        }

        private void btApply_Click(object sender, EventArgs e)
        {
            organization.Title = tbTitle.Text.Trim();
            if (tbphone.Text.Contains(')') && tbphone.Text.Contains('('))
            {
                MessageBox.Show("Введите номер телефона без скобочек");

            }
            else if (tbphone.Text.Contains('+'))
            {
                organization.PhoneNumber = tbphone.Text.Trim();
                organization.Email = tbEmail.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Введите номер телефона начиная с +7");

            
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();            
        }
    }
}
