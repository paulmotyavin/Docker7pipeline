   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.AirlineInfoPage   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:AviaPlace       N� Title$  Авиакомпания��.���� .����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � RowDefinitions �� $
��0.4* ��� $��0.75* ��� $��0.75* ��� �� $��1.375* ��� $
��0.6* ��� �� �� $
��0.4* � � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� .+��� $��1��$��1��$��2��$��6��  	Secondary#��[ $ 10��._��� $��Center=�$��Center=�$��20q�.+��� -   $��AirlineLogo��$	��250��$
��Auto��$��imgs/aeroflot.png��$��Uniform=�$��Center=�$��0,0,0,10q���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��AirlineName��$
��32pt(�$��Аэрофлот��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  �� $
��28pt(�$
�� ★��$��Center=�$��Center=�
��� ����� -   $��AirlineRating��$
��32pt(�$	��4.6��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  �� -   $��AirlineCity��$��Россия��$
��18pt(�$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�  Grey#��[ $��5q��� -   $��
ExitButton��$��0��$��0��$
��24pt(�
������   	Important#��[ 
������ $��1q�.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�$��45��$��45��$��Center=�#��[ $��Center=��� $��3��$��1��$��6��$��Bottom=�$
��Left=�$
��30pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[ $��Текущие рейсы���� $��4��$��1��$��6��#��[ $ 10��._��� -   $��CurrentFlightsList��$
��20pt(�#��[  �� $��5��$��1��$��6��$��Bottom=�$
��30pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[ $!��Напишите отзыв���� $��6��$��1��$��6��#��[ $ 10��._��� $��20q�.+��� -   $��ReviewTextBox��.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��$
��Auto��$��50��$��5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$- 'Напишите свой отзыв...��" �� VerticalScrollBarVisibility$
 Auto=�$
��16pt(�#��[  #��[ #��[ $��1q��� $ 
Horizontal=�$��Stretch=�$��Center=�$��5q�.+��� -   $��RatingComboBox��$	��150��$��0,0,5,0q�$
��16pt(�$��	10,0,10,0q�#��[ #��[ #��[ $��1q�.@��� .��1 ★�� .��
2 ★★�� .��3 ★★★�� .��4 ★★★★�� .��5 ★★★★★�� -	   $��SubmitReviewButton��$��Отправить��$
��22pt(�#��[ $+��%pack://application:,,,/Fonts/#fontick)�#��[  $��Center=�$��Center=�$
��Auto��$��50��$��10,0,0,0q��� $��7��$��1��$��6��$
��30pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[ $��Bottom=�$��Отзывы���� $��8��$��1��$��6��#��[ $ 10��$��20q�._��� -
   $��ReviewsList��$
��20pt(�#��[  