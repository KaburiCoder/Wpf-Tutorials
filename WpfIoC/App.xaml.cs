using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfIoC.Services;
using WpfIoC.Stores;
using WpfIoC.ViewModels;
using WpfIoC.Views;

namespace WpfIoC
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private static IServiceProvider ConfigureServices()
    {
      var services = new ServiceCollection();

      // Navigation
      services.AddSingleton<MainNavigationStore>();
      services.AddSingleton<INavigationService, NavigationService>();

      // ViewModels
      services.AddSingleton<MainViewModel>();
      services.AddTransient<LoginViewModel>();
      services.AddTransient<SignupViewModel>();


      // Views
      //services.AddSingleton<LoginView>();
      //services.AddTransient<SignupView>();
      services.AddSingleton(s => new MainView()
      {
        DataContext = s.GetRequiredService<MainViewModel>()
      });


      return services.BuildServiceProvider();
    }

    public App()
    {
      Services = ConfigureServices();
      var mainView = Services.GetRequiredService<MainView>();
      mainView.Show();
    }

    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }


  }
}
