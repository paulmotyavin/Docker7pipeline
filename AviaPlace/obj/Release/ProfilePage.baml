   M S B A M L   `   `   `  ���� D  @AviaPlace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AviaPlace	AviaPlace      AviaPlace.ProfilePage   b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be772svgc1&http://sharpvectors.codeplex.com/svgc/  _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:AviaPlace       N� Title$  ProfilePage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��1��$��1��$��14��$��10��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $��Профиль��$
��39pt(�$+��%pack://application:,,,/fonts/#fontick)�#��[  $��7,7,10,0q��� -    ��Name$ 	AvatarImg��$	��250��$	��250��$��Uniform=�$��\imgs/avatar.png��$��1��$��Center=�$��5��$��3��$��5��$��	40,0,40,0q��� -    ��Name$ 	DeleteBtn��$��8��$��0,5,0,0q�  	Important#���  #��[ $��65��$��4��$��65��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$	 150��$	��Top=�$
��Left=�$��2��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�$��45��$��45��$��Center=�#��[  $��Center=�	 � ToolTip	 _� $%��Удалить аватарку���� -   $ AddBtn��$��8��$��0,5,0,0q�#���  #��[ $��65��$��3��$��65��$	 150��$	��Top=�$��Center=�$��2��.��  $	 Add=�$��45��$��45��$��Center=�#��[  $��Center=�	 _� $'��!Добавить аватарку���� -   $��ExitBtn��$��13��$��6��$��2��$��
Выйти��$��10,0,0,0q�$+��%pack://application:,,,/fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��$��2��#��[ #���  �� $��3��$��6��$��4��$
��30pt(�$��10,0,0,0q�$��Фамилия��$+��%pack://application:,,,/fonts/#fontick)�  Grey#��[ �� -   
 ��Name$
 	SurnameTb��$��4��$��6��$��4��$
��24pt(�$��12,0,0,0q�$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� $��5��$��6��$��4��$
��30pt(�$��10,0,0,0q�$��Имя��$+��%pack://application:,,,/fonts/#fontick)�#��[ �� -   $
 NameTb��$��6��$��6��$��4��$
��24pt(�$��12,0,0,0q�$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� $��7��$��6��$��4��$
��30pt(�$��10,0,0,0q�$��Эл.почта��$+��%pack://application:,,,/fonts/#fontick)�#��[ �� -   $��EmailTb��$��8��$��6��$��4��$
��24pt(�$��12,0,0,0q�$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� $��9��$��6��$��4��$
��30pt(�$��10,0,0,0q�$��Роль��$+��%pack://application:,,,/fonts/#fontick)�#��[ �� -   $
 roleTb��$��10��$��6��$��4��$
��24pt(�$��12,0,0,0q�$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� -	   $��	BackupBtn��$��11��$��3��$��2��$��Backup БД��$��Center=�$��Center=�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��#��[ #���  