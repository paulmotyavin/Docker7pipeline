   M S B A M L   `   `   `  ����   	AviaPlace    AviaPlace.SeatClassPage   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  SeatClassPage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��0��$��1��$��16��$��11��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $ ��Места и классы��$
��39pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $��7,7,15,0q��� -   $��AddBtn��$��11��$��8��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��  	Important#��[ #���  ��0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size$ 45X��� -   $��EditBtn��$��11��$��9��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $
 Edit=�$ 40X��� -   $��	DeleteBtn��$��11��$��10��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $ Delete=�$ 40X��� #��[ $��3��$��1��$��6��$��11��$ 10��$��50,0,0,0q�._��� -   $��	ItemsList��$+��%pack://application:,,,/Fonts/#fontick)�$
��20pt(���. $��Visible=�  Grey#��[ 
��������� -   $��RowsTbx�� �� 	MaxLength$ 2��$��5��$��8��$��3��#��[ $��	0,10,0,10q�)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$%	 Количество рядов��$��10,0,0,0q�$
��20pt(�#��[  .  (MaterialDesignThemes.Wpf.TextFieldAssist
   TextFieldCornerRadius$
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� 
CaretBrush# �   �� SelectionBrush# �  �� -   $��	PlacesTbx��$ 2��$��6��$��8��$��3��#��[ $��	0,10,0,10q�$#	 Количество мест��$��10,0,0,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  # �  �� -   $��PriceTbx��$ 6��$��7��$��8��$��3��#��[ $��	0,10,0,10q�$	 Cтоимость��$��10,0,0,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  # �  �� -   $��ClassCbx��$��8��$��8��$��3��$��	0,10,0,10q�#��[ $	 
Класс��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -	   $��	FlightCbx��$��9��$��8��$��3��$��	0,10,0,10q�#��[ $	 Рейс��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -
   $��RowsLeftTbk��$��Мест: 0 из 0��$��4��$��8��$��3��$��Center=�$
��32pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  