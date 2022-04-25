using System;
using System.Windows.Input;

namespace Template // Same namespace as others 
{
    public sealed class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _executeWithParameter = execute;
            _canExecuteWithParameter = canExecute;
        }

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _executeWithoutParameter = execute;
            _canExecuteWithoutParameter = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteWithParameter != null)
                return _canExecuteWithParameter(parameter);

            if (_canExecuteWithoutParameter != null)
                return _canExecuteWithoutParameter();

            return true;
        }

        public void Execute(object parameter)
        {
            if (_executeWithParameter != null)
                _executeWithParameter(parameter);
            else
                _executeWithoutParameter();

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public static void Refresh()
        {
            App.Current.Dispatcher.Invoke(CommandManager.InvalidateRequerySuggested);
        }

        private readonly Predicate<object> _canExecuteWithParameter;
        private readonly Action<object> _executeWithParameter;
        private readonly Func<bool> _canExecuteWithoutParameter;
        private readonly Action _executeWithoutParameter;
    }
}
