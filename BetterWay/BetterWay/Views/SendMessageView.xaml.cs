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
    /// Interaction logic for SendMessageView.xaml
    /// </summary>
    public partial class SendMessageView : Window
    {
        private Case jobOrder;
        private Customer customer;
        private bool isCustomer;
        private Customer dealer;
        private bool isDealer;
        public SendMessageView()
        {
            InitializeComponent();
        }

        public SendMessageView(Case jobOrder)
        {
            InitializeComponent();
            this.jobOrder = jobOrder;
            customer = SendMessageViewModel.GetCustomerInfo(jobOrder.ClientId);
            dealer = SendMessageViewModel.GetCustomerInfo(jobOrder.DealerId);
            spCustomerInfo.DataContext = customer;
            spDealerInfo.DataContext = dealer;
        }

        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            if(isCustomer)
            {
                MessageBox.Show("Asiakkaalle");
            }

            if(isDealer)
            {
                MessageBox.Show("Jällärille");
            }

            if(!isDealer && !isCustomer)
            {
                MessageBox.Show(this, "Valitse asiakas tai jälleenmyyjä");
            }

            isCustomer = false;
            isDealer = false;
        }

        private void CbCustomer_Checked(object sender, RoutedEventArgs e)
        {
            isCustomer = true;
        }

        private void CbDealer_Checked(object sender, RoutedEventArgs e)
        {
            isDealer = true;
        }
    }
}
