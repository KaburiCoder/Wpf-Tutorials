   M S B A M L   `   `   `  ����A  =WpfLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfLib.ControlsWpfLib.Controls  5      5clr-namespace:WpfLib.ConvertersWpfLib.Converters  5      /clr-namespace:WpfLib.CommonsWpfLib.Commons  5      %    WpfLib.Controls.ComboBoxControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfLib.Controls     5      6
convertersclr-namespace:WpfLib.Converters     5      0commonsclr-namespace:WpfLib.Commons     5      -   5        $
��root��5
        � 	Resources  5      6   0WpfLib.Converters.ValidatingBorderBrushConverter "  ValidatingBorderBrushConverter:   4WpfLib.Converters.ValidatingBorderThicknessConverter & "ValidatingBorderThicknessConverter  BaseControl �� 
TargetType �� Property �� Value �� ElementName �� BasedOn �� Triggers �� Binding �� Value	 �� UpdateSourceTrigger)   #WpfLib.Commons.ComboBoxColorManager
 `� 	Converter �� Path��%�  &	        &	      &	 &     '�� �     7  '�� �    7  '�� �    7  7     5      60     5      64   �� 5      " �6    .�5      ��  � �� 6+   �� *
FontSize+$
 root���� 5       � �� 6-   �� *
FontFamily+$
 root��5      �� 5      " ��6   8   .�5      ��  � �� 6   �� *WaterMarkText+$
 root���� 5       � �� 6%   �� *WaterMarkTextColor+$
 root���� 5       �@��Padding$ 5 0 0 0q�6"   �� 5       � ��$
 Left=�6.   �� 5       � ��$ Center=�6,   �� 5       � y�$ 	Collapsed=�6%    5      �� 5   
    6   �� *Text+$	 cmb��  6@   .a�5      ��  � y�$ Visible=�6)   5      5!      �� 5#      " ��6   8   .�5$      ��  � ��$ Center=�63   �� 5%       �@��
IsEditable 6%   �� *
IsEditable+$
 root���� 5&       �@��Text 6   �� *Text+$
 root��$	 PropertyChanged=��� 5'       �@��SelectedItem 6'   �� *SelectedItem+$
 root���� 5(       �@��SelectedIndex 6(   �� *SelectedIndex+$
 root���� 5)       � �� 6&   �� *ItemsSource+$
 root���� 5*       � �� 6-   �� *ItemContainerStyle+$
 root���� 5+       �@ 
Background
 ���� 6B   �� 5,       � ��$ 0q�6*   5-      �� 5/      " ��6   .�50      ��  � �� 51   
   `� 52      8
   .1�53      �� $ 
Validating�6   $
 root��6(   �� 54      $ BorderThickness�6   $
 root��6-   55      57   	   �� 59       � �� 5:   
   `� 5;      8
  .1�5<      �� $ 
Validating�6   $
 root��6(   �� 5=      $ BorderBrush�6   $
 root��6)   5>      5@   	   5A      5B      .��5C      � .+�5D      �� -   5         ��Name$	 txt��5D      �� 5E      ._�5F      �� -   5         ��Name$	 cmb��5F      5G      5H      5I      