using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_system
{
    public partial class FormCategoriesEvents : Form
    {
        ObservableCollection<CategoriesEvents> lstcategEvent = new ObservableCollection<CategoriesEvents>();
        CategoriesEvents categEvent;
        bool checkAdd = false;
        bool checkEdit = false;

        public FormCategoriesEvents()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            lstcategEvent.Clear();
            foreach (var itm in Program.logic.GetDataCateg())
                lstcategEvent.Add(itm);
            dataGridViewCategIvent.DataSource = lstcategEvent;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            categEvent = new CategoriesEvents();
            tbCategory.Enabled = true;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btApply.Enabled = true; 
            
            tbCategory.Text = categEvent.Category;
            checkAdd = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            categEvent = (CategoriesEvents)dataGridViewCategIvent.CurrentRow.DataBoundItem;

            checkEdit = true;

            tbCategory.Enabled = true;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btApply.Enabled = true;

            tbCategory.Text = categEvent.Category;
        }
 
        private void btApply_Click(object sender, EventArgs e)
        {
            categEvent.Category = tbCategory.Text;
            if (checkAdd == true)
            {                
                Program.logic.AddCategoryEvent(categEvent);
            }
            else if (checkEdit == true)
            {
                using (Ticket_Entities te = new Ticket_Entities())
                {
                    CategoriesEvents categData = lstcategEvent.FirstOrDefault(x => x.IDCategory == categEvent.IDCategory);
                    Program.logic.UpdateRecordsCategEvent(categData);
                }
            }            

            checkAdd = false;
            checkEdit = false;

            checkEdit = false;
            tbCategory.Enabled = false;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btApply.Enabled = false;

            Update();

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
