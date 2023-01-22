using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfIoC.Commands;
using WpfIoC.Services;

namespace WpfIoC.ViewModels
{
  public class LoginViewModel : ViewModelBase
  {
    private readonly INavigationService _navigation;
    private string _testText;
    public LoginViewModel(INavigationService navigation)
    {
      _navigation = navigation;

      ToSignupCommand = new RelayCommand<object>((_)=> navigation.Navigate(NavigationPlace.SignupView));
    }

    public ICommand ToSignupCommand { get; set; }
    public string TestText { get=> _testText; set
      {
        _testText = value;
        OnPropertyChanged(nameof(TestText));
      }
    }
  }
}
