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
    /// Interaction logic for PartOrderView.xaml
    /// </summary>
    public partial class PartOrderView : Window
    {
        private Case jobOrder;
        public PartOrderView()
        {
            InitializeComponent();
        }

        public PartOrderView(Case job)
        {
            InitializeComponent();
            jobOrder = job;
        }
        private void DgOrderedparts_Loaded(object sender, RoutedEventArgs e)
        {
            dgOrderedparts.DataContext = PartOrderViewModel.GetPartOrderLogs(jobOrder.Id);
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PartOrderViewModel.MakePartOrder(jobOrder.Id, txbPartnumber.Text, Convert.ToInt32(txbQuantity.Text), (jobOrder.NumberOfOrderedParts + Convert.ToInt32(txbQuantity.Text)));
            }
            catch (Exception)
            {

                throw;
            }
            DgOrderedparts_Loaded(sender, e);
            jobOrder.NumberOfOrderedParts += Convert.ToInt32(txbQuantity.Text);
        }
    }
}
