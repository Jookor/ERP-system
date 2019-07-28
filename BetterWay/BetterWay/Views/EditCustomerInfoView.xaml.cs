using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BetterWay.ViewModels;
using BetterWay.Models;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for EditCustomerInfoView.xaml
    /// </summary>
    public partial class EditCustomerInfoView : Window
    {
        private Case customerOrder;
        private Customer customer;
        public EditCustomerInfoView()
        {
            InitializeComponent();
        }

        public EditCustomerInfoView(Case job, string customertype)
        {
            InitializeComponent();
            customerOrder = job;

            if (customertype.Equals("customer"))
            {
                cmbCustomers.ItemsSource = LogisticViewModel.GetCustomers();
                cmbCustomers.SelectedItem = customerOrder.ClientId+"-"+customerOrder.ClientName;
                LoadCustomerInfo();
            }
            else
            {
                cmbCustomers.ItemsSource = LogisticViewModel.GetDealers();
                cmbCustomers.SelectedItem = customerOrder.DealerId + "-" + customerOrder.DealerName;
                LoadCustomerInfo();
            }

        }

        private void LoadCustomerInfo()
        {
            spCustomer.DataContext = customer;
        }

        private void CmbCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = DA.GetCustomerFromDbWithId(Convert.ToInt32(cmbCustomers.SelectedItem.ToString().Split('-')[0]));
            LoadCustomerInfo();
        }

        private void BtnUpdateCustomer_Click(object sender, RoutedEventArgs e)
        {
            UpdateCustomerView view = new UpdateCustomerView(customer);
            view.Show();
        }

        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerView view = new AddCustomerView();
            view.Show();
        }
    }
}
