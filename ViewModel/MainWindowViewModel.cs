using BankManagementSystem.Command;
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

    internal class MainWindowViewModel
    {


        public ClickCommand NewAccountCommand { get; set; }


        public ClickCommand ViewAllCommand { get; set; }

        public ClickCommand ExistingAccountopCommand { get; set; }

        public ClickCommand LogoutCommand { get; set; }
        public MainWindowViewModel()
        {
            ExistingAccountopCommand = new ClickCommand(ExistingAccountOperations);
            NewAccountCommand = new ClickCommand(NewAccount);
            ViewAllCommand = new ClickCommand(ViewAll);
            LogoutCommand = new ClickCommand(Logout);
        }
        private void NewAccount(object parameter)
        {
            NewAccount nw = new NewAccount();
            nw.Show();

            Window pr = (Window)parameter;
            pr.Close();
        }
        private void ExistingAccountOperations(object parameter)
        {
            Search sc = new Search();
            sc.Show();
            Window mainMenu = (Window)parameter;
            mainMenu.Close();

            //Hariharan

        }
     
        private void ViewAll(object parameter)
        {
            new VIewAllAccount().Show();
            Window pr = (Window)parameter;
            pr.Close();

        }
        private void Logout(object parameter)
        {
            LogIn logOut = new LogIn();
            logOut.Show();
            Window mainMenue = (Window)parameter;
            mainMenue.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

