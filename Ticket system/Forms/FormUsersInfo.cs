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
    public partial class FormUsersInfo : Form
    {
        List<Authorization> lstAuth = new List<Authorization>();

        public FormUsersInfo()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            lstAuth.Clear();
            foreach(var itm in Program.logic.View())
                lstAuth.Add(itm);
            dataGridUsers.DataSource = lstAuth;
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {              
            Authorization au = new Authorization();
            FormEditUser formEditUser = new FormEditUser(au);
            if (formEditUser.ShowDialog() == DialogResult.OK)
                Program.logic.AddUser(au);
        }

        private void dataGridUsers_DoubleClick(object sender, EventArgs e)
        {
            Authorization authorization = (Authorization)dataGridUsers.CurrentRow.DataBoundItem;
            if(authorization != null)
            {
                Authorization authData = lstAuth.FirstOrDefault(x => x.IDAuth == authorization.IDAuth);
                FormEditUser formEditUser = new FormEditUser(authData);
                if (formEditUser.ShowDialog() == DialogResult.OK)
                    Program.logic.UpdateRecords(authData);
            }


        }

        private void FormUsersInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
