using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTutorials
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private void MVCBtn_Click(object sender, RoutedEventArgs e)
    {
      var mvcView = new DesignPatternMVC.MainView();
      _ = new DesignPatternMVC.MainController(mvcView, new DesignPatternMVC.PersonRepository());
      mvcView.Show();
    }

    public MainWindow()
    {
      InitializeComponent();
    }


  }
}
