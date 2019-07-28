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

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for AddDealerView.xaml
    /// </summary>
    public partial class AddDealerView : Window
    {
        public AddDealerView()
        {
            InitializeComponent();
        }

        private void BtnAddDealer_Click(object sender, RoutedEventArgs e)
        {
            AddDealerViewModel.AddDealer(txbDealer.Text, txbAddress.Text, txbCity.Text, txbPostcode.Text, txbPhone.Text, txbEmail.Text);
            MessageBox.Show(txbDealer.Text + " lisätty tietokantaan");
            this.Close();
        }
    }
}
