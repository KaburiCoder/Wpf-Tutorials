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

namespace WpfLib.Controls
{
  /// <summary>
  /// TextBoxControl.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class TextBoxControl : UserControl
  {
    #region Public Statics
    public static readonly DependencyProperty ValidatingProperty =
    DependencyProperty.Register("Validating", typeof(bool), typeof(TextBoxControl), new UIPropertyMetadata(false));
    public static new readonly DependencyProperty BorderBrushProperty =
        DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(TextBoxControl), new UIPropertyMetadata(Brushes.SkyBlue));
    public static new readonly DependencyProperty BorderThicknessProperty =
        DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(TextBoxControl), new UIPropertyMetadata(new Thickness(1)));
    public static readonly DependencyProperty WaterMarkTextProperty =
        DependencyProperty.Register("WaterMarkText", typeof(string), typeof(TextBoxControl), new PropertyMetadata(null));
    public static readonly DependencyProperty WaterMarkTextColorProperty =
        DependencyProperty.Register("WaterMarkTextColor", typeof(Brush), typeof(TextBoxControl), new UIPropertyMetadata(Brushes.Gray));
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(TextBoxControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    #endregion

    public TextBoxControl()
    {
      InitializeComponent();
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

    public string Text
    {
      get { return (string)GetValue(TextProperty); }
      set { SetValue(TextProperty, value); }
    }
    #endregion   
  }
}
