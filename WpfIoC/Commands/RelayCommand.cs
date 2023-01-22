using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfIoC.Commands
{
  public class RelayCommand<T> : ICommand
  {
    readonly Action<T> _execute = null;
    readonly Predicate<T> _canExecute = null;

    public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
    {
      _execute = execute ?? throw new ArgumentNullException(nameof(execute));
      _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
      return _canExecute?.Invoke((T)parameter) ?? true;
    }

    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public void Execute(object parameter)
    {
      _execute((T)parameter);
    }
  }
}
