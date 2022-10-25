using BankManagementSystem.Command;
using BankManagementSystem.Data;
using BankManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BankManagementSystem.ViewModel
{
    internal class NewAccountViewModel :INotifyPropertyChanged //, IDataErrorInfo
    
    {
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged();
            }
        }
      
      

       
    private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value;
                OnPropertyChanged();
            }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value;
                OnPropertyChanged();
            }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value;
                OnPropertyChanged();
            }
        }
        private string _email1="@gmail.com";
        public string Email1
        {
            get { return _email1; }
            set
            {
                _email1 = value;
                OnPropertyChanged();
            }
        }
        private string _occupation;
        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dob = DateTime.Now;

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value;
                OnPropertyChanged();

            }
        }

        
        // public string Gender { get; set; }  


        private int _initialDeposit;

        public int InitialDeposit
        {
            get { return _initialDeposit; }
            set { _initialDeposit = value;
                OnPropertyChanged();
            }
        }

        //private string _gender;

        //public string Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value;
        //        OnPropertyChanged();
        //    }
        //}

        private string _nationality = "Indian";

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value;
                OnPropertyChanged();
            }
        }

        private string _accountType = "Savings";

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value;
                OnPropertyChanged();
            }
        }




        private string _gender = "Male";

        public string Gender
        {
            get { return _gender; }
            set { _gender = value;
                OnPropertyChanged();
            }
        }
        public ClickCommand GenderCommand { get; set; }


        public ClickCommand NewAccountCommand { get; set; }

       // public string Error => String.Empty;

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        string result = string.Empty;
        //        switch (columnName)
        //        {
        //            case nameof(Name):
        //                if (Name.Length < 4 || Name.Length > 25)
        //                result = "\t \t \t \t \t \t \t \t Give Valid Name";
        //                break;
        //            case nameof(PhoneNumber):
        //                if (PhoneNumber.Length == 10 )
        //                    result = "\t \t \t \t \t \t \t \t Give Valid Phone number";
        //                break;
        //        }
        //        return result;
        //    }
        //}

        public NewAccountViewModel()
        {
            NewAccountCommand = new ClickCommand(NewAccount);
            GenderCommand = new ClickCommand(Gender1);
           
        }
        private void Gender1(object parameter)
        {

          Gender = parameter.ToString();


        }


        private void NewAccount(object parameter)
        {

            // MessageBox.Show(Gender);
            if (string.IsNullOrEmpty(Nationality) || string.IsNullOrEmpty(Name) ||  string.IsNullOrEmpty(Email) ||
                 string.IsNullOrEmpty(Address) ||
                 string.IsNullOrEmpty(Occupation) || string.IsNullOrEmpty(PhoneNumber) ||
                 string.IsNullOrEmpty(AccountType))
                 { 
                MessageBox.Show("All Feilds are Required","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
                 }
            if(AccountType == "Savings" && InitialDeposit <200)
            {
                MessageBox.Show("Initial Deposite should not be less than 200", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (AccountType == "Current" && InitialDeposit < 5000)
            {
                MessageBox.Show("Initial Deposite should not be less than 5000", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (PhoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digit", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }


            var db = new ApplicationDbContext();
            var user = new CustomerInformation()
            {
                Name = Name,
                Gender = Gender,
                Dob = Dob,
                Nationality = Nationality,
                Address = Address,
                PhoneNumber = PhoneNumber,
                Email = Email + Email1,
                Occupation = Occupation,
            };

            db.CustomerInformation.Add(user);
            try
            {
                db.SaveChanges();

                db.AccountInformation.Add(new AccountInformation()
                {
                    AccountNumber = user.Id+1000,
                    AccountType = AccountType,
                    Balance = InitialDeposit,
                    Fk_CunstomerInformationId = user.Id,

                });

               db.SaveChanges();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Some error occured try sometime later");
            }

            MessageBox.Show($"Account Created Successfully Number : {user.Id+1000}","Done",MessageBoxButton.OK,MessageBoxImage.Information);

      

            MainMenu mn = new MainMenu();
            mn.Show();
            var newAccount = (Window)parameter;
           newAccount.Close();


        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
