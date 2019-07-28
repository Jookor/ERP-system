using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class AddModelViewModel
    {
        public static void AddModel(string model, string brand, string category)
        {
            string command = $"INSERT INTO Models (Brand,Name,Category) VALUES ('{brand}','{model}','{category}')";
            DA.AddToDb(command);
        }

        public static List<string> GetCategory()
        {
            List<string> category = new List<string>();
            string request = "SELECT Name FROM Category";
            DataTable dt = DA.GetDtFromDb(request);

            foreach (DataRow row in dt.Rows)
            {
                category.Add(row[0].ToString());
            }

            return category;
        }

     
    }
}
