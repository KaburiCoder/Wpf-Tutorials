using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfIoC.Commands;
using WpfIoC.Services;
using WpfIoC.ViewModels;

namespace WpfIoC.ViewModels
{
  public class SignupViewModel : ViewModelBase
  {
    private readonly INavigationService _navigation;

    public SignupViewModel(INavigationService navigation)
    {
      this._navigation = navigation;

      ToLoginCommand = new RelayCommand<object>((_)=> { navigation.Navigate(NavigationPlace.LoginView); });
    }

    public ICommand ToLoginCommand { get; set; }
  }
}
