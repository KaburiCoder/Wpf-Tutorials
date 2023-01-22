using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfIoC.Services;
using WpfIoC.Stores;

namespace WpfIoC.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    private INotifyPropertyChanged _currentViewModel;
    private readonly MainNavigationStore _mainStore;

    public INotifyPropertyChanged CurrentViewModel
    {
      get => _currentViewModel; set
      {
        _currentViewModel = value;
        OnPropertyChanged(nameof(CurrentViewModel));
      }
    }
    public MainViewModel(INavigationService navigation, MainNavigationStore mainStore)
    {
      this._mainStore = mainStore;

      mainStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
      navigation.Navigate(NavigationPlace.LoginView);
    }

    private void OnCurrentViewModelChanged()
    {
      CurrentViewModel = _mainStore.CurrentViewModel;
    }
  }
}
