using BankManagementSystem.Command;
using BankManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.ViewModel
{
    internal class AccountDetailViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }




        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }
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
        private string _email1;
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
            set
            {
                _occupation = value;
                OnPropertyChanged();
            }
        }

        private string _dob;

        public string Dob
        {
            get { return _dob; }
            set
            {
                _dob = value;
                OnPropertyChanged();

            }
        }


        private int _balance;

        public int Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                OnPropertyChanged();
            }
        }



        private string _nationality;

        public string Nationality
        {
            get { return _nationality; }
            set
            {
                _nationality = value;
                OnPropertyChanged();
            }
        }

        private string _accountType;

        public string AccountType
        {
            get { return _accountType; }
            set
            {
                _accountType = value;
                OnPropertyChanged();
            }
        }




        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged();
            }
        }





        public int Id { get; set; }



       
        public AccountDetailViewModel(int id)
        {

            Id = id;
            AccountDetails();
        }

        private void AccountDetails()
        {
            var db = new ApplicationDbContext();


            var user = db.AccountInformation.Find(Id);

            var user1 = db.CustomerInformation.Find(user.Fk_CunstomerInformationId);

            Name = user1.Name;

            Nationality = user1.Nationality;
            Address = user1.Address;
            PhoneNumber = user1.PhoneNumber;
            Email = user1.Email;
            Occupation = user1.Occupation;
            Dob = user1.Dob.ToString();
            AccountType = user.AccountType;
            Gender = user1.Gender;
            Balance = user.Balance;

        }










        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}


