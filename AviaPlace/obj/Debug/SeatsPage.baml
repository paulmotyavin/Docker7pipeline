   M S B A M L   `   `   `  ����  	AviaPlace    AviaPlace.SeatsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  	SeatsPage��5         MaterialDesignPaper N� 
Background# �   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Выбор места��6   $��32(�5      $
��Bold"�5        	Secondary#��[ 5      $��Center=�5      $��0,0,0,20q�5      $��0��5      �� 5   
   $
��Auto=�6   $��Disabled=�5      $��	0,20,0,20q�5      $��1��5      .��5      A� -   5         A�Name$ SeatGrid��5       A� Rows$ 10��5       A� Columns$ 3��6$   $��Center=�5      $	��Top=�5      $��0,0,0,30q�5      $	��500��5      5       5!      � 5#   
   $��2��6   $��Center=�6   $��Center=�69    � ColumnDefinitions 5$      �� 5%      $
��Auto �6#   �� 5&      $
��Auto �6#   �� 5'      $
��Auto �6#   .+�5*      �� -   5        $
��Exit��5+      $��Обратно��5*      $	��250��5,      $��50��5-      $��16(�5.      $
��Bold"�5/        MaterialDesignRaisedButton#��[ 50        	LightGrey#��[ 51        
Background#��[ 52      $��0��53      $��0,0,10,0q�54      $��2��56      �� 58      -   5        $+��%Подтвердить покупку��58      $	��250��5:      $��50��5;      $��16(�5<      $
��Bold"�5=      #��[ 5>        	Important#��[ 5?      #��[ 5@      $��1��5A      $��0,0,10,0q�5B      ��59      �� *ConfirmPurchaseCommand+5C      �� 5E      -   5        $��PriceTbk��5E      $��Цена: 0 ₽��5F      $��Center=�5G        Grey#��[ 5H      $
��20pt(�5I      $+��%pack://application:,,,/Fonts/#fontick)�5J      $��2��5K      $��10,0,0,0q�5L      5M      5N      5O      