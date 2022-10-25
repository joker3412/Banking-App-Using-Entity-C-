using BankManagementSystem.Command;
using BankManagementSystem.Data;
using BankManagementSystem.Pages;
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
    internal class DeleteViewModel
    {
        private Window _window;

        public int Id { get; set; }

        public ClickCommand DeleteCommand { get; set; }

        public DeleteViewModel(int id,Window window)
        {
            _window = window;
            DeleteCommand = new ClickCommand(Delete);
            Id = id;
        }
       

     
        private void Delete(object parameter)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var user1 = db.AccountInformation.Find(Id);
            var user2 = db.CustomerInformation.Find(user1.Fk_CunstomerInformationId);
            var user3 = db.Transactions.Where(m =>m.FK_AccountNumberId==user1.Id);


            db.Entry(user1).State = EntityState.Deleted;
            db.Entry(user2).State = EntityState.Deleted;
            db.Entry(user1).State = EntityState.Deleted;
            db.SaveChanges();
           MessageBox.Show("Account Deleted Successfully","Delete",
               MessageBoxButton.OK,MessageBoxImage.Information);
            new MainMenu().Show();
            _window.Close();
            
             

        }

      
    }
}
