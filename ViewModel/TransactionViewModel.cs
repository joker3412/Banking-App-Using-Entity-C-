using BankManagementSystem.Command;
using BankManagementSystem.Data;
using BankManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagementSystem.ViewModel
{
    internal class TransactionViewModel

    { 
        public ObservableCollection<Transaction> Transactions { get; set; } 
       
     

      // public  List<Transaction> Transactions { get; set; }
        public TransactionViewModel(int id)
        {
            Transactions = new ObservableCollection<Transaction>();

            ApplicationDbContext db = new ApplicationDbContext();
            var user = db.AccountInformation.Find(id);
            
            var res = db.Transactions.Where(m=>m.FK_AccountNumberId== user.Id).Take(100);
            foreach (var item in res)
            {
                Transactions.Add(item); 

            }            
           //Transactions = db.Transactions.Where(m => m.FK_AccountNumberId == user.AccountNumber).ToList();

        }

    }
}
