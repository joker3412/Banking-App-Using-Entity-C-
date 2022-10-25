using BankManagementSystem.Model;
using BankManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BankManagementSystem
{
    /// <summary>
    /// Interaction logic for VIewAllAccount.xaml
    /// </summary>
    public partial class VIewAllAccount : Window
    {

        public VIewAllAccount()
        {
            InitializeComponent();
            DataContext = new ViewAllAccountViewModel();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }
    }
}
