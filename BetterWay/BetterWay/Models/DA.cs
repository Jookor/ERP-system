using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWay.Models
{
    public class DA
    {
        //Gets data from database and return User object
        public static User GetUserFromDb(string request)
        {
            try
            {
                string filename = BetterWay.Properties.Settings.Default.Database;
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        SQLiteCommand com = new SQLiteCommand(request, conn);
                        conn.Open();
                        SQLiteDataReader dr = com.ExecuteReader();
                        dr.Read();
                        User user = new User();
                        user.Id = dr.GetInt32(0);
                        user.Name = dr.GetString(1);
                        user.UserType = dr.GetString(2);
                        return user;
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Gets data from database and returns string
        public static string GetStringFromDb(string request)
        {
            try
            {
                string filename = BetterWay.Properties.Settings.Default.Database;
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        SQLiteCommand com = new SQLiteCommand(request, conn);
                        conn.Open();
                        SQLiteDataReader dr = com.ExecuteReader();
                        dr.Read();
                        return dr.GetString(0).ToString();
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Gets data from database and returns int
        public static int GetIntFromDb(string request)
        {
            try
            {
                string filename = BetterWay.Properties.Settings.Default.Database;
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        SQLiteCommand com = new SQLiteCommand(request, conn);
                        conn.Open();
                        SQLiteDataReader dr = com.ExecuteReader();
                        dr.Read();
                        return dr.GetInt32(0);
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Writes to database
        public static void AddToDb(string sqlrequest)
        {
            string filename = BetterWay.Properties.Settings.Default.Database;
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        conn.Open();
                        using (SQLiteCommand command = new SQLiteCommand(sqlrequest, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Gets DataTable from database
        public static DataTable GetDtFromDb(string sqlrequest)
        {
            string filename = BetterWay.Properties.Settings.Default.Database;
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        conn.Open();
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(sqlrequest, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                        
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Gets Customer object from database with customer name
        public static Customer GetCustomerFromDb(string name)
        {
            try
            {
                string filename = BetterWay.Properties.Settings.Default.Database;
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        SQLiteCommand com = new SQLiteCommand($"SELECT * FROM Customers WHERE Name='{name}'", conn);
                        conn.Open();
                        SQLiteDataReader dr = com.ExecuteReader();
                        dr.Read();
                        Customer customer = new Customer();
                        customer.Id = dr.GetInt32(0);
                        customer.Name = dr.GetString(1).ToString();
                        customer.Address = dr.GetString(2).ToString();
                        customer.City = dr.GetString(3).ToString();
                        customer.Postcode = dr.GetString(4).ToString();
                        customer.Phone = dr.GetString(5).ToString();
                        customer.Email = dr.GetString(6).ToString();
                        
                        if (dr.GetInt32(7) == 1)
                        {
                            customer.Dealer = true;
                        }
                        else
                        {
                            customer.Dealer = false;
                        }
                        return customer;
                        
                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        //Gets Customer object from database with customer id
        public static Customer GetCustomerFromDbWithId(int id)
        {
            try
            {
                string filename = BetterWay.Properties.Settings.Default.Database;
                if (System.IO.File.Exists(filename))
                {
                    using (SQLiteConnection conn = new SQLiteConnection($"Data source={filename}"))
                    {
                        SQLiteCommand com = new SQLiteCommand($"SELECT * FROM Customers WHERE Id='{id}'", conn);
                        conn.Open();
                        SQLiteDataReader dr = com.ExecuteReader();
                        dr.Read();
                        Customer customer = new Customer();
                        customer.Id = dr.GetInt32(0);
                        customer.Name = dr.GetString(1).ToString();
                        customer.Address = dr.GetString(2).ToString();
                        customer.City = dr.GetString(3).ToString();
                        customer.Postcode = dr.GetString(4).ToString();
                        customer.Phone = dr.GetString(5).ToString();
                        customer.Email = dr.GetString(6).ToString();

                        if (dr.GetInt32(7) == 1)
                        {
                            customer.Dealer = true;
                        }
                        else
                        {
                            customer.Dealer = false;
                        }
                        return customer;

                    }
                }
                else
                {
                    throw new Exception($"Tiedostoa {filename} ei löydy.");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
