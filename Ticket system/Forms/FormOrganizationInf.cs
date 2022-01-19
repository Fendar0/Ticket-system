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
    public partial class FormOrganizationInf : Form
    {
        List<Organization> lstOrg = new List<Organization>();

        public FormOrganizationInf()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            lstOrg.Clear();
            foreach (var itm in Program.logic.GetDataOrganization())
                lstOrg.Add(itm);
            dataGridOrganization.DataSource = lstOrg;
        }

        private void btAddOrganization_Click(object sender, EventArgs e)
        {
            Organization org = new Organization();
            FormEditOrganization reo = new FormEditOrganization(org);
            if (reo.ShowDialog() == DialogResult.OK)
                Program.logic.AddInformOrganization(org);
        }

        private void dataGridOrganization_DoubleClick(object sender, EventArgs e)
        {
            Organization organization = (Organization)dataGridOrganization.CurrentRow.DataBoundItem;
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Organization orgData = lstOrg.FirstOrDefault(x => x.IDOrganization == organization.IDOrganization);
                FormEditOrganization formEditUser = new FormEditOrganization(orgData);
                if (formEditUser.ShowDialog() == DialogResult.OK)
                    Program.logic.UpdateRecordsOrganization(orgData);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridOrganization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
