   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.AdminWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  :d2http://schemas.microsoft.com/expression/blend/2008  b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be772svgc1&http://sharpvectors.codeplex.com/svgc/  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  #localclr-namespace:AviaPlace    � Title$  AdminWindow��$	��768��$
��1366�� � WindowStyle$
 None=� � WindowState$ 	Maximized=� � AllowsTransparency . ��Z� .����  �� CornerRadius$ 15��
�������   
Background#��[  $	��0.3q�._��  � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� ��  � RowDefinitions �� $��40 ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� .+�]� 
������ $��0��$��0��$��12��$��40��.+��� $#��АвиаПлейс.Админ��  Grey#��[ $��30��$��15,7,0,0q�$+��%pack://application:,,,/fonts/#fontick)�$
��18pt(�$	��Top=��� $��0�����	#00ffffff$��25��$��0��$��12��$��Right=�$��0,7,10,0q�$	��Top=� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ minimizeBtn��$��0��$��8��  MaterialDesignFlatButton#��[ #��[ 	 � ToolTip$	 MaterialDesignFlatButton��$	��Top=�$��2��$��Right=�$��55��.��(  "SharpVectors.Converters.SvgViewbox  
   Source$
 \imgs\minus_a.svg?�$��27���� -   $ closeBtn��$��0��$��9��
���  ��$	 MaterialDesignFlatButton��#��[ $��Bottom=�$��2��.��  $
 \imgs\close_a.svg?�$��27���� $ 	0,50,0,15��$��1��  	Secondary#��[ $��0��$��3��$��16���� -   $��NavigationList��$��6��$��0��$��3��$��9����.  $��Disabled=�.@��� -   $��FlightsItem��0  *MaterialDesignThemes.Wpf.ListBoxItemAssist   HoverBackground �#FF8EA2    SelectedFocusedBackground �#A6102A.���� $��10,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\flights.svg?�$��27�� �� .�
Рейсы�� -   $��AirportsItem�� �#FF8EA2 �#A6102A.���� $��10,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\airport.svg?�$��25�� �� .�Аэропорты�� -   $��	UsersItem�� �#FF8EA2 �#A6102A$��Center=�.���� $��10,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\users_a.svg?�$��35��$��0,0,5,0q� �� .�Пользователи�� -   $��AirlinesItem�� �#FF8EA2 �#A6102A.���� $��7,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\airline.svg?�$��25�� �� .�Авикомпании�� -   $��
PlanesItem�� �#FF8EA2 �#A6102A.���� $��7,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\planes.svg?�$��25�� �� .�Самолеты�� -	   $��SeatsClassItem�� �#FF8EA2 �#A6102A.���� $��7,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\seats.svg?�$��25�� �� .�Места и классы�� -
   $��ReviewsItem�� �#FF8EA2 �#A6102A$��Center=�.���� $��10,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\comments.svg?�$��27��$��0,0,5,0q� �� .�Отзывы�� -   $��	StatsItem�� �#FF8EA2 �#A6102A.���� $��7,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\stats.svg?�$��25�� �� .�Статистика�� -   $��LogsItem�� �#FF8EA2 �#A6102A.���� $��7,0,0,0q�$
��26pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[    $
 \imgs\journal.svg?�$��25�� �� .�Логирование�� -    ��Name$ ProfileList��$��15��$��0��$��3��$��Bottom=�����  �� 
TargetType" ��  MaterialDesignListBoxItem �� BasedOn# [  �� 	Resources  �� Property �� Value��%@   '��       �� " ��.���  �@��CornerRadius$ 0,0,0,33��.@��� -   $��ProfileItem�� �#FF8EA2$+��%pack://application:,,,/fonts/#fontick)� �#A6102A.���� $
��26pt(�$��5,-5,0,5q�#��[    $
 \imgs\profileUser.svg?�$��30��$��0,0,0,-3q� �� .�Профиль�� $��Навигация��$��4��$��0��$��2��$��3�� �� TextAlignment$ Center=�
�������$��Center=�$
��39pt(�$+��%pack://application:,,,/fonts/#fontick)� � -     �Name$ 	PageFrame��$��1��$��3��$��12��$��15��  � NavigationUIVisibility$ Hidden=�  $��0��$��0��$��3��$
��Left=�$
 /imgs/plane.svg?�$	��320��$��5��