using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class UpdateCustomerViewModel
    {
        public static void UpdateCustomerInfo(Customer customer)
        {
            string request = "UPDATE Customers " +
                             $"SET Name='{customer.Name}', " +
                             $"Address='{customer.Address}', " +
                             $"City='{customer.City}', " +
                             $"Postcode='{customer.Postcode}'," +
                             $"Phone='{customer.Phone}'," +
                             $"Email='{customer.Email}' " +
                             $"WHERE Id='{customer.Id}'";
            DA.AddToDb(request);
        }

    }
}
