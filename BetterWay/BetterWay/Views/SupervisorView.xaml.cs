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
    /// Interaction logic for SupervisorView.xaml
    /// </summary>
    public partial class SupervisorView : UserControl
    {
        public User LoggedUser { get; set; }
        public SupervisorView()
        {
            InitializeComponent();
        }

        public SupervisorView(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void BtnUpComingCases_Click(object sender, RoutedEventArgs e)
        {
            ccSupervisorView.Content = new SupervisorComingCasesView();
        }

        private void BtnSkippedCases_Click(object sender, RoutedEventArgs e)
        {
            ccSupervisorView.Content = new SupervisorSkippedCaseView();
        }

        private void BtnReadyCases_Click(object sender, RoutedEventArgs e)
        {
            ccSupervisorView.Content = new SupervisorReadyCaseView();
        }
    }
}
