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
    /// Interaction logic for SetCaseReadyView.xaml
    /// </summary>
    public partial class SetCaseReadyView : Window
    {
        private Case jobOrder;
        private User user;
        public SetCaseReadyView()
        {
            InitializeComponent();
        }

        public SetCaseReadyView(Case jobOrder, User user)
        {
            InitializeComponent();
            this.jobOrder = jobOrder;
            this.user = user;
        }

        private void BtnSetCaseReady_Click(object sender, RoutedEventArgs e)
        {
            SetCaseReadyViewModel.SetCaseToReadyStatus(jobOrder.Id, user.Id, txbDescription.Text);
            this.Close();
            MessageBox.Show($"Keikka {jobOrder.Id} asetettu valmis-tilaan");
        }
    }
}
