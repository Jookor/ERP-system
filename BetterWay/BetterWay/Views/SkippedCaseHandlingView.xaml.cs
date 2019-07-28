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
    /// Interaction logic for SkippedCaseHandlingView.xaml
    /// </summary>
    public partial class SkippedCaseHandlingView : Window
    {
        private int id;
        public SkippedCaseHandlingView()
        {
            InitializeComponent();
        }

        public SkippedCaseHandlingView(int id)
        {
            InitializeComponent();
            this.id = id;
            this.Title = $"Työtilauksen {id} käsittely";
        }

        private void BtnResetCaseStatus_Click(object sender, RoutedEventArgs e)
        {
            SkippedCaseHandlingViewModel.ResetCaseStatus(id);
            this.Close();
        }

        private void BtnDeleteCase_Click(object sender, RoutedEventArgs e)
        {
            SkippedCaseHandlingViewModel.DeleteCase(id);
            this.Close();
        }
    }
}
