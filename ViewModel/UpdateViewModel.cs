using BankManagementSystem.Command;
using BankManagementSystem.Data;
using BankManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BankManagementSystem.ViewModel
{
    internal class UpdateViewModel : INotifyPropertyChanged 
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
        private DateTime _dob;

        public DateTime Dob
        {
            get { return _dob; }
            set
            {
                _dob = value;
                OnPropertyChanged();

            }
        }
        //private string _accountType = "Savings";

        //public string AccountType
        //{
        //    get { return _accountType; }
        //    set
        //    {
        //        _accountType = value;
        //        OnPropertyChanged();
        //    }
        //}
        private Page _page;

        public ClickCommand UpdateCommand { get; set; }
        public int Id { get; set; }
        ApplicationDbContext db = new ApplicationDbContext();
        public UpdateViewModel(int id,Page page)
        {

            UpdateCommand = new ClickCommand(Update);
            _page = page;
            Id = id;
            PreviousInformation(id);


        }

        private void PreviousInformation(int id)
        {
            var user = db.AccountInformation.Find(id);

            var user1 = db.CustomerInformation.Find(user.Fk_CunstomerInformationId);

            Name = user1.Name;

            Nationality = user1.Nationality;
            Address = user1.Address;
            PhoneNumber = user1.PhoneNumber;
            Email = user1.Email;
            Occupation = user1.Occupation;
            Dob = user1.Dob;
            AccountType = user.AccountType;
        }

        private void Update(object parameter)
        {

            if (string.IsNullOrEmpty(Nationality) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(Occupation) || string.IsNullOrEmpty(PhoneNumber) ||
                string.IsNullOrEmpty(AccountType))
            {
                MessageBox.Show("All Feilds are Required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           
            if (PhoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digit", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }

            var user = db.AccountInformation.Find(Id);

            var user1 = db.CustomerInformation.Find(user.Fk_CunstomerInformationId);



                user1.Name = Name;             
                user1.Nationality = Nationality;
                user1.Address = Address;
                user1.PhoneNumber = PhoneNumber;
                user1.Email = Email;
                user1.Occupation = Occupation;
                user1.Dob = Dob;
                user.AccountType= AccountType;  
          

          
            try
            {
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            MessageBox.Show($"Changes Updated","Updated",MessageBoxButton.OK);
            
            //var page = (Window)parameter;
            //page.Close();   






        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

