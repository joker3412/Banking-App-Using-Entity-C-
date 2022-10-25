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
    internal class WithdrawViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }


        public ClickCommand WithdrawCommand { get; set; }

        public WithdrawViewModel(int id)
        {
            WithdrawCommand = new ClickCommand(Withdraw);
            Id = id;

        }





        private void Withdraw(object parameter)
        {

            ApplicationDbContext db = new ApplicationDbContext();
            var user = db.AccountInformation.Find(Id);
            int blc = user.Balance;
            if(user.AccountType == "Current")
            {
                blc -= 5000;
            }
            if ( Amount > blc )
            {
                MessageBox.Show("Insufficient Balance or \n Exceeded minimum balance ", "Low Balance", MessageBoxButton.OK);
                return;
            }

            user.Balance -= Amount;

            db.SaveChanges();

            var user2 = db.Transactions.Add(new Model.Transaction()
            {
                SourceAccount = user.AccountNumber,
                DestinationAccount = user.AccountNumber,
                TransactionDate = DateTime.Now,
                Mode = "WithDraw",
                RemainingBalance = user.Balance,
                FK_AccountNumberId = user.Id,

            });

           
            db.SaveChanges();
            MessageBox.Show($"Withdrawal Successful And Balance = {user.Balance}", "Done"
                , MessageBoxButton.OK, MessageBoxImage.Information);
             Amount = default;




        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

