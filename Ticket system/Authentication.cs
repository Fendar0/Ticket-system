using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Authorization auth = (Authorization)te.Authorization.Where(x => x.Login == login && x.Password == password);
                    switch (auth.IDRole)
                    {
                        case 1://Администратор
                            break;
                        case 2://Организатор
                            break;
                        case 3://Продавец
                            break;
                    }
                }
            }

        }





    }
}
