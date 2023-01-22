using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfLib.Controls
{
  /// <summary>
  /// PasswordBoxControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class PasswordBoxControl : UserControl
  {
    #region Fields
    private bool _isFirst = true;
    #endregion

    #region Methods
    private void Pwd_PasswordChanged(object sender, RoutedEventArgs e)
    {
      Password = pwd.Password;
    }

    private void Txt_TextChanged(object sender, TextChangedEventArgs e)
    {
      if (_isFirst || DesignerProperties.GetIsInDesignMode(this))
      {
        if ( pwd.Password != txt.Text)
          pwd.Password = txt.Text;

        _isFirst = false;
      }
    }
    #endregion

    #region Public Statics
    public static readonly DependencyProperty ValidatingProperty =
    DependencyProperty.Register("Validating", typeof(bool), typeof(PasswordBoxControl), new UIPropertyMetadata(false));
    public static new readonly DependencyProperty BorderBrushProperty =
        DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(PasswordBoxControl), new UIPropertyMetadata(Brushes.SkyBlue));
    public static new readonly DependencyProperty BorderThicknessProperty =
        DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(PasswordBoxControl), new UIPropertyMetadata(new Thickness(1)));
    public static readonly DependencyProperty WaterMarkTextProperty =
        DependencyProperty.Register("WaterMarkText", typeof(string), typeof(PasswordBoxControl), new PropertyMetadata(null));
    public static readonly DependencyProperty WaterMarkTextColorProperty =
        DependencyProperty.Register("WaterMarkTextColor", typeof(Brush), typeof(PasswordBoxControl), new UIPropertyMetadata(Brushes.Gray));
    public static readonly DependencyProperty PasswordProperty =
        DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    #endregion

    public PasswordBoxControl()
    {
      InitializeComponent();

      txt.TextChanged += Txt_TextChanged;
      pwd.PasswordChanged += Pwd_PasswordChanged;
    }

    #region Public Properties
    public bool Validating
    {
      get { return (bool)GetValue(ValidatingProperty); }
      set { SetValue(ValidatingProperty, value); }
    }

    public new Brush BorderBrush
    {
      get { return (Brush)GetValue(BorderBrushProperty); }
      set { SetValue(BorderBrushProperty, value); }
    }

    public new Thickness BorderThickness
    {
      get { return (Thickness)GetValue(BorderThicknessProperty); }
      set { SetValue(BorderThicknessProperty, value); }
    }

    public string WaterMarkText
    {
      get { return (string)GetValue(WaterMarkTextProperty); }
      set { SetValue(WaterMarkTextProperty, value); }
    }

    public Brush WaterMarkTextColor
    {
      get { return (Brush)GetValue(WaterMarkTextColorProperty); }
      set { SetValue(WaterMarkTextColorProperty, value); }
    }

    public string Password
    {
      get { return (string)GetValue(PasswordProperty); }
      set { SetValue(PasswordProperty, value); }
    }
    #endregion   
  }
}
