   M S B A M L   `   `   `  ����D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace  5          AviaPlace.AirportsPage   5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AviaPlace     5        N� Title$  	UsersPage��5
      .��5      ��  �� CornerRadius$ 0,0,15,0��6      
Background#��[  6%   ._�5   
   � 
������  � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $
��0.5* �6#    � RowDefinitions 5      �� 5      $
��0.4* �6    �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      $
��0.4* �6    .+�5-      �� $ 15��6   
�������  	Secondary#��[ 6:   $	��0.3q�6b   $��0��6x   $��1��6�   $��16��6�   $��11��6�   ._�5.      �� $��Right=�6   $	��Top=�69    �� Orientation$ Vertical=�6Q   .+�5/      �� $��Аэропорты��6    $
��39pt(�61   $+��%pack://application:,,,/Fonts/#fontick)�6A   #��[  6t   $��7,7,15,0q�6�   50      51      �� 52      -   5        $��AddBtn��52      $��10��6#   $��8��61   $+��%pack://application:,,,/Fonts/#fontick)�6x   #��[  6�   $
��24pt(�6�   $��50��6�   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6�     	Important#��[ 6  #���  6Z  ��6A   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size$ 45X�6Z  �� 53      -   5        $��EditBtn��53      $��10��6$   $��9��62   $+��%pack://application:,,,/Fonts/#fontick)�6y   #��[  6�   $
��24pt(�6�   $��50��6�   $ 5��6�   #��[ 6  #���  6\  ��6B     $
 Edit=�$ 40X�6\  �� 54      -   5        $��	DeleteBtn��54      $��10��6&   $��10��64   $��Center=�6~   $��Center=�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $
��24pt(�6  $��50��6)  $ 5��65  #��[ 6b  #���  6�  ��6E     $ Delete=�$ 40X�6�  �� 55      #��[ 6   $��3��6=   $��1��6J   $��6��6Z   $��11��6n   $ 10��6�   $��50,0,0,0q�6�   ._�56      �� -   5        $��AirportsList��56      $
��20pt(�6.   $+��%pack://application:,,,/Fonts/#fontick)�6>   ��. $��Visible=�6�   #��[  6�   
�������6%  57      �� 58      -   5        $��NameTbx��58      $��5��6%   $��8��62   $��3��6B     Grey#��[ 6V   $��	0,10,0,10q�6z   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist	   TextFieldCornerRadius$	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6<  #��[ 6�  
 �� 
CaretBrush#
 �  6�   �� SelectionBrush# �  6�  �� 59      -   5        $��CityTbx��59      $��6��6%   $��8��62   $��3��6B   $��	0,10,0,10q�6V   #��[ 6i   $ 
Город��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   $	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6:  #��[ 6�  #
 �  6�  # �  6�  �� 5:      -   5        $��
CountryTbx��5:      $��7��6(   $��8��65   $��3��6E   $��	0,10,0,10q�6Y   #��[ 6l   $ Страна��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   $	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6=  #��[ 6�  #
 �  6�  # �  6�  �� 5;      -   5        $��CodeTbx��5;      $��8��6%   $��8��62   $��3��6B   $��	0,10,0,10q�6V   #��[ 6i   $ Код аэропорта��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   $	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6A  #��[ 6�  #
 �  6�  # �  6�  �� 5<      -	   5        $��	ImportBtn��5<      $��12��6&   $��8��64   $��3��6D   $��Импорт данных��6X   $��Center=�6p   $��Center=�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $
��24pt(�6  $��50��6  $ 5��6'  #��[ 6T  #���  6�  �� 5=      -
   5        $��	ExportBtn��5=      $��13��6&   $��8��64   $��3��6D   $!��Экспорт данных��6X   $��Center=�6q   $��Center=�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $
��24pt(�6  $��50��6  $ 5��6(  #��[ 6U  #���  6�  5?      5@      5A      