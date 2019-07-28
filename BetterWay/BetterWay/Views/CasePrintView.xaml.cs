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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BetterWay.Models;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for CasePrintView.xaml
    /// </summary>
    public partial class CasePrintView : UserControl
    {
        private Case workorder;
        private int id;
        public CasePrintView()
        {
            InitializeComponent();
        }

        public CasePrintView(int id,Case workorder)
        {
            InitializeComponent();
            this.workorder = workorder;
            this.id = id;
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            txbCaseNumber.Text = workorder.Id.ToString();
            txbDevice.Text = workorder.Brand + " " + workorder.Model;
            txbSerial.Text = workorder.Serial;
            txbFault.Text = workorder.Fault;
        }
    }
}
