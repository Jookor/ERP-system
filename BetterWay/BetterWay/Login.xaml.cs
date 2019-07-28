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

namespace BetterWay
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public User LoggedUser { get; set; }
        public MainWindow main { get; set; }
        public Login()
        {
            InitializeComponent();
            main = new MainWindow();
        }

        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User LoggedUser = LoginViewModel.CheckUser(txtUser.Text, pwbPassword.Password);
                main = LoginViewModel.SetView(LoggedUser,main);
                main.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Jokin meni vikaan");
            }
        }
    }
}
