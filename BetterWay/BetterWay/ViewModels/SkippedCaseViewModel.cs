using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class SkippedCaseViewModel
    {
        public static void LogSkippedCase(int caseId, int userId, string description)
        {
            string query = $"INSERT INTO Skippedcases (CaseId,Description,UserId)" +
                           $"VALUES ({caseId},'{description}',{userId});";
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
