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
    public partial class FormEventsInf : Form
    {
        List<Events> lstEvent = new List<Events>();

        public FormEventsInf()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            
        } 

        private void btAdd_Click(object sender, EventArgs e)
        {
            /*Events eve = new Events();

            FormEditEvent ree = new FormEditEvent();
            if (ree.ShowDialog() == DialogResult.OK)
                Program.logic.AddInformOrganization(org);*/
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridEvents_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
