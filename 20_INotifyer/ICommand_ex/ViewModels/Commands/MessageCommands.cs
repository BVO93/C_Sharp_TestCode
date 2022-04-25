using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommand_ex.ViewModels.Commands
{
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        // WITHOUT parameter
        private Action _execute;

        // WITH parameter// private Action<string> _execute;

        //WITHOUT parameter 
        public MessageCommand(Action execute)
        // WITH Paramaeter // public MessageCommand(Action<string> execute)
        {
            _execute = execute;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // WITHOUT parameter

            _execute.Invoke();

            // WITH Paramaeter //  _execute.Invoke(parameter as string);


        }

    }
}
