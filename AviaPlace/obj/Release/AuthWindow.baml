   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.AuthWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:AviaPlace     b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be772svgc1&http://sharpvectors.codeplex.com/svgc/  _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  
AuthWindow��$	��650��$	��600�� � AllowsTransparency .  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=���Z� .����  �� CornerRadius$ 15��
�������   
Background#��[  $	��0.3q�._��  � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+��� $��АвиаПлейс��$
��32pt(�$��0��$��2��$��11��$>��8pack://application:,,,/Fonts/montserrat/#Montserrat Bold)�  	Secondary#��[ $��Center=�$��Center=��� -    ��Name$ closeBtn��$��0��$��9��
���  ��	 � ToolTip$	 MaterialDesignFlatButton��  MaterialDesignFlatButton#��[ $��Bottom=�$��2��$��	54,0,0,33q�.��(  "SharpVectors.Converters.SvgViewbox  
   Source$
 \imgs\close_a.svg?�$��27���� -   $ minimizeBtn��$��0��$��8��#��[   Grey#��[ $	 MaterialDesignFlatButton��$	��Top=�$��2��$��54,0,0,0q�$��Right=�$��55��.��  $
 \imgs\minus_a.svg?�$��27���� $��2��$��2��$��7��$ 25��$��6��#��[   $
 \imgs\ic_plane.svg?�$��2��$��2��$��Center=�$��11��$��45��$��0,20,0,0q��� $ ��ВХОД В СИСТЕМУ��$��2��$��7��$��2��$��Center=�$��Center=�$
��22pt(�#��[  $+��%pack://application:,,,/Fonts/#fontick)��� $��Made by paulscriptum��  	LightGrey#��[ $A��;pack://application:,,,/Fonts/montserrat/#Montserrat Regular)�$��9��$��11��$��Center=�$��Bottom=�$��0,0,0,10q�  $/
 )\imgs\Intercontinental-transportation.svg?�$��8��$��2��$	��Top=�$��11��$	��100��$��0,5,0,0q��� -    ��Name$ loginTbx��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��$��3��$��3��  	Important#��[ #��[ $��5,0,0,0q�.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��$��5��$��2��$��35��$��Center=�$A��;pack://application:,,,/Fonts/montserrat/#Montserrat Regular)�$
��16pt(� �� 
CaretBrush# �   �� SelectionBrush# �  G� -    G�Name$ passwordTbx��$ Пароль��$��4��$��3�� # MaterialDesignRevealPasswordBox#��[ #��[ #��[ $��5,0,10,0q�$��35��$ 5��$A��;pack://application:,,,/Fonts/montserrat/#Montserrat Regular)�$
��16pt(�$��5��$��2��$��Center=� G� 
CaretBrush# �   G� SelectionBrush# �  #���  �� -   $ enterBtn��$��5��$��4��#��[  $��3��$��
ВОЙТИ��$��35��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��$��2��$
��18pt(�  Red#���  $+��%pack://application:,,,/Fonts/#fontick)�#���  �� -   $��regBtn��$��6��$��Bottom=�$��3��$��5��#��[ $��Center=�$
��16pt(�$*��$Зарегистрироваться��