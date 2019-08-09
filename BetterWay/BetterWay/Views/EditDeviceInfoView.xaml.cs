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
    /// Interaction logic for EditDeviceInfoView.xaml
    /// </summary>
    public partial class EditDeviceInfoView : Window
    {
        private Case editableCase;
        public EditDeviceInfoView()
        {
            InitializeComponent();
        }

        public EditDeviceInfoView(Case job)
        {
            InitializeComponent();
            editableCase = job;
            txtSerial.Text = editableCase.Serial;
            txtFault.Text = editableCase.Fault;
        }

        private void CmbBrand_Loaded(object sender, RoutedEventArgs e)
        {
            cmbBrand.ItemsSource = LogisticViewModel.GetBrands();
            cmbBrand.SelectedValue = editableCase.Brand;
        }

        private void CmbBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbModel.ItemsSource = LogisticViewModel.GetModels(cmbBrand.SelectedItem.ToString());
            cmbModel.SelectedValue = editableCase.Model;
        }

        private void AddModel_Click(object sender, RoutedEventArgs e)
        {
            AddModelView view = new AddModelView(cmbBrand.SelectedItem.ToString());
            view.Show();
        }

        private void BtnMakeChanges_Click(object sender, RoutedEventArgs e)
        {
            EditDeviceInfoViewModel.WriteChangesToDb(editableCase.Id, 
                                                    cmbBrand.SelectedItem.ToString(), 
                                                    cmbModel.SelectedItem.ToString(),
                                                    txtSerial.Text,
                                                    txtFault.Text);
            EditDeviceInfoViewModel.LogChanges(editableCase.Id);
            this.Close();
            MessageBox.Show("Muutokset tallennettu!");
        }

        private void BtnExitWithoutChanges_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
