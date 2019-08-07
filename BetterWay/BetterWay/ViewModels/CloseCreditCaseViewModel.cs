using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class CloseCreditCaseViewModel
    {
        public static void SetCreditCaseReady(Case workorder,User user)
        {
            string query = $"UPDATE WorkOrder SET Status='Ready' WHERE Id={workorder.Id}";
            try
            {
                DA.AddToDb(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
