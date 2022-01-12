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

    public partial class FormEditUser : Form
    {
        Authorization auth;
        string sex;
        DateTime date = DateTime.Parse("01.01.0001 0:00:00");

        public FormEditUser(Authorization ath)
        {
            InitializeComponent();
            auth = ath;
            if (auth.DateBirth == date)
            {
                tbName.Text = auth.FirstName;
                tbSurname.Text = auth.Surname;
                tbPatrinymic.Text = auth.Patronymic;
                auth.DateBirth = DateTime.Now;
                if (auth.Sex == "М")
                    rbM.Checked = true;
                else
                    rbF.Checked = true;
                tbLogin.Text = auth.Login;
                tbPassword.Text = auth.Password;
                tbRole.Text = auth.IDRole.ToString();
                auth.CreateDate = DateTime.Now;
                
            }
            else
            {
                tbName.Text = auth.FirstName;
                tbSurname.Text = auth.Surname;
                tbPatrinymic.Text = auth.Patronymic;
                DateBirth.Value = auth.DateBirth;
                if (auth.Sex == "М")
                    rbM.Checked = true;
                else
                    rbF.Checked = true;
                tbLogin.Text = auth.Login;
                tbPassword.Text = auth.Password;
                tbRole.Text = auth.IDRole.ToString();
                DateCreate.Value = auth.CreateDate;
            }
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbM.Checked == true)
                sex = "М";
            else
                sex = "Ж";
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            auth.FirstName = tbName.Text.Trim();
            auth.Surname = tbSurname.Text.Trim();
            auth.Patronymic = tbPatrinymic.Text.Trim();
            auth.DateBirth = DateBirth.Value;
            auth.Sex = sex;
            auth.Login = tbLogin.Text.Trim();
            auth.Password = tbPassword.Text.Trim();
            auth.IDRole = Convert.ToInt32(tbRole.Text.Trim());
            auth.CreateDate = DateCreate.Value;

            DialogResult = DialogResult.OK;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Hide();
            FormUsersInfo formUsersInfo = new FormUsersInfo();
            formUsersInfo.Show();
        }
    }
}
