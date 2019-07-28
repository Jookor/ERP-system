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

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for UpdateCaseView.xaml
    /// </summary>
    public partial class UpdateCaseView : Window
    {
        private Case order;
        public UpdateCaseView()
        {
            InitializeComponent();
        }

        public UpdateCaseView(Case job)
        {
            InitializeComponent();
            order = job;
        }

        private void SpEditCase_Loaded(object sender, RoutedEventArgs e)
        {
            spEditCase.DataContext = order;
        }

        private void BtnEditDevice_Click(object sender, RoutedEventArgs e)
        {
            EditDeviceInfoView view = new EditDeviceInfoView(order);
            view.Show();
        }

        private void BtnEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            EditCustomerInfoView view = new EditCustomerInfoView(order,"customer");
            view.Show();
        }

        private void BtnEditDealer_Click(object sender, RoutedEventArgs e)
        {
            EditCustomerInfoView view = new EditCustomerInfoView(order, "dealer");
            view.Show();
        }
    }
}
