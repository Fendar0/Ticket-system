using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_system
{
    public class Authentication
    {
        public void Authen(string password, string login)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                if (te.Authorization.FirstOrDefault(x => x.Login == login && x.Password == password) != null)
                {                    
                    Authorization auth = te.Authorization.FirstOrDefault(x => x.Login == login && x.Password == password);
                    switch (auth.IDRole)
                    {
                        case 1://Администратор
                            Administrator admin = new Administrator();
                            admin.ShowDialog();                            
                            break;
                        case 2://Организатор
                            FormOrganizer fo = new FormOrganizer();
                            fo.ShowDialog();
                            break;
                        case 3://Продавец
                            Seller seller = new Seller();
                            seller.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели нерпавиьные данные");
                    FormAuthorization fa = new FormAuthorization();
                    fa.ShowDialog();
                }
            }
        }       
    }
}
