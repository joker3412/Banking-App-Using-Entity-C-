using BankManagementSystem.Command;
using BankManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagementSystem.ViewModel
{
    internal class SearchViewModel: INotifyPropertyChanged  
    {

        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value;
                OnPropertyChanged();
            }
        }

        public ClickCommand SearchCommand { get; set; }

        public SearchViewModel()
        {

            SearchCommand = new ClickCommand(Search);
        }

        private void Search(object parameter)
        {
            var db = new ApplicationDbContext();
            var user = db.AccountInformation.FirstOrDefault(m => m.AccountNumber == AccountNumber);
            if (user == null)
            {
                MessageBox.Show("Account Not Found Try Again or Open....", "Not Found",
                    MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }
            new ExistingAccountOperations(user.Id).Show();
            Window pr = (Window)parameter;
            pr.Close();



        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

