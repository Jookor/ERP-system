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
    /// Interaction logic for CloseCreditCaseView.xaml
    /// </summary>
    public partial class CloseCreditCaseView : Window
    {
        private Case workorder;
        private User user;
        public CloseCreditCaseView()
        {
            InitializeComponent();
        }

        public CloseCreditCaseView(Case workorder, User user)
        {
            InitializeComponent();
            this.workorder = workorder;
            this.user = user;
        }

        private void BtnCloseCredit_Click(object sender, RoutedEventArgs e)
        {
            if (!txbCreditNote.Text.Equals(""))
            {
                try
                {
                    CloseCreditCaseViewModel.SetCreditCaseReady(workorder, user);
                    this.Close();
                    MessageBox.Show("Tilaus " + workorder.Id + " asetettu valmis-tilaan.");
                }
                catch (Exception)
                {

                    throw;
                }
            } else
            {
                MessageBox.Show("Anna hyvitysnumero!");
            }
        }
    }
}
