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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            DataContext = new RegistrationViewModel(GetPassword);
        }
        private string GetPassword()
        {
            if(txtCinfirmPassword.Password == null|| txtCinfirmPassword.Password ==null|| txtCinfirmPassword.Password == "" || txtCinfirmPassword.Password == "")
            {
                return null;
            }
            if (txtPassword.Password != txtCinfirmPassword.Password)
            {
                txtPassword.Password = String.Empty;
                txtCinfirmPassword.Password = String.Empty;
                return "Distinct";
              
            }
            return txtPassword.Password;
        }

        public void FocusEmail()
        {
            UserName.Focus();
        }

       
        
    } 
}

    


