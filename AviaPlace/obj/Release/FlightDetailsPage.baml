   M S B A M L   `   `   `  ����   	AviaPlace!    AviaPlace.FlightDetailsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  FlightDetailsPage��.����  �� CornerRadius$ 15��   
Background#��[   �� Padding$ 20q�._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� -    ��Name$ FlightDetailsHeader��$��Детали Рейса��$��36(�$
��Bold"�  Grey#��[ $��1��$��1��$��10��$��Center=�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� $��2��$��1��$��10�� �� Orientation$ 
Horizontal=�$��Center=�.+��� -    ��Name$ AirlineLogo��$��imgs/aeroflot.png�� � Cursor$
 Hand��$	��150��$��50��$
��10,0q��� -   $ AirlineName��$��Аэрофлот��$
 Hand��$��24(�$
��Bold"�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ FlightNumberText��$��	 | SU1478��$��24(�$��SemiBold"�$��Center=�$��10,0,0,0q�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ DepartureAirport��$1��+Москва (Шереметьево) [SVO]��$��18(�$��3��$��1��$��4��$��Right=�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ ArrivalArrow��$
��—>��$��24(�$
��Bold"�$��3��$��5��$��2��$��Center=�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ ArrivalAirport��$��Абакан [ABA]��$��18(�$��3��$��7��$��4��$
��Left=�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ DepartureTime��$'��!Вылет: 9 ноября, 23:50��$��18(�$��4��$��2��$��Center=�$��3��$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� -	   $ ArrivalTime��$*��$Прилет: 10 ноября, 08:45��$��18(�$��4��$��8��$��3��$��Center=�$��Center=�$+��%pack://application:,,,/fonts/#Fontick)��� $��5��$��1��$��10��$ 
Horizontal=�$��Center=�$��Center=�.+��� -
   $ 	PlaneInfo��$"��Boeing 737-800, 160 мест��$��Center=�$��18(�$+��%pack://application:,,,/fonts/#Fontick)��� -   $ AircraftImage��$��imgs/aeroflot.png��$	��150��$��50��$
��10,0q�� $��6��$��1��$��10��$��20,20,20,20q�$��8�� �� $��* ��� $��* ��� $��* �.+���   	OtherGrey#��[ $��1q�$ 10��$��5q�$ 10q�
�������._��� -   	 ��Name$	 EconomyClassPanel��$��Center=�$��Center=�.+��� -   $ EconomyClassTitle��$��Эконом��$��20(�$
��Bold"�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ EconomyClassPrice��$��Цена: 67 962 ₽��$��18(�$��Center=�  	Secondary#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ EconomyClassDetails��$,��&1 место багажа до 23 кг��$��16(�$��Center=�  	LightGrey#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ EconomyClassHandLuggage��$*��$Ручная кладь до 10 кг��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   
 ��Name$
 EconomyClassButton��$��Купить��$	��120��$��35��$��0,10,0,0q�#��[ 
�������
������ $
��Bold"�$+��%pack://application:,,,/fonts/#Fontick)��� #��[ $��1q�$ 10��$��1��$��5q�$ 10q�
�������._��� -   $	 BusinessClassPanel��$��Center=�$��Center=�.+��� -   $ BusinessClassTitle��$��Бизнес��$��20(�$
��Bold"�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ BusinessClassPrice��$��Цена: 72 402 ₽��$��18(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ BusinessClassPriority��$��Sky Priority��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ BusinessClassBaggage��$,��&2 места багажа до 23 кг��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ BusinessClassHandLuggage��$*��$Ручная кладь до 10 кг��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $
 BusinessClassButton��$��Купить��$	��120��$��35��$��0,10,0,0q�#��[ 
�������
������ $
��Bold"�$+��%pack://application:,,,/fonts/#Fontick)��� #��[ $��1q�$ 10��$��2��$��5q�$ 10q�
�������._��� -   $	 FirstClassPanel��$��Center=�$��Center=�.+��� -   $ FirstClassTitle��$��Первый класс��$��20(�$
��Bold"�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ FirstClassPrice��$��Цена: 90 462 ₽��$��18(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ FirstClassPriority��$��Sky Priority��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ FirstClassBaggage��$,��&3 места багажа до 23 кг��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $ FirstClassHandLuggage��$*��$Ручная кладь до 10 кг��$��16(�$��Center=�#��[ $+��%pack://application:,,,/fonts/#Fontick)��� -   $
 FirstClassButton��$��Купить��$	��120��$��35��$��0,10,0,0q�#��[ 
�������
������ $
��Bold"�$+��%pack://application:,,,/fonts/#Fontick)��� -    $��2��$��1��$��Center=�$��Center=���0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 	ArrowLeft=�   Size$ 30X�