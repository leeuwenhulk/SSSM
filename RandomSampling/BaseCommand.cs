using System;
using System.Windows.Input;

namespace RandomSampling
{
    class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public BaseCommand(Action<object> doExecute)
        {
            DoExecute = doExecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }

        public Action<object> DoExecute;
    }
}
