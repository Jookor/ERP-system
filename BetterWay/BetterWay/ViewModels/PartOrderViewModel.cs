using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class PartOrderViewModel
    {
        public static DataTable GetPartOrderLogs(int id)
        {
            string request = $"SELECT Partnumber,Quantity,Orderdate FROM Partorders WHERE CaseId={id};";
            return DA.GetDtFromDb(request);
        }

        public static void MakePartOrder(int id,string partnumber,int quantity,int numberOfParts)
        {
            string request = "INSERT INTO Partorders (Partnumber,Quantity,Caseid,Orderdate,Delivered)" +
                             $"VALUES ('{partnumber}',{quantity},{id},Date('now'),0);" +
                             $"UPDATE WorkOrder SET PartsOnOrder={numberOfParts}, Status='Waiting parts' WHERE Id={id}; " +
                             $"INSERT INTO Logs (CaseId,Action,Date) VALUES ({id},'Waiting parts',DATE('now'));";
            try
            {
                DA.AddToDb(request);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void LogChanges(int id, string status)
        {
            TechnicianViewModel.LogStatusChange(id, status);
        }

    }
}
