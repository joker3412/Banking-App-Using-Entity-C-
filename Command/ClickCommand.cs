using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankManagementSystem.Command
{
    internal class ClickCommand : ICommand
    {
        private readonly Action<object> _handler;

        public event EventHandler CanExecuteChanged;

        public ClickCommand(Action<object> handler) => _handler = handler;

        public ClickCommand()
        {
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _handler(parameter);
    }
}
