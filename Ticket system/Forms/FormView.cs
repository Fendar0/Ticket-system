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
    public partial class FormView : Form
    {

        public FormView()
        {
            InitializeComponent();
            UpdateControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblogIn_Click(object sender, EventArgs e)
        {
            FormAuthorization fa = new FormAuthorization();
            fa.ShowDialog();
            Hide();
            Close();
        }

        private void UpdateControl()
        {
            List<string> catList = new List<string>();
            foreach (var itm in Program.logic.GetDataCateg())
                catList.Add(itm.Category);

            for (int i = 0; i < catList.Count; i++)
            {
                tabControl.TabPages.Add(catList[i]);                   
            }                       
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
        }

       
    }
}
