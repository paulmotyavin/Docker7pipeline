   M S B A M L   `   `   `  ����   	AviaPlace    AviaPlace.UsersPage   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  	UsersPage��.����  �� CornerRadius$ 0,0,15,0��   
Background#��[  ._�� 
������  � ColumnDefinitions �� $
��0.5* ��� �� �� �� �� �� �� �� �� �� �� $
��0.5* � � RowDefinitions �� $
��0.4* ��� �� �� �� �� �� �� �� �� �� �� �� �� �� �� $
��0.4* �.+��� $ 15��
�������  	Secondary#��[ $	��0.3q�$��0��$��1��$��16��$��11��._��� $��Right=�$	��Top=� �� Orientation$ Vertical=�.+��� $��Пользователи��$
��39pt(�$+��%pack://application:,,,/Fonts/#fontick)�#��[  $��7,7,15,0q��� -   $��AddBtn��$��11��$��8��$��Добавить��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��$��3��  	Important#��[ #���  �� -   $��EditBtn��$��12��$��8��$��Изменить��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��$��3��#��[ #���  �� -   $��	DeleteBtn��$��13��$��8��$��Удалить��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��$��3��#��[ #���  �� #��[ $��3��$��1��$��6��$��11��$ 10��$��50,0,0,0q�._��� -   $��	UsersList��$
��20pt(�$+��%pack://application:,,,/Fonts/#fontick)���. $��Visible=�#��[  
��������� -   $��
SurnameTbx��$��4��$��8��$��3��  Grey#��[ $��	0,10,0,10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Фамилия��$��10,0,0,0q�$
��20pt(�#��[  .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[  �� 
CaretBrush# �  	 �� SelectionBrush#	 �  �� -   $��NameTbx��$��5��$��8��$��3��$��	0,10,0,10q�#��[ $ Имя��$��10,0,0,0q�$
��20pt(�#��[  $ 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  #	 �  �� -   $��emailTbx��$��6��$��8��$��3��$��	0,10,0,10q�#��[ $ Эл. почта��$��10,0,0,0q�$
��20pt(�#��[  $ 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  #	 �  �� -   $��passwordTbx��$��7��$��8��$��3��$��	0,10,0,10q�#��[ $ Пароль��$��10,0,0,0q�$
��20pt(�#��[  $ 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ # �  #	 �  �� -	   $��roleCbx��$��8��$��8��$��3��$��	0,10,0,10q�#��[ $ Роль��$��	10,0,10,0q�$
��20pt(�#��[  $ 5��$A��;pack://application:,,,/fonts/montserrat/#Montserrat Regular)�#��[ .@��� #��[ #��[  .��Администратор�� #��[ #��[  .��Клиент�� -
   $��	ExportBtn��$��14��$��4��$��Right=�$"��Экспортировать��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��$��3��#��[ #���  �� -   $��	ImportBtn��$��14��$��1��$��Right=�$ ��Импортировать��$+��%pack://application:,,,/Fonts/#fontick)�#��[  $
��24pt(�$��50��$ 5��$��3��#��[ #���  