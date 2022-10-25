using BankManagementSystem.Command;
using BankManagementSystem.Data;
using BankManagementSystem.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BankManagementSystem.ViewModel
{
    internal class ExistingAccountViewModel
    {
        //public ClickCommand UpdateCommand { get; set; }

        //public ClickCommand DeleteCommand { get; set; }

        //public ClickCommand DepositeCommnd  { get; set; }

        //public ClickCommand WithDrawCommand { get; set; }

        //public ClickCommand TransferCommand { get; set; }

        //public ClickCommand TransactionHistryCommand { get; set; }

        public ClickCommand ExitCommand { get; set; }

        public int Id { get; set; }
      //  private string _accountNumber;

        public string AccountNumber { get; set; }   
        //{
        //    get { return _accountNumber; }
        //    set { _accountNumber = value; }
        //}


        public ExistingAccountViewModel(int id)
        {
            //UpdateCommand = new ClickCommand(Update);
            //DeleteCommand = new ClickCommand(Delete);
            //DepositeCommnd = new ClickCommand(Deposite);
            //WithDrawCommand = new ClickCommand(Withdraw);
            //TransferCommand = new ClickCommand(Transfer);
            //TransactionHistryCommand = new ClickCommand(TransactionHistry);
            ExitCommand = new ClickCommand(Exit);
            Id = id;    
            var db = new ApplicationDbContext();
            var user = db.AccountInformation.Find(Id);
            AccountNumber = $"Account Number : {user.AccountNumber}";


            



        }

        //private void Update(object parameter)
        //{
        //    MessageBox.Show("umer");
        //    ExistingAccountOperations frame = new ExistingAccountOperations();
        //    Update page = new Update();
        //    frame.pageContainer.Navigate(page.Content);

        //}
        //private void Delete(object parameter)
        //{
        //    MessageBox.Show("Test1");
        //}
        //private void Deposite(object parameter)
        //{
        //    MessageBox.Show("Test2");
        //}
        //private void Withdraw(object parameter)
        //{
        //    MessageBox.Show("Test3");
        //}
        //private void Transfer(object parameter)
        //{
        //    MessageBox.Show("Test4");
        //}
        //private void TransactionHistry(object parameter)
        //{
        //    MessageBox.Show("Test5");
        //}
        private void Exit(object parameter)
        {

           MainMenu mn = new MainMenu();  
            mn.Show();
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

