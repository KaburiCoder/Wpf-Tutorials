using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfIoC.ViewModels;

namespace WpfIoC.Stores
{
  public class MainNavigationStore : ViewModelBase
  {
    private INotifyPropertyChanged _currentViewModel;

    public INotifyPropertyChanged CurrentViewModel
    {
      get { return _currentViewModel; }
      set
      {
        _currentViewModel = value;
        CurrentViewModelChanged?.Invoke();
        _currentViewModel = null;
      }
    }

    public Action CurrentViewModelChanged { get; set; }
  }
}
