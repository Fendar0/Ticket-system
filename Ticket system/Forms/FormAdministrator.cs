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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btUsersInf_Click(object sender, EventArgs e)
        {
            FormUsersInfo frmUsersInfo = new FormUsersInfo();
            frmUsersInfo.ShowDialog();
        }

        private void btOrganizationInf_Click(object sender, EventArgs e)
        {
            FormOrganizationInf formOrganizationInf = new FormOrganizationInf();
            formOrganizationInf.ShowDialog();
        }

        private void btEventsInf_Click(object sender, EventArgs e)
        {
            FormEventsInf formEventsInf = new FormEventsInf();
            formEventsInf.ShowDialog();
        }

        private void btTicketInf_Click(object sender, EventArgs e)
        {
            FormTicketInf formTicketInf = new FormTicketInf();
            formTicketInf.ShowDialog();
        }

        private void btLogs_Click(object sender, EventArgs e)
        {
            FormLogs formLogs = new FormLogs();
            formLogs.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
        }
    }
}
