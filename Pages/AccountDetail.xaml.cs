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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankManagementSystem.Pages
{
    /// <summary>
    /// Interaction logic for AccountDetail.xaml
    /// </summary>
    public partial class AccountDetail : Page
    {
        public AccountDetail(int id)
        {
            InitializeComponent();
            DataContext = new AccountDetailViewModel(id);
        }
    }
}
