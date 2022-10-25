using BankManagementSystem.Data;
using BankManagementSystem.ViewModel;
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

namespace BankManagementSystem
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
            DataContext = new LogInViewModel(GetPassword);
           
        }

        private string GetPassword()
        {
            return txtPassword.Password;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationDbContext();
            if (!db.LogInDatas.Any())
            {
               
                var res = new Registration();
                res.Show();
                this.Close();
            }       
        }

        private void btnRegisterLink_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(); 
            registration.Show();
            this.Close();
        }
    }
}
