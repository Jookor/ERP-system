using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class SetCaseReadyViewModel
    {
        public static void SetCaseToReadyStatus(int caseId, int userId, string description)
        {
            string query = $"INSERT INTO Readycases (CaseId,UserId,Description,ReadyDate)" +
                           $"VALUES ({caseId},{userId},'{description}',Date('now'));" +
                           $"UPDATE WorkOrder SET Status='Ready' WHERE Id={caseId}";
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
