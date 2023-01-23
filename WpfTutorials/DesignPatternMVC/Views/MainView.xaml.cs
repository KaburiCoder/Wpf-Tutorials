using System.Collections;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorials.DesignPatternMVC
{
  /// <summary>
  /// BaseView.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainView : Window, IMainView
  {
    private MainController _controller = default!;

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      if (_controller.Save())
      {
        _controller.Cancel();
        _controller.DisplayItemsToListView();
      }
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      if (_controller.Delete())
      {
        _controller.Cancel();
        _controller.DisplayItemsToListView();
      }
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      _controller.Cancel();
    }

    public MainView()
    {
      InitializeComponent();
    }

    public int Id
    {
      get
      {
        int.TryParse(txtId.Text.Trim(), out int id);
        return id;
      }
      set => txtId.Text = value == 0 ? "" : value.ToString();
    }
    string IMainView.Name { get => txtName.Text.Trim(); set => txtName.Text = value; }

    public string Sex { get => txtSex.Text.Trim(); set => txtSex.Text = value; }

    public int Age
    {
      get
      {
        int.TryParse(txtAge.Text.Trim(), out int age);
        return age;
      }
      set => txtAge.Text = value == 0 ? "" : value.ToString();
    }

    public IEnumerable ItemsSource { get => lstView.ItemsSource; set => lstView.ItemsSource = value; }

    public void SetController(MainController controller)
    {
      this._controller = controller;
    }

    private void ListViewItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
      FrameworkElement? element = (FrameworkElement)e.OriginalSource;

      _controller.LoadPerson(element.DataContext);
    }
  }
}
