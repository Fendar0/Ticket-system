using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_system
{
    /// <summary>
    /// Класс логики
    /// </summary>
    internal class Logic
    {
        /// <summary>
        /// Метод добавления пользователей
        /// </summary>
        /// <param name="user">Переданные данные с формы</param>
        /// <param name="auth">Переданные данные с формы</param>
        public void AddUser(Authorization auth)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.Authorization.Add(auth);
                te.SaveChanges();
            }           
        }
               
        public void UpdateRecords(Authorization authorization)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Authorization olddata = te.Authorization.FirstOrDefault(x => x.IDAuth == authorization.IDAuth);
                olddata.Surname = authorization.Surname;
                olddata.FirstName = authorization.FirstName;
                olddata.Patronymic = authorization.Patronymic;
                olddata.DateBirth = authorization.DateBirth;
                olddata.Sex = authorization.Sex;
                olddata.Login = authorization.Login;
                olddata.Password = authorization.Password;
                olddata.IDRole = authorization.IDRole;
                olddata.CreateDate = authorization.CreateDate;
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Получение данных из таблицы CategoriesEvents
        /// </summary>
        /// <returns></returns>
        public List<CategoriesEvents> GetDataCateg()
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                return te.CategoriesEvents.ToList();
            }
        }

        public List<Authorization> View()
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                return te.Authorization.ToList();
            }
        }

        /// <summary>
        /// Метод редактирования польщователей
        /// </summary>
        /// <param name="user">Переданные данные с формы</param>
        /// <param name="auth">Переданные данные с формы</param>
        public void EditingUser(Authorization auth)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Authorization oldauth = te.Authorization.FirstOrDefault(x => x.IDAuth == auth.IDAuth);
                oldauth.FirstName = auth.FirstName;
                oldauth.Surname = auth.Surname;
                oldauth.Patronymic = auth.Patronymic;
                oldauth.DateBirth = auth.DateBirth;
                oldauth.Sex = auth.Sex;                
                oldauth.Login = auth.Login;
                oldauth.Password = auth.Password;
                oldauth.IDRole = auth.IDRole;
                oldauth.CreateDate = auth.CreateDate;                
                //oldauth.IDUser = user.IDUser;
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод добавления информации об организациях проводящих мероприятия
        /// </summary>
        /// <param name="org">Переданные данные с формы</param>
        public void AddInformOrganization(Organization org)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.Organization.Add(org);
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод редактирования информации об организациях проводящих мероприятия
        /// </summary>
        /// <param name="org">Переданные данные с формы</param>
        public void EditInformOrganization(Organization org)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Organization organ = te.Organization.FirstOrDefault(x => x.IDOrganization == org.IDOrganization);
                organ.Title = org.Title;
                organ.PhoneNumber = org.PhoneNumber;
                organ.Email = org.Email;
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод добавления мероприятий
        /// </summary>
        /// <param name="events">Переданные данные с формы</param>
        public void AddEvent(Events events)
        {
            using(Ticket_Entities te = new Ticket_Entities())
            {
                te.Events.Add(events);
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод редактирования мероприятий
        /// </summary>
        /// <param name="events">Переданные данные с формы</param>
        public void EditEvent(Events events)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Events even = te.Events.FirstOrDefault(x => x.IDEvents == events.IDEvents);
                even.Title = events.Title;
                even.IDCategory = events.IDCategory;
                even.NumbersOfVisitors = events.NumbersOfVisitors;
                even.IDOrganisation = events.IDOrganisation;
                even.Status = events.Status;
                even.IDAuth = events.IDAuth;
                even.StartDate = events.StartDate;
                even.EndDate = events.EndDate;                
                te.SaveChanges();
            }
        }

        /// <summary>
        /// метод добавления новых категорий мероприятий
        /// </summary>
        /// <param name="categ">Переданные данные с формы</param>
        public void AddCategoryEvent(CategoriesEvents categ)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.CategoriesEvents.Add(categ);
                te.SaveChanges();
            }
        }

        /// <summary>
        /// метод редактирования новых категорий мероприятий
        /// </summary>
        /// <param name="categ">Переданные данные с формы</param>
        public void EditCategoryEvent(CategoriesEvents categ)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                CategoriesEvents cat = te.CategoriesEvents.FirstOrDefault(x => x.IDCategory == x.IDCategory);
                cat.Category = categ.Category;
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод добавленяи типа билета
        /// </summary>
        /// <param name="type">Переданные данные с формы</param>
        public void AddTypeTicket(TypeTicket type)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.TypeTicket.Add(type);
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод редактирования типов билетов
        /// </summary>
        /// <param name="type">Переданные данные с формы</param>
        public void EditTypeTicket(TypeTicket type)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                TypeTicket tpt = te.TypeTicket.FirstOrDefault(x => x.IDType == x.IDType);
                tpt.Cost = type.Cost;
                tpt.Title = type.Title;
                tpt.Type = type.Type;
                tpt.Amount = type.Amount;
                tpt.Description = type.Description;
            }
        }

        /// <summary>
        /// Метод добавления мест проведения мероприятий
        /// </summary>
        /// <param name="place">Переданные данные с формы</param>
        public void AddPlace(Place place)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.Place.Add(place);
                te.SaveChanges();
            }
        }

        /// <summary>
        /// Метод редактирования мест проведения мероприятий
        /// </summary>
        /// <param name="place">Переданные данные с формы</param>
        public void EditPlace(Place place)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                Place pl = te.Place.FirstOrDefault(x => x.IDPlace == x.IDPlace);
                pl.Title = place.Title;
                pl.City = place.City;
                pl.Address = place.Address;
            }
        }

        /// <summary>
        /// Метод создания билета
        /// </summary>
        /// <param name="tiket">Переданные данные с формы</param>
        public void AddTicket(Tickets tiket)
        {
            using (Ticket_Entities te = new Ticket_Entities())
            {
                te.Tickets.Add(tiket);
                te.SaveChanges();
            }
        }

    }
}
