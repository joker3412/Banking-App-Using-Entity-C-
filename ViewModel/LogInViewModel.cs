using BankManagementSystem.Command;
using BankManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BankManagementSystem.ViewModel
{
    internal class LogInViewModel : INotifyPropertyChanged
    
    {
        private string _email;
       // private string _password;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }


        //public string Password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        _password = value;
        //        OnPropertyChanged();
        //    }
        //}

        private readonly Func<string> _password;

        public ClickCommand LoginCommand { get; set; }

        

        public LogInViewModel(Func<string> password)
        {
            LoginCommand = new ClickCommand(Login);
            _password = password;

        }

        private void Login(object parameter)
        {
            var password = _password();
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All Feilds are Required", "Empty Feild", MessageBoxButton.OK
                 , MessageBoxImage.Error);
                return;
            }

            var db = new ApplicationDbContext();
            var user = db.LogInDatas.FirstOrDefault(m => m.UserName == Email && m.Password == password);
           
            if(user == null)
            {
                MessageBox.Show("The Login Credential does not match \n please register first","LogIn Failed",
                    MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            new MainMenu().Show();
           
           var LoginWindow = (Window)parameter;
           LoginWindow.Close();
          Email =String.Empty;
          //  Password =String.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
