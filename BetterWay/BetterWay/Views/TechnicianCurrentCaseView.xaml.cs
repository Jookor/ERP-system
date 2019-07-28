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
    /// Interaction logic for TechnicianCurrentCaseView.xaml
    /// </summary>
    public partial class TechnicianCurrentCaseView : Window
    {
        private Case jobOrder;
        private User user;
        public TechnicianCurrentCaseView()
        {
            InitializeComponent();
        }

        public TechnicianCurrentCaseView(Case job, User user)
        {
            InitializeComponent();
            jobOrder = job;
            this.user = user;
            this.Title = "Työtilauksen "+jobOrder.Id.ToString()+" tiedot";
        }

        private void SpInformation_Loaded(object sender, RoutedEventArgs e)
        {
            spInformation.DataContext = jobOrder;
            dgCaseLog.DataContext = TechnicianCurrentCaseViewModel.GetLogs(jobOrder.Id);
        }

        private void BtnChangeCaseInfo_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaseView view = new UpdateCaseView(jobOrder);
            view.Show();
        }

        private void BtnCloseCase_Click(object sender, RoutedEventArgs e)
        {
            /*
            TechnicianCurrentCaseViewModel.SetCaseToReadyStatus(jobOrder.Id);
            */
            SetCaseReadyView view = new SetCaseReadyView(jobOrder,user);
            view.Show();
            this.Close();
        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TechnicianCurrentCaseViewModel.SetCaseStatus(jobOrder.Id, cmbStatus.SelectedItem.ToString().Split(':')[1].Trim());
                TechnicianViewModel.LogStatusChange(jobOrder.Id, cmbStatus.SelectedItem.ToString().Split(':')[1].Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Jokin meni pieleen!/n"+ex.Message);
            }
            MessageBox.Show(cmbStatus.SelectedItem.ToString().Split(':')[1].Trim());
        }

        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            SendMessageView view = new SendMessageView(jobOrder);
            view.Show();
        }

        private void BtnOrderParts_Click(object sender, RoutedEventArgs e)
        {
            PartOrderView view = new PartOrderView(jobOrder);
            view.Show();
        }
    }
}
