   M S B A M L   `   `   `  ����D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace  5          AviaPlace.PlanesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AviaPlace     5        N� Title$  	UsersPage��5
      .��5      ��  �� CornerRadius$ 0,0,15,0��6      
Background#��[  6%   ._�5   
   � 
������  � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $
��0.5* �6#    � RowDefinitions 5      �� 5      $
��0.4* �6    �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      $
��0.4* �6    .+�5-      �� $ 15��6   
�������  	Secondary#��[ 6:   $	��0.3q�6b   $��0��6x   $��1��6�   $��16��6�   $��11��6�   ._�5.      �� $��Right=�6   $	��Top=�69    �� Orientation$ Vertical=�6Q   .+�5/      �� $��Самолеты��6    $
��39pt(�60   $+��%pack://application:,,,/Fonts/#fontick)�6@   #��[  6s   $��7,7,15,0q�6�   50      51      �� 52      -   5        $��AddBtn��52      $��10��6#   $��8��61   $+��%pack://application:,,,/Fonts/#fontick)�6x   #��[  6�   $
��24pt(�6�   $��50��6�   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6�     	Important#��[ 6  #���  6Z  ��6A   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�   Size$ 45X�6Z  �� 53      -   5        $��EditBtn��53      $��10��6$   $��9��62   $+��%pack://application:,,,/Fonts/#fontick)�6y   #��[  6�   $
��24pt(�6�   $��50��6�   $ 5��6�   #��[ 6  #���  6\  ��6B     $
 Edit=�$ 40X�6\  �� 54      -   5        $��	DeleteBtn��54      $��10��6&   $��10��64   $��Center=�6~   $��Center=�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $
��24pt(�6  $��50��6)  $ 5��65  #��[ 6b  #���  6�  ��6E     $ Delete=�$ 40X�6�  �� 55      #��[ 6   $��3��6=   $��1��6J   $��6��6Z   $��11��6n   $ 10��6�   $��50,0,0,0q�6�   ._�56      �� -   5        $��AircraftList��56      $
��20pt(�6.   $+��%pack://application:,,,/Fonts/#fontick)�6>   ��. $��Visible=�6�   #��[  6�   
�������6V  57      �� 58      -   5        $��ModelTbx��58      $��5��6&   $��8��63   $��3��6C     Grey#��[ 6W   $��	0,10,0,10q�6{   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Модель��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist	   TextFieldCornerRadius$	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6;  #��[ 6�  
 �� 
CaretBrush#
 �  6�   �� SelectionBrush# �  6�  �� 59      -   5        $��CapacityTbx��59      $��6��6)   $��8��66   $��3��6F   $��	0,10,0,10q�6Z   #��[ 6m   $ Вместимость��6�   $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   $	 5��6
  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6C  #��[ 6�  #
 �  6�  # �  6�  �� 5:      -   5        $��ImgTbx��5:      $��7��6$   $��8��61   $��3��6A   $��	0,10,0,10q�6U   #��[ 6h   $ Изображение��6�    �� 
IsReadOnly . $��10,0,0,0q�6�   $
��20pt(�6�   #��[  6�   $	 5��6  $A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�6P  #��[ 6�  #
 �  6�  # �  6�  �� 5;      -   5        $��OpenBtn��5;      $��7��6$   $��7��61   $��75��6A   $��Right=�6L   $��0,0,10,0q�6�   $+��%pack://application:,,,/Fonts/#fontick)�6�   #��[  6�   $
��24pt(�6  $��50��6  $ 5��6*  #��[ 6W  #���  6�  ��6h     $ Image=�$ 35X� � ToolTip 5<      _� 5=      $+��%Выбрать изображение��6   5?      5@      5A      5B      