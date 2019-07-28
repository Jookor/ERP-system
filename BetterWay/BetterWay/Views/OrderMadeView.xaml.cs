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
    /// Interaction logic for OrderMadeView.xaml
    /// </summary>
    public partial class OrderMadeView : Window
    {
        private int user;
        private Case workorder;
        private CasePrintView cpv;
        public OrderMadeView()
        {
            InitializeComponent();
        }

        public OrderMadeView(int id,Case workorder)
        {
            InitializeComponent();
            user = id;
            this.workorder = workorder;
        }

        private void TxbCaseNumber_Loaded(object sender, RoutedEventArgs e)
        {
            workorder.Id = OrderMadeViewModel.GetCaseNumber(user);
            txbCaseNumber.Text = workorder.Id.ToString();
            cpv = new CasePrintView(user, workorder);
            ccPrint.Content = cpv;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printdlg = new PrintDialog();
            printdlg.PrintVisual(cpv,"Workorder printing");
        }
    }
}
