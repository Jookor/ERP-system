using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;
using BetterWay.Views;

namespace BetterWay.ViewModels
{
    public class LoginViewModel
    {
        public static User CheckUser(string name, string password)
        {
            //Check if user is in the database if not throw error
            try
            {
                string request = $"SELECT Id,Name,UserType FROM Users WHERE Name='{name}' AND Password='{password}'";
                User LoggedUser = DA.GetUserFromDb(request);
                return LoggedUser;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static MainWindow SetView(User user, MainWindow main)
        {
            //Selects the right view to the mainwindow
            if (user.UserType.Equals("technician"))
            {
                main.DataContext = new TechnicianView(user);
                
            }

            if (user.UserType.Equals("logistic"))
            {
                main.DataContext = new LogisticView(user);
               
            }

            if (user.UserType.Equals("supervisor"))
            {
                main.DataContext = new SupervisorView(user);
               
            }

            return main;
        }
    }
}
