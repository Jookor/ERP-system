using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class SupervisorViewModel
    {
        public static List<string> GetSkippedCases()
        {
            string query = $"SELECT  WO.Id, U.Name, Sc.Description, WO.BrandName, WO.ModelName FROM WorkOrder AS WO " +
                           $"INNER JOIN Skippedcases AS Sc ON WO.Id=Sc.CaseId " +
                           $"INNER JOIN Users AS U ON Sc.UserId=U.Id " +
                           $"WHERE WO.Status='Skipped'";
            DataTable dt = DA.GetDtFromDb(query);
            List<string> skipped = new List<string>();

            foreach(DataRow dr in dt.Rows)
            {
                string temp = Convert.ToInt32(dr["Id"]) + ", " + 
                              dr["Name"].ToString() + ", "+
                              dr["Description"].ToString() + ", " +
                              dr["BrandName"].ToString() + " "+
                              dr["ModelName"].ToString();
                skipped.Add(temp);

            }

            return skipped;
        }
    }
}
