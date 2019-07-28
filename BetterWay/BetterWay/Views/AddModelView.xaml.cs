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

namespace BetterWay.Views
{
    /// <summary>
    /// Interaction logic for AddModelView.xaml
    /// </summary>
    public partial class AddModelView : Window
    {
        private string brand;
        public AddModelView()
        {
            InitializeComponent();
        }

        public AddModelView(string brand)
        {
            InitializeComponent();
            this.brand = brand;
        }

        private void BtnAddModel_Click(object sender, RoutedEventArgs e)
        {
            string model = txbModel.Text;
            string category = cmbCategory.SelectedItem.ToString();
            MessageBox.Show(category+" "+model+" "+brand);
            AddModelViewModel.AddModel(model, brand, category);
            this.Close();
        }

        private void CmbCategory_Loaded(object sender, RoutedEventArgs e)
        {
            cmbCategory.ItemsSource = AddModelViewModel.GetCategory();
        }
    }
}
