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
    /// Interaction logic for UpdateDealerView.xaml
    /// </summary>
    public partial class UpdateDealerView : Window
    {
        private Customer customer;
        public UpdateDealerView()
        {
            InitializeComponent();
        }

        public UpdateDealerView(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            txtDealerName.Text = customer.Name;
            txtDealerAddress.Text = customer.Address;
            txtDealerCity.Text = customer.City;
            txtDealerPostcode.Text = customer.Postcode;
            txtDealerPhone.Text = customer.Phone;
            txtDealerEmail.Text = customer.Email;
        }

        private void BtnUpdateDealer_Click(object sender, RoutedEventArgs e)
        {
            customer.Name = txtDealerName.Text;
            customer.Address = txtDealerAddress.Text;
            customer.City = txtDealerCity.Text;
            customer.Postcode = txtDealerPostcode.Text;
            customer.Phone = txtDealerPhone.Text;
            customer.Email = txtDealerEmail.Text;
            UpdateDealerViewModel.UpdateDealerInfo(customer);
            MessageBox.Show(customer.Name + " tiedot päivitetty");
            this.Close();
        }
    }
}
