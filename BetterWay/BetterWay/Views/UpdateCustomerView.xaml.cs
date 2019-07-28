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
using BetterWay.Models;
using BetterWay.ViewModels;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for UpdateCustomerView.xaml
    /// </summary>
    public partial class UpdateCustomerView : Window
    {
        private Customer customer;
        public UpdateCustomerView()
        {
            InitializeComponent();
        }

        public UpdateCustomerView(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void BtnSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            customer.Name = txbCustomer.Text;
            customer.Address = txbAddress.Text;
            customer.City = txbCity.Text;
            customer.Postcode = txbPostcode.Text;
            customer.Phone = txbPhone.Text;
            customer.Email = txbEmail.Text;
            UpdateCustomerViewModel.UpdateCustomerInfo(customer);
            MessageBox.Show(customer.Name + " tiedot päivitetty");
            this.Close();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            txbCustomer.Text = customer.Name;
            txbAddress.Text = customer.Address;
            txbCity.Text = customer.City;
            txbPostcode.Text = customer.Postcode;
            txbPhone.Text = customer.Phone;
            txbEmail.Text = customer.Email;
        }
    }
}
