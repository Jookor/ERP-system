using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BetterWay.Models;
using BetterWay.ViewModels;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for LogisticView.xaml
    /// </summary>
    public partial class LogisticView : UserControl
    {
        public User LoggedUser { get; set; }
        public Customer Dealer { get; set; }
        public Customer Client { get; set; }
        public Case Order { get; set; }
        public Part Sparepart { get; set; }
        public LogisticView()
        {
            InitializeComponent();
        }

        public LogisticView(User user)
        {
            InitializeComponent();
            LoggedUser = user;
            Order = new Case();

        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            txbWelcome.Text = "Olet kirjautunut " + LoggedUser.Name + " tunnuksella " + " \nTänään on " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtnAddDealer_Click(object sender, RoutedEventArgs e)
        {
            AddDealerView addDealer = new AddDealerView();
            addDealer.Show();
        }

        private void UpdateDealersList(object sender, RoutedEventArgs e)
        {
            cmbDealers.ItemsSource = LogisticViewModel.GetDealers();
        }

        private void CmbDealers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbDealers.SelectedItem == null)
            {
                txbDealerName.Text = "";
                txbDealerAddress.Text = "";
                txbDealerCity.Text = "";
                txbPostcode.Text = "";
                txbDealerPhone.Text = "";
                txbEmail.Text = "";
            }
            else
            {
                try
                {
                    Dealer = DA.GetCustomerFromDbWithId(Convert.ToInt32(cmbDealers.SelectedItem.ToString().Split('-')[0]));
                }
                catch (Exception)
                {

                    throw;
                }
                txbDealerName.Text = Dealer.Name;
                txbDealerAddress.Text = Dealer.Address;
                txbDealerCity.Text = Dealer.City;
                txbPostcode.Text = Dealer.Postcode;
                txbDealerPhone.Text = Dealer.Phone;
                txbEmail.Text = Dealer.Email;
                txtDealerName.Text = Dealer.Name;
                //MessageBox.Show(Customers[0].Name);
            }
        }

        private void BtnEditDealer_Click(object sender, RoutedEventArgs e)
        {
            UpdateDealerView view = new UpdateDealerView(Dealer);
            view.Show();
            cmbDealers.SelectedIndex = -1;
        }

        private void UpdateCustomerList(object sender, RoutedEventArgs e)
        {
            cmbCustomers.ItemsSource = LogisticViewModel.GetCustomers();
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerView view = new AddCustomerView();
            view.Show();
        }

        private void CmbCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCustomers.SelectedItem == null)
            {
                txbCustName.Text = "";
                txbCustAddress.Text = "";
                txbCustCity.Text = "";
                txbCustPostcode.Text = "";
                txbCustPhone.Text = "";
                txbCustEmail.Text = "";
            }
            else
            {
                string name = cmbCustomers.SelectedItem.ToString();
                try
                {
                    Client = DA.GetCustomerFromDbWithId(Convert.ToInt32(cmbCustomers.SelectedItem.ToString().Split('-')[0]));
                }
                catch (Exception)
                {

                    throw;
                }
                txbCustName.Text = Client.Name;
                txbCustAddress.Text = Client.Address;
                txbCustCity.Text = Client.City;
                txbCustPostcode.Text = Client.Postcode;
                txbCustPhone.Text = Client.Phone;
                txbCustEmail.Text = Client.Email;
                txtCustomerName.Text = Client.Name; 
                //MessageBox.Show(Client.Name);
            }
        }

        private void BtnEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            UpdateCustomerView view = new UpdateCustomerView(Client);
            view.Show();
            cmbDealers.SelectedIndex = -1;
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            cmbBrand.ItemsSource = LogisticViewModel.GetBrands();
        }

        private void CmbBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Order.Brand = cmbBrand.SelectedItem.ToString();
                cmbModel.ItemsSource = LogisticViewModel.GetModels(Order.Brand);
            }
            catch (Exception)
            {

                
            }
        }

        private void BtnAddModel_Click(object sender, RoutedEventArgs e)
        {
            AddModelView view = new AddModelView(cmbBrand.SelectedItem.ToString());
            view.Show();
        }

        private void BtnAddCase_Click(object sender, RoutedEventArgs e)
        {
            Order.UserId = LoggedUser.Id;
            Order.ClientId = Client.Id;
            Order.DealerId = Dealer.Id;
            Order.Warranty = cmbWarranty.Text;
            Order.Fault = txtFault.Text;
            DateTime date = (DateTime)dpPurchaseDate.SelectedDate;
            Order.PurchaseDate = date.ToString("dd-MM-yyyy");
            Order.NumberOfOrderedParts = 0;
            LogisticViewModel.SaveCaseToDb(Order);
            OrderMadeView view = new OrderMadeView(LoggedUser.Id,Order);
            view.Show();
            cmbDealers.SelectedIndex = -1;
            cmbCustomers.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            txbSerial.Text = "";
            txbFault.Text = "";
            cmbWarranty.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            txtCustomerName.Text = "";
            txtDealerName.Text = "";
            txtUnit.Text = "";
            txtFault.Text = "";
            txtWarranty.Text = "";
            Order = new Case();
        }

        private void CmbModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Order.Model = cmbModel.SelectedItem.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void TiOverview_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFault.Text = txbFault.Text;
            Order.Serial = txbSerial.Text;
            txtWarranty.Text = cmbWarranty.Text;
            txtUnit.Text = Order.Brand + " | " + Order.Model + " | " + Order.Serial;
        }

        private void StackPanel_Loaded_1(object sender, RoutedEventArgs e)
        {
            lsvOrderedParts.DataContext = LogisticViewModel.GetPartOrders();
            lsvOrderedParts.SelectedIndex = 0;
        }

        private void LsvOrderedParts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Sparepart = (Part)lsvOrderedParts.SelectedItem;
            ReceivePartView view = new ReceivePartView(Sparepart);
            //I had to but this sleep command here because the database isn't ready yet with the other requests
            Thread.Sleep(3000);
            view.Show();
        }

    }
}
