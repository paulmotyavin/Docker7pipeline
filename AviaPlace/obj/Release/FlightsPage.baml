   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.FlightsPage   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:AviaPlace       N� Title$  FlightsPage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��0��$��1��$��16��$��11��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $��
Рейсы��$
��39pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $��7,7,15,0q��� -   $��AddBtn��$��13��$��8��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��  	Important#��[ #���  ��0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size$ 45X��� -   $��EditBtn��$��13��$��9��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $
 Edit=�$ 40X��� -   $��	DeleteBtn��$��13��$��10��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  ��  $ Delete=�$ 40X��� #��[ $��3��$��1��$��6��$��11��$ 10��$��50,0,0,0q�._��� -   $��FlightsList��$
��20pt(���. $��Visible=�#��[  
��������� -   $��	NumberTbx�� �� 	MaxLength$ 6��$��5��$��8��$��3��  Grey#��[ $��	0,10,0,10q�)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Номер рейса��$��10,0,0,0q�$
��20pt(�#��[  .  (MaterialDesignThemes.Wpf.TextFieldAssist
   TextFieldCornerRadius$
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� 
CaretBrush# �   �� SelectionBrush# �  �� -   $��DepartureCbx��$��6��$��8��$��3��$��	0,10,0,10q�#��[ $#	 Аэропорт вылета��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -   $��
ArrivalCbx��$��7��$��8��$��3��$��	0,10,0,10q�#��[ $'	 !Аэропорт прибытия��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -   $��AircraftCbx��$��10��$��8��$��3��$��	0,10,0,10q�#��[ $	 Самолет��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -	   $��AirlinesCbx��$��11��$��8��$��3��$��	0,10,0,10q�#��[ $	 Авиакомпания��$��	10,0,10,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ �� -
   $��dtTbx��$��8�� �� 
IsReadOnly . $��8��$��3��$��	0,10,0,10q�$	 Время вылета��$��10,0,0,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  # �  �� -   $��dtTbx1��$��9�� . $��8��$��3��$��	0,10,0,10q�$!	 Время прибытия��$��10,0,0,0q�$
��20pt(�#��[  $
 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  # �  �� -   $��dtBtn��$��8��$��7��$��45��$��65��#��[  #��[ #���  ��  $ Calendar=�$ 35X� � ToolTip _� $+��%Выбрать дату и время���� -   $��dt1Btn��$��9��$��7��$��45��$��65��#��[  #��[ #���  ��  $ Calendar=�$ 35X� _� $+��%Выбрать дату и время��)  #MaterialDesignThemes.Wpf.DialogHost  -     Name$ DatePickerDialogHost��   IsOpen .  $��6��$��8��   DialogContent � $��20q�.+��� $ 
Horizontal=�.+�&   System.Windows.Controls.Calendar  -     Name$ Calendar��$  MaterialDesignThemes.Wpf.Clock  -     Name$ Clock��   DisplayAutomation$ Cycle=�   	Is24Hours . �� $ 
Horizontal=�$��Right=�$��0,10,0,0q�.+���    CloseDialogCommand#��Z $��Отмена��$��5q��� -   #��Z $
��ОК��$��5q�