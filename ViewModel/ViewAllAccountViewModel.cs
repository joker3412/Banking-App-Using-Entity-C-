using BankManagementSystem.Data;
using BankManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.ViewModel
{
    internal class ViewAllAccountViewModel
    {
        public ObservableCollection<AccountInformation> ViewAllAccounts { get; set; }
        public ViewAllAccountViewModel()
        {
            ViewAllAccounts = new ObservableCollection<AccountInformation>();
            GetCustomerList();

        }
        private void GetCustomerList()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ViewAllAccounts.Clear();
            
            var res = db.AccountInformation.OrderBy(m => m.Id).Take(db.AccountInformation.Count());
            foreach (var item in res)
            {
                ViewAllAccounts.Add(item);
            }
        }
    }
}
