using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class CaseSolutionViewModel
    {
        public static string GetCaseSolution(Case job)
        {
            string temp;

            try
            {
                string query = $"SELECT Description FROM Readycases WHERE CaseId={job.Id}";
                temp = DA.GetStringFromDb(query);
            }
            catch (Exception)
            {

                throw;
            }

            return temp;
        }
    }
}
