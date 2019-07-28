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
    /// Interaction logic for SkippedCaseView.xaml
    /// </summary>
    public partial class SkippedCaseView : Window
    {
        private Case jobOrder;
        private User user;
        public SkippedCaseView()
        {
            InitializeComponent();
        }

        public SkippedCaseView(Case jobOrder,User user)
        {
            InitializeComponent();
            this.jobOrder = jobOrder;
            this.user = user;
        }

        private void BtnSkipCase_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SkippedCaseViewModel.LogSkippedCase(jobOrder.Id, user.Id, txbDescription.Text);
            }
            catch (Exception)
            {

                throw;
            }

            this.Close();
        }
    }
}
