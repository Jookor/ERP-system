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
    /// Interaction logic for ReceivePartView.xaml
    /// </summary>
    public partial class ReceivePartView : Window
    {
        private Part part;
        private Case workOrder;
        public ReceivePartView()
        {
            InitializeComponent();
        }

        public ReceivePartView(Part part)
        {
            InitializeComponent();
            this.part = part;
            spReceivePart.DataContext = part;
            workOrder = TechnicianViewModel.GetWorkOrder(part.CaseId);
        }

        private void BtnReceivePart_Click(object sender, RoutedEventArgs e)
        {
            //Täytyy vielä saada päivittymään WorkOrder tauluun keikan kohdalle
            //Päivittyy nyt vain Partorders tauluun
            try
            {
                ReceivePartViewModel.SetReceived(part, workOrder);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Varaosa vastaanotettu");
            this.Close();
            
        }
    }
}
