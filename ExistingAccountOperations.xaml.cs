using BankManagementSystem.Pages;
using BankManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankManagementSystem
{
    /// <summary>
    /// Interaction logic for ExistingAccountOperations.xaml
    /// </summary>
    public partial class ExistingAccountOperations : Window
    {
        public int Id { get; set; }
        public ExistingAccountOperations(int id)
        {
            InitializeComponent();
            DataContext = new ExistingAccountViewModel(id);
            Id = id;


        }
        //public ExistingAccountOperations()
        //{

        //}

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Update up = new Update(Id);
            pageContainer.Content =up.Content;

        }

        private void Transaction_Click(object sender, RoutedEventArgs e)
        {
           
            TransactionHistory th = new TransactionHistory(Id);
            pageContainer.Content = th.Content;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Delete dt = new Delete(Id,this);
            pageContainer.Content = dt.Content;
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            Deposit dp = new Deposit(Id);
            pageContainer.Content = dp.Content;
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            Withdraw wp = new Withdraw(Id);
            pageContainer.Content = wp.Content;
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            pageContainer.Content = new Transfer(Id).Content;
        }

        private void AccountDetail_Click(object sender, RoutedEventArgs e)
        {
            pageContainer.Content = new AccountDetail(Id).Content;
        }





        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    //Update up = new Update();
        //    //pageContainer.Content =up.Content;
        //}
    }
}
