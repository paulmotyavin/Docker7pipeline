   M S B A M L   `   `   `  ����   	AviaPlace    AviaPlace.SeatsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  	SeatsPage��   MaterialDesignPaper N� 
Background# �   .��� $��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��Выбор места��$��32(�$
��Bold"�  	Secondary#��[ $��Center=�$��0,0,0,20q�$��0���� $
��Auto=�$��Disabled=�$��	0,20,0,20q�$��1��.��A� -    A�Name$ SeatGrid�� A� Rows$ 10�� A� Columns$ 3��$��Center=�$	��Top=�$��0,0,0,30q�$	��500��� $��2��$��Center=�$��Center=� � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $
��Exit��$��Обратно��$	��250��$��50��$��16(�$
��Bold"�  MaterialDesignRaisedButton#��[   	LightGrey#��[   
Background#��[ $��0��$��0,0,10,0q�$��2���� -   $+��%Подтвердить покупку��$	��250��$��50��$��16(�$
��Bold"�#��[   	Important#��[ #��[ $��1��$��0,0,10,0q����� *ConfirmPurchaseCommand+�� -   $��PriceTbk��$��Цена: 0 ₽��$��Center=�  Grey#��[ $
��20pt(�$+��%pack://application:,,,/Fonts/#fontick)�$��2��$��10,0,0,0q�