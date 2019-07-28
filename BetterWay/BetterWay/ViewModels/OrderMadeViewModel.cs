using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class OrderMadeViewModel
    {
        public static int GetCaseNumber(int userid)
        {
            string request = $"SELECT Id FROM WorkOrder WHERE UserId={userid} ORDER BY Id DESC LIMIT 1";
            return DA.GetIntFromDb(request);
        }

        public static void PrintWorkOrder(int caseid)
        {

        }
    }
}
