using BankManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("Server=LAPTOP-KGTNBSR5\\SQLEXPRESS;Database=BankManageMent;Integrated Security=True")
        {

        }
        public DbSet <LogInData>LogInDatas{ get; set; }

        public DbSet<CustomerInformation> CustomerInformation { get; set; }    

        public DbSet<AccountInformation> AccountInformation { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
