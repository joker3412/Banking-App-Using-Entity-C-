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
    internal class TransferViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int _ammount;

        public int Ammount
        {
            get { return _ammount; }
            set
            {
                _ammount = value;
                OnPropertyChanged();
            }
        }

        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value;
                OnPropertyChanged();
            }
        }

        public string AccountNumberSoucre;



        public ClickCommand TransferCommand { get; set; }

        public TransferViewModel(int id)
        {
            TransferCommand = new ClickCommand(Transfer);
            Id = id;
            ApplicationDbContext db = new ApplicationDbContext();
            var user = db.AccountInformation.Find(Id);
            AccountNumberSoucre = $"Source Ac : {user.AccountNumber}";


        }





        private void Transfer(object parameter)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var user = db.AccountInformation.Find(Id);
            var destiNation = db.AccountInformation.FirstOrDefault(m=>m.AccountNumber==AccountNumber);
            if(destiNation == null)
            {
                MessageBox.Show("Account Not Fount Check Again!!!", "Not Fount", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }
            if(Ammount >user.Balance)
            {
                MessageBox.Show("Insufficient Balance", "Low Balance", MessageBoxButton.OK);
                    return;
            }

            user.Balance -= Ammount;
            destiNation.Balance += Ammount;
           
            db.SaveChanges();


            var user2 = db.Transactions.Add(new Model.Transaction()
            {
                SourceAccount = user.AccountNumber,
                DestinationAccount = destiNation.AccountNumber,
                TransactionDate = DateTime.Now,
                Mode = "Transfer",
                RemainingBalance = user.Balance,
                FK_AccountNumberId = user.Id,

            }
         

            );
            db.SaveChanges();
            AccountNumber = default;
            Ammount = 0;
            MessageBox.Show($"Transfer Successful Remaining Balance = {user.Balance}", "Done"
                , MessageBoxButton.OK, MessageBoxImage.Information);
           



        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

