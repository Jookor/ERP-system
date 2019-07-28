using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class SkippedCaseHandlingViewModel
    {
        public static void ResetCaseStatus(int id)
        {
            string query = $"UPDATE WorkOrder SET Status='Registered' WHERE Id={id}";
            DA.AddToDb(query);
        }

        public static void DeleteCase(int id)
        {
            string query = $"DELETE FROM WorkOrder WHERE Id={id}";
            DA.AddToDb(query);
        }
    }
}
