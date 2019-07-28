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
using BetterWay.Models;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for SupervisorSkippedCaseView.xaml
    /// </summary>
    public partial class SupervisorSkippedCaseView : UserControl
    {
        public SupervisorSkippedCaseView()
        {
            InitializeComponent();
        }

        private void LsvSkippedCases_Loaded(object sender, RoutedEventArgs e)
        {
            lsvSkippedCases.DataContext = SupervisorViewModel.GetSkippedCases();
        }

        private void LsvSkippedCases_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int caseId = Convert.ToInt32(lsvSkippedCases.SelectedItem.ToString().Split(',')[0]);
            SkippedCaseHandlingView view = new SkippedCaseHandlingView(caseId);
            view.Show();
        }
    }
}
