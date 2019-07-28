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
using BetterWay.ViewModels;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for SupervisorReadyCaseView.xaml
    /// </summary>
    public partial class SupervisorReadyCaseView : UserControl
    {
        public SupervisorReadyCaseView()
        {
            InitializeComponent();
        }

        private void LsvReadyCases_Loaded(object sender, RoutedEventArgs e)
        {
            lsvReadyCases.DataContext = TechnicianViewModel.GetWorkOrders("'Ready'");
        }
    }
}
