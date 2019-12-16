using System;
using System.Windows.Input;

namespace MilkTeaManager.ViewModels
{
    internal class DelegateCommand : ICommand
    {
        private object doSomething;
        private object canDoSomething;

        public DelegateCommand(object doSomething, object canDoSomething)
        {
            this.doSomething = doSomething;
            this.canDoSomething = canDoSomething;
        }

        public DelegateCommand(Action<object> doSomething, Func<object, bool> canDoSomething)
        {
            this.doSomething = doSomething;
            this.canDoSomething = canDoSomething;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}