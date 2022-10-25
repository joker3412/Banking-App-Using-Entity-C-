using BankManagementSystem.Command;
using BankManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagementSystem.ViewModel
{
    internal class DepositViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value;
                OnPropertyChanged();   }
        }


        public ClickCommand DepositCommand { get; set; }

        public DepositViewModel(int id)
        {
            DepositCommand = new ClickCommand(Deposit);
            Id = id;

        }

      



        private void Deposit(object parameter)
        {
            try
            {

                if(Amount > 20000)
                {
                    MessageBox.Show("Limit Exceeded \n limit is 20000 At a time", "Limit");
                    return; 
                }
                ApplicationDbContext db = new ApplicationDbContext();
                var user = db.AccountInformation.Find(Id);
                user.Balance += Amount;
                Amount = 0 ;

                db.SaveChanges();

                var user2 = db.Transactions.Add(new Model.Transaction()
                {
                    SourceAccount = user.AccountNumber,
                    DestinationAccount = user.AccountNumber,
                    TransactionDate = DateTime.Now,
                    Mode = "Deposit",
                    RemainingBalance = user.Balance,
                    FK_AccountNumberId = user.Id,

                });
                db.SaveChanges();

               

                MessageBox.Show($"Transaction Sussessful And Balance = {user.Balance}", "Done"
               , MessageBoxButton.OK, MessageBoxImage.Information);
                Amount = default;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.StackTrace);
            }
           
               


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
