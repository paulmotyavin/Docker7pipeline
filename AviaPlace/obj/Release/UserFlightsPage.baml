   M S B A M L   `   `   `  ����   	AviaPlace    AviaPlace.UserFlightsPage   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  UserFlightsPage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� ��  � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��0��$��1��$��16��$��11��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $��
Рейсы��$
��39pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $��7,7,15,0q��� -   $��
FindFlight��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��$��2��$��2��$��5q�$
��15pt(�#��[  .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 15��$��5,0,0,0q��� -   $��FindDeparture�� �� 
IsEditable . $ 
Вылет��$��2��$��3��$��5q�$
��15pt(�#��[  $ 15��$��5,0,0,0q��� -   $��FindArrival�� . $ Прилет��$��2��$��4��$��5q�$
��15pt(�#��[  $ 15��$��5,0,0,0q��� -   $��
PriceAfter��$ Цена от��$��2��$��5��$��5q�$
��15pt(�#��[  $ 15��$��5,0,0,0q��� -   $��PriceBefore��$ Цена до��$��2��$��6��$��5q�$
��15pt(�#��[  $ 15��$��5,0,0,0q�(  "System.Windows.Controls.DatePicker  -   $��DepartureDatePicker��$ Дата вылета��$��2��$��7��$��2��$��5q�$
��15pt(�#��[  #��[  $ 15���� -   $��SortComboBox��$! Сортировать по��$��2��$��9��$��2��$��5q�$
��15pt(�#��[  $ 15��$��5,0,0,0q�.@��� $'��!Цена (возрастание)��
 � Tag$ PriceAsc���� $!��Цена (убывание)��$ 	PriceDesc���� $7��1Длительность (возрастание)��$ DurationAsc���� $1��+Длительность (убывание)��$ DurationDesc����   	Important#��[ $��3��$��1��$��10��$��12��$ 10��$��50,0,0,0q�._��� -   $��FlightsList��$
��20pt(���. $��Visible=�#��[  
�������