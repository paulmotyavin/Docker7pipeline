   M S B A M L   `   `   `  ����D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace  5          AviaPlace.AirlineInfoPage   5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AviaPlace     5        N� Title$  Авиакомпания��5
      .��5      �� .��5   
   ��  �� CornerRadius$ 0,0,15,0��6      
Background#��[  6)   ._�5      � 
������  � RowDefinitions 5      �� 5      $
��0.4* �6$   �� 5      $��0.75* �6$   �� 5      $��0.75* �6$   �� 5      �� 5      $��1.375* �6$   �� 5      $
��0.6* �6$   �� 5      �� 5      �� 5      $
��0.4* �6$    � ColumnDefinitions 5      �� 5      $
��0.5* �6'   �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5%      �� $��1��6   $��1��6&   $��2��66   $��6��6G     	Secondary#��[ 6[   $ 10��6�   ._�5&      �� $��Center=�6!   $��Center=�6>   $��20q�6Y   .+�5'      �� -   5        $��AirlineLogo��5'       $	��250��63   $
��Auto��6?   $��imgs/aeroflot.png��6M   $��Uniform=�6h   $��Center=�6z   $��0,0,0,10q�6�   �� 5)       �� Orientation$ 
Horizontal=�6%   $��Center=�6>   .+�5*      �� -   5        $��AirlineName��5*   (   $
��32pt(�6;   $��Аэрофлот��6K   $��Center=�6[   $��Center=�6x   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   �� 5+      $
��28pt(�6(   $
�� ★��68   $��Center=�6B   $��Center=�6_   
��� ���6z   �� 5,      -   5        $��AirlineRating��5,   (   $
��32pt(�6=   $	��4.6��6M   $��Center=�6X   $��Center=�6u   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   5-      �� 5/      -   5        $��AirlineCity��5/   $   $��Россия��67   $
��18pt(�6E   $��Center=�6U   $��Center=�6r   $+��%pack://application:,,,/Fonts/#fontick)�6�     Grey#��[ 6�   $��5q�6�   50      51      �� 53      -   5        $��
ExitButton��53      $��0��6+   $��0��68   $
��24pt(�6H   
������   	Important#��[ 6q   
������ $��1q�6�   .��54      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6.   $��45��6?   $��45��6J   $��Center=�6V   #��[ 6s   $��Center=�6�   55      �� 57      $��3��6   $��1��6)   $��6��69   $��Bottom=�6M   $
��Left=�6h   $
��30pt(�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[ 6�   $��Текущие рейсы��6�   �� 58      $��4��6   $��1��6&   $��6��66   #��[ 6J   $ 10��6r   ._�59      �� -   5        $��CurrentFlightsList��59      $
��20pt(�68   #��[  6H   6q   5:      �� 5<      $��5��6   $��1��6)   $��6��69   $��Bottom=�6M   $
��30pt(�6h   $+��%pack://application:,,,/Fonts/#fontick)�6x   #��[ 6�   $!��Напишите отзыв��6�   �� 5=      $��6��6   $��1��6&   $��6��66   #��[ 6J   $ 10��6r   ._�5>      �� $��20q�6!   .+�5?      �� -   5        $��ReviewTextBox��5?   [   .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��6"   $
��Auto��6p   $��50��6}   $��5q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$- 'Напишите свой отзыв...��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $
��16pt(�6�   #��[  6�   #��[ 6(  #��[ 6P  $��1q�6y  �� 5A      $ 
Horizontal=�6%   $��Stretch=�6>   $��Center=�6\   $��5q�6w   .+�5B      �� -   5        $��RatingComboBox��5B   '   $	��150��6=   $��0,0,5,0q�6I   $
��16pt(�6[   $��	10,0,10,0q�6k   #��[ 6~   #��[ 6�   #��[ 6�   $��1q�6�   .@�5C   "   �� .��6/   1 ★64   �� 5D   "   .��6/   
2 ★★65   �� 5E   "   .��6/   3 ★★★66   �� 5F   "   .��6/   4 ★★★★67   �� 5G   "   .��6/   5 ★★★★★68   5H      �� 5J      -	   5        $��SubmitReviewButton��5J   %   $��Отправить��6?   $
��22pt(�6S   #��[ 6c   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $��Center=�6�   $��Center=�6�   $
��Auto��6  $��50��6'  $��10,0,0,0q�63  6E  5K      5L      5M      �� 5O      $��7��6   $��1��6)   $��6��69   $
��30pt(�6M   $+��%pack://application:,,,/Fonts/#fontick)�6]   #��[ 6�   $��Bottom=�6�   $��Отзывы��6�   �� 5P      $��8��6   $��1��6&   $��6��66   #��[ 6J   $ 10��6r   $��20q�6�   ._�5Q      �� -
   5        $��ReviewsList��5Q      $
��20pt(�61   #��[  6A   5R      5T      5U      5V      5X      