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
            Hide();
            frmUsersInfo.ShowDialog();
            Show();
        }

        private void btOrganizationInf_Click(object sender, EventArgs e)
        {
            FormOrganizationInf formOrganizationInf = new FormOrganizationInf();
            Hide();
            formOrganizationInf.ShowDialog();
            Show();
        }

        private void btEventsInf_Click(object sender, EventArgs e)
        {
            FormEventsInf formEventsInf = new FormEventsInf();
            Hide();
            formEventsInf.ShowDialog();
            Show();
        }

        private void btTicketInf_Click(object sender, EventArgs e)
        {
            FormTicketInf formTicketInf = new FormTicketInf();
            Hide();
            formTicketInf.ShowDialog();
            Show();
        }

        private void btLogs_Click(object sender, EventArgs e)
        {
            FormLogs formLogs = new FormLogs();
            Hide();
            formLogs.ShowDialog();
            Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategoriesEvents categEvents = new FormCategoriesEvents();
            Hide();
            categEvents.ShowDialog();
            Show();
        }
    }
}
