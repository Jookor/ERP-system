using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class TechnicianViewModel
    {
        public static List<Case> GetWorkOrders(string status)
        {
            List<Case> workorders = new List<Case>();
            string request = $"SELECT * FROM WorkOrder WHERE Status={status} LIMIT 10;";
            DataTable temp = DA.GetDtFromDb(request);
            
            foreach (DataRow dr in temp.Rows)
            {
                Case job = new Case();
                job.Id = Convert.ToInt32(dr["Id"]);
                job.Brand = dr["BrandName"].ToString();
                job.Model = dr["ModelName"].ToString();
                job.Serial = dr["SerialNumber"].ToString();
                job.UserId = Convert.ToInt32(dr["UserId"]);
                job.Fault = dr["Fault"].ToString();
                job.DealerId = Convert.ToInt32(dr["DealerId"]);
                job.ClientId = Convert.ToInt32(dr["CustomerId"]);
                job.Warranty = dr["Warranty"].ToString();
                job.PurchaseDate = dr["PurchaseDate"].ToString();
                job.NumberOfOrderedParts = Convert.ToInt32(dr["PartsOnOrder"]);
                job.GetNamesById();
                workorders.Add(job);
            }
            return workorders;
        }

        public static Case GetWorkOrder(int id)
        {
            string request = $"SELECT Id,BrandName,ModelName,SerialNumber,UserId,Fault,DealerId,CustomerId,Warranty,PartsOnOrder FROM WorkOrder WHERE Id={id};";
            try
            {
                DataTable temp = DA.GetDtFromDb(request);
                Case job = new Case();
                foreach (DataRow dr in temp.Rows)
                {
                    job.Id = Convert.ToInt32(dr["Id"]);
                    job.Brand = dr["BrandName"].ToString();
                    job.Model = dr["ModelName"].ToString();
                    job.Serial = dr["SerialNumber"].ToString();
                    job.UserId = Convert.ToInt32(dr["UserId"]);
                    job.Fault = dr["Fault"].ToString();
                    job.DealerId = Convert.ToInt32(dr["DealerId"]);
                    job.ClientId = Convert.ToInt32(dr["CustomerId"]);
                    job.Warranty = dr["Warranty"].ToString();
                    job.NumberOfOrderedParts = Convert.ToInt32(dr["PartsOnOrder"]);
                    job.GetNamesById();
                }
                return job;
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public static Case GetNextCaseInLine()
        {
            string request = $"SELECT * FROM WorkOrder WHERE Status='Registered' LIMIT 1;";
            try
            {
                DataTable temp = DA.GetDtFromDb(request);
                Case job = new Case();
                foreach (DataRow dr in temp.Rows)
                {
                    job.Id = Convert.ToInt32(dr["Id"]);
                    job.Brand = dr["BrandName"].ToString();
                    job.Model = dr["ModelName"].ToString();
                    job.Serial = dr["SerialNumber"].ToString();
                    job.UserId = Convert.ToInt32(dr["UserId"]);
                    job.Fault = dr["Fault"].ToString();
                    job.DealerId = Convert.ToInt32(dr["DealerId"]);
                    job.ClientId = Convert.ToInt32(dr["CustomerId"]);
                    job.Warranty = dr["Warranty"].ToString();
                    job.PurchaseDate = dr["PurchaseDate"].ToString();
                    job.NumberOfOrderedParts = Convert.ToInt32(dr["PartsOnOrder"]);
                    job.GetNamesById();
                }
                return job;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SetCaseStatus(Case job, string status)
        {
            if (!status.Equals("Waiting parts"))
            {
                string request = $"UPDATE WorkOrder SET Status='{status}' WHERE Id={job.Id};";
                try
                {
                    DA.AddToDb(request);
                    LogStatusChange(job.Id, status);
                }
                catch (Exception)
                {

                    throw;
                } 
            }
            else
            {
                int newCount = job.NumberOfOrderedParts + 1;
                string request = $"UPDATE WorkOrder SET Status='{status}', PartsOnOrder={newCount} WHERE Id={job.Id};";
                try
                {
                    DA.AddToDb(request);
                    LogStatusChange(job.Id, status);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void LogStatusChange(int caseid,string status)
        {
            string request = $"INSERT INTO Logs (CaseId,Action,Date) VALUES ({caseid},'{status}',DATE('now'));";
            try
            {
                DA.AddToDb(request);
                
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void ChangeCaseStatus(int caseid, string status)
        {
            string query = $"UPDATE WorkOrder SET Status='{status}' WHERE Id={caseid};";
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
