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

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblogIn_Click(object sender, EventArgs e)
        {
            FormAuthorization fa = new FormAuthorization();
            Hide();
            fa.ShowDialog();
            Show();
        }

        private void UpdateControl()
        {
            List<string> catList = new List<string>();
            foreach (var itm in Program.logic.GetDataCateg())
                catList.Add(itm.Category);

            for (int i = 0; i < catList.Count; i++)
            {
                tabControl.TabPages.Add(catList[i]);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Location = new Point(tabControl.Location.X - 12, tabControl.Location.Y - 66);
                panel.Width = tabControl.Width;
                panel.Height = tabControl.Height;
                panel.BackColor = Color.White;
                panel.AutoScroll = true;
                panel.WrapContents = true;
                tabControl.TabPages[i].Controls.Add(panel);
                                
            }                       
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            toolTip1.SetToolTip(tabControl, "Выберите категорию и нажмите 2 раза по мероприятию");

        }
    }
}
