using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfIoC.Stores;
using WpfIoC.ViewModels;

namespace WpfIoC.Services
{
  public class NavigationService : INavigationService
  {
    private readonly MainNavigationStore mainNaviStore;

    public NavigationService(MainNavigationStore mainNaviStore)
    {
      this.mainNaviStore = mainNaviStore;
    }
    public void Navigate(NavigationPlace place)
    {
      switch (place)
      {
        case NavigationPlace.LoginView:
          mainNaviStore.CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(LoginViewModel));
          break;
        case NavigationPlace.SignupView:
          mainNaviStore.CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(SignupViewModel));
          break;
        default:
          break;
      }
    }
  }
}
