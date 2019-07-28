using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class ReceivePartViewModel
    {
        public static void SetReceived(Part part,Case job)
        {
            string query = $"UPDATE Partorders SET Delivered=1 WHERE Id={part.Id};" +
                           $"UPDATE WorkOrder SET PartsOnOrder={job.NumberOfOrderedParts-1} WHERE Id={part.CaseId}";

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
