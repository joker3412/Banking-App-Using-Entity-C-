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
using BankManagementSystem;

namespace BankManagementSystem.ViewModel
{
    internal class RegistrationViewModel : INotifyPropertyChanged
    {
       

        private string _email;
      

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private readonly Func<string> _password;

        public ClickCommand RegisterCommand { get; set; }

        public RegistrationViewModel(Func<string> password)
        {
            RegisterCommand = new ClickCommand(Register);
            _password = password;   
        }

        private void Register(object parameter)
        {
            var password = _password(); 
            var db = new ApplicationDbContext();
          if(string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All Feilds are Required", "Empty Feild", MessageBoxButton.OK
                  , MessageBoxImage.Error);
                Email = String.Empty;
               
                return;
            }
            if (!Regex.IsMatch(Email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter valid Email", "Valid Mail", MessageBoxButton.OK);
                return;

            }
            if (password == "Distinct")
            {
                MessageBox.Show("PassWord Should be Same","Password Error",MessageBoxButton.OK
                    ,MessageBoxImage.Error);
                Email = String.Empty;
                
                return;
            }
            if(db.LogInDatas.Any(m=>m.UserName==Email))
            {
                MessageBox.Show("Email Already registered","Registered user",MessageBoxButton.OK);  
                return ;
            }
          
            db.LogInDatas.Add(new LogInData()
            {
              UserName =Email,
              Password =password,   
            });
            db.SaveChanges();
            MessageBox.Show("Registered Successfully" ,"User Saved",MessageBoxButton.OK,MessageBoxImage.Information);

            LogIn Log = new LogIn();
             Log .Show();
            var RegistrationWindow = (Window)parameter;
            RegistrationWindow.Close();
            Email = String.Empty;
          


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
