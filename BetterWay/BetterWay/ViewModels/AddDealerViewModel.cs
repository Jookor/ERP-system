using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class AddDealerViewModel
    {
        public static void AddDealer(string dealer, string address, string city, string postcode, string phone, string email)
        {
            string command = "INSERT INTO Customers (Name,Address,City,Postcode,Phone,Email,Dealer) " +
                             $"VALUES ('{dealer}','{address}','{city}','{postcode}','{phone}','{email}',1)";
            DA.AddToDb(command);
        }
    }
}
