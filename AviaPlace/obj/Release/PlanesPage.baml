   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.PlanesPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:AviaPlace       N� Title$  	UsersPage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��0��$��1��$��16��$��11��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $��Самолеты��$
��39pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $��7,7,15,0q��� -   $��AddBtn��$��10��$��8��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��  	Important#��[ #���  ��0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size$ 45X��� -   $��EditBtn��$��10��$��9��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $
 Edit=�$ 40X��� -   $��	DeleteBtn��$��10��$��10��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $ Delete=�$ 40X��� #��[ $��3��$��1��$��6��$��11��$ 10��$��50,0,0,0q�._��� -   $��AircraftList��$
��20pt(�$+��%pack://application:,,,/Fonts/#fontick)���. $��Visible=�#��[  
��������� -   $��ModelTbx��$��5��$��8��$��3��  Grey#��[ $��	0,10,0,10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Модель��$��10,0,0,0q�$
��20pt(�#��[  .  (MaterialDesignThemes.Wpf.TextFieldAssist	   TextFieldCornerRadius$	 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ 
 �� 
CaretBrush#
 �   �� SelectionBrush# �  �� -   $��CapacityTbx��$��6��$��8��$��3��$��	0,10,0,10q�#��[ $ Вместимость��$��10,0,0,0q�$
��20pt(�#��[  $	 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ #
 �  # �  �� -   $��ImgTbx��$��7��$��8��$��3��$��	0,10,0,10q�#��[ $ Изображение�� �� 
IsReadOnly . $��10,0,0,0q�$
��20pt(�#��[  $	 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ #
 �  # �  �� -   $��OpenBtn��$��7��$��7��$��75��$��Right=�$��0,0,10,0q�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $ Image=�$ 35X� � ToolTip _� $+��%Выбрать изображение��