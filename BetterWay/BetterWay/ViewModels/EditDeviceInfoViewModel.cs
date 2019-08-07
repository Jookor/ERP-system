using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;
using BetterWay.ViewModels;

namespace BetterWay.ViewModels
{
    public class EditDeviceInfoViewModel
    {
        public static void WriteChangesToDb(int id,string brand,string model,string serial,string fault)
        {
            string request = $"UPDATE WorkOrder SET BrandName='{brand}'," +
                             $"ModelName='{model}'," +
                             $"SerialNumber='{serial}'," +
                             $"Fault='{fault}' " +
                             $"WHERE Id={id};";
            DA.AddToDb(request);
        }

        public static void LogChanges(int id)
        {
            TechnicianViewModel.LogStatusChange(id, "Updated device information");
        }
    }
}
