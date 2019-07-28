using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWay.Models
{
    public class Case
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public int DealerId { get; set; }
        public string DealerName { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string PurchaseDate { get; set; }
        public string Warranty { get; set; }
        public string Fault { get; set; }
        public int NumberOfOrderedParts { get; set; }
        public string DeviceInfo { get { return Brand + " " + Model; } }

        //Gets the owner and dealer names from database and sets them to this object
        public void GetNamesById()
        {
            try
            {
                string request = $"SELECT Name FROM Customers WHERE Id={ClientId}";
                ClientName = DA.GetStringFromDb(request);
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                string request = $"SELECT Name FROM Customers WHERE Id={DealerId}";
                DealerName = DA.GetStringFromDb(request);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
