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
using BetterWay.ViewModels;

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for TechnicianView.xaml
    /// </summary>
    public partial class TechnicianView : UserControl
    {   
        public User LoggedUser { get; set; }
        private Case selected;
        public TechnicianView()
        {
            InitializeComponent();
        }
        //Constructor with User object
        public TechnicianView(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        //Show the selected case info
        private void LsvComingCases_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Set selected case to selected variable
            //selected = (Case)lsvComingCases.SelectedItem;
            //Set the selected variable to stackpanel
            spDeviceData.DataContext = selected;
        }
        
        //Update List of the cases that haven't been started yet
        private void UpdateComingList(object sender, RoutedEventArgs e)
        {
            //Sets DataTable to listview 
            //lsvComingCases.DataContext = TechnicianViewModel.GetWorkOrders("'Registered'");
            //Sets selected item to the first item
            //lsvComingCases.SelectedIndex = 0;
            selected = TechnicianViewModel.GetNextCaseInLine();
            spDeviceData.DataContext = selected;
        }
        
        //Setting case to diagnose status and show the started case
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TechnicianViewModel.SetCaseStatus(selected, "Diagnose");
            }
            catch (Exception ex)
            {

                MessageBox.Show(selected.Id.ToString() + " " + ex.Message);
            }
            TechnicianCurrentCaseView view = new TechnicianCurrentCaseView(selected, LoggedUser);
            view.Show();
            UpdateComingList(sender, e);
            //lsvComingCases.DataContext = TechnicianViewModel.GetWorkOrders("'Registered'");
            //lsvComingCases.SelectedIndex = 0;
        }
        
        //Search individual cases from database
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtCaseId.Text);
                Case job = TechnicianViewModel.GetWorkOrder(temp);
                if (job.Id == 0)
                {
                    MessageBox.Show("Keikkaa ei löydy");
                }
                else
                {
                    TechnicianCurrentCaseView view = new TechnicianCurrentCaseView(job,LoggedUser);
                    view.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe\n"+ ex.Message);
            }
        }
        
        //Gets the selected item and set it to stackpanel
        private void LsvCurrentWorkOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvCurrentWorkOrders.SelectedItem;
            spCurrentOrders.DataContext = selected;
        }
        
        //Updates the started cases list
        private void UpdateCurrentWorkOrderList(object sender, RoutedEventArgs e)
        {
            lsvCurrentWorkOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Diagnose'");
            lsvCurrentWorkOrders.SelectedIndex = 0;
        }

        private void ShowCurrentCase(object sender, RoutedEventArgs e)
        {
            TechnicianCurrentCaseView view = new TechnicianCurrentCaseView(selected,LoggedUser);
            view.Show();
        }

        private void LsvCurrentWorkOrders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowCurrentCase(sender, e);
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            lsvWaitingPartOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Waiting parts' AND PartsOnOrder>0");
            lsvWaitingPartOrders.SelectedIndex = 0;
        }

        private void LsvWaitingPartOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvWaitingPartOrders.SelectedItem;
            spWaitingParts.DataContext = selected;
        }

        private void StackPanel_Loaded_1(object sender, RoutedEventArgs e)
        {
            lsvPartsDeliveredOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Waiting parts' AND PartsOnOrder=0");
            lsvPartsDeliveredOrders.SelectedIndex = 0;
        }

        private void LsvPartsDeliveredOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvPartsDeliveredOrders.SelectedItem;
            spPartsDelivered.DataContext = selected;
        }

        private void StackPanel_Loaded_2(object sender, RoutedEventArgs e)
        {
            lsvWaitingCreditOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Waiting credit'");
            lsvWaitingCreditOrders.SelectedIndex = 0;
        }

        private void LsvWaitingCreditOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvWaitingCreditOrders.SelectedItem;
            spWaitingCredit.DataContext = selected;
        }

        private void StackPanel_Loaded_3(object sender, RoutedEventArgs e)
        {
            lsvCostEstimateOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Cost estimate'");
            lsvCostEstimateOrders.SelectedIndex = 0;
        }

        private void LsvCostEstimateOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvCostEstimateOrders.SelectedItem;
            spCostEstimate.DataContext = selected;
        }

        private void StackPanel_Loaded_4(object sender, RoutedEventArgs e)
        {
            lsvWaitingCustomerOrders.DataContext = TechnicianViewModel.GetWorkOrders("'Waiting customer'");
            lsvWaitingCustomerOrders.SelectedIndex = 0;
        }

        private void LsvWaitingCustomerOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected = (Case)lsvWaitingCustomerOrders.SelectedItem;
            spWaitingCustomer.DataContext = selected;
        }

        private void BtnSkip_Click(object sender, RoutedEventArgs e)
        {
            selected = (Case)spDeviceData.DataContext;
            SkippedCaseView view = new SkippedCaseView(selected, LoggedUser);
            view.Show();

            try
            {
                TechnicianViewModel.SetCaseStatus(selected, "Skipped");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Työtilausta ei voitu ohittaa. \n" + ex.Message);
            }

            try
            {
                UpdateComingList(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Uutta työtilausta ei voitu hakea. \n" + ex.Message);
            }
        }
    }
}
