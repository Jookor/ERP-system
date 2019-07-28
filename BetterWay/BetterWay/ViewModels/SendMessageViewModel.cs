using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class SendMessageViewModel
    {
        public static Customer GetCustomerInfo(int id)
        {
            return DA.GetCustomerFromDbWithId(id);
        }
    }
}
