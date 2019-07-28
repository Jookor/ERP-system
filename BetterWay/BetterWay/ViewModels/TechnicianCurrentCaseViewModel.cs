using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class TechnicianCurrentCaseViewModel
    {
        public static DataTable GetLogs(int caseId)
        {
            string request = $"SELECT Action,Date FROM Logs WHERE CaseId={caseId}";
            return DA.GetDtFromDb(request);
        }

        public static void SetCaseToReadyStatus(int caseId)
        {
            string query = $"UPDATE WorkOrder SET Status='Ready' WHERE Id={caseId}";
            try
            {
                DA.AddToDb(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SetCaseStatus(int caseId,string status)
        {
            string query = $"UPDATE WorkOrder SET Status='{status}' WHERE Id={caseId}";
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
