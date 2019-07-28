using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterWay.Models;

namespace BetterWay.ViewModels
{
    public class LogisticViewModel
    {
        //Gets datatable from DA class and returns list of the dealers
        public static List<string> GetDealers()
        {
            List<string> dealers = new List<string>();
            string request = $"SELECT DISTINCT Id,Name FROM Customers WHERE Dealer=1";
            DataTable dt = DA.GetDtFromDb(request);

            foreach (DataRow row in dt.Rows)
            {
                dealers.Add(row[0].ToString()+"-"+row[1].ToString());
            }

            return dealers;
        }
        //Gets datatable from DA class and returns list of the customers
        public static List<string> GetCustomers()
        {
            List<string> customers = new List<string>();
            string request = $"SELECT DISTINCT Id,Name FROM Customers WHERE Dealer=0";
            DataTable dt = DA.GetDtFromDb(request);

            foreach (DataRow row in dt.Rows)
            {
                customers.Add(row[0].ToString()+"-"+row[1].ToString());
            }

            return customers;
        }

        //Gets Customer object from DA class
        public static Customer GetCustomer(string name)
        {
            Customer customer = DA.GetCustomerFromDb(name);

            return customer;
        }
        //Gets all the Brands from DA class
        public static List<string> GetBrands()
        {
            List<string> brands = new List<string>();
            string request = "SELECT DISTINCT Name FROM Brands";
            DataTable dt = DA.GetDtFromDb(request);

            foreach (DataRow row in dt.Rows)
            {
                brands.Add(row[0].ToString());
            }

            return brands;
        }
        //Gets all the models from the given brand
        public static List<string> GetModels(string brand)
        {
            List<string> models = new List<string>();
            string request = $"SELECT Models.Name FROM Models INNER JOIN Brands ON Models.Brand = Brands.Name WHERE Brands.Name='{brand}'";
            DataTable dt = DA.GetDtFromDb(request);

            foreach (DataRow row in dt.Rows)
            {
                models.Add(row[0].ToString());
            }

            return models;
        }
        //Save the case to the database
        public static void SaveCaseToDb(Case job)
        {
            string request = $"INSERT INTO WorkOrder (UserId,BrandName,ModelName,SerialNumber,Fault,Warranty,DealerId,CustomerId,Status,RegDate,PurchaseDate,PartsOnOrder)" +
                             $"VALUES ({job.UserId}," +
                             $"'{job.Brand}'," +
                             $"'{job.Model}'," +
                             $"'{job.Serial}'," +
                             $"'{job.Fault}'," +
                             $"'{job.Warranty}'," +
                             $"{job.DealerId}," +
                             $"{job.ClientId},"+
                             $"'Registered'," +
                             $"date('now')," +
                             $"'{job.PurchaseDate}'," +
                             $"{job.NumberOfOrderedParts});";
            DA.AddToDb(request);
        }
        //Get part orders from database
        public static List<Part> GetPartOrders()
        {
            List<Part> parts = new List<Part>();
            string query = $"SELECT * FROM Partorders WHERE Delivered=0";
            DataTable temp = DA.GetDtFromDb(query);

            foreach(DataRow dr in temp.Rows)
            {
                Part part = new Part();
                part.Id = Convert.ToInt32(dr["Id"]);
                part.Partnumber = dr["Partnumber"].ToString();
                part.CaseId = Convert.ToInt32(dr["Caseid"]);
                string date = dr["Orderdate"].ToString();
                part.OrderDate = date.Split(' ')[0];
                part.Delivered = Convert.ToInt32(dr["Delivered"]);
                parts.Add(part);
            }

            return parts;
        }
    }
}
