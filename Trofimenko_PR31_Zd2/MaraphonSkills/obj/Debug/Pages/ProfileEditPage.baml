   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      *    $MaraphonSkills.Pages.ProfileEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  ProfileEditPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%J  '��       'G� I     '�� �     '�� �     �� 5      " ��6   .�5   
   ��  � ��$	 150��6"   5      �� 5      " G�6   .�5   
   ��  � ��$	 150��6"   5      �� 5      " ��6   .�5   
   ��  � ��$	 100��6"   5      �� 5      " ��6   .�5   
   ��  � ��$ 5q�6#   5      5      .��5      � .+�5   
   �� $1��+Редактирование профиля��6   � 5   
   $��Center=�6   $��Center=�61   .+�5       �� .+�5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $��Email:��6       DescriptionTextBlock#��[  6.   �� 5#      -   5         ��Name$ EmailTextBox��5#      $��0q�64    �� 
IsReadOnly . 6H   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Имя:��6    #��[  6,   �� 5'      -   5        $ FirstNameTextBox��5'      5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��Фамилия:��6    #��[  60   �� 5+      -   5        $ LastNameTextBox��5+      5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��Пол:��6    #��[  6,   �� 5/      -   5         ��Name$ GenderComboBox��5/      50      �� 51      $ 
Horizontal=�6   .+�52      �� $ ��Дата рождения:��6    #��[  66   (  "System.Windows.Controls.DatePicker  53      -   5        	  Name$	 DateOfBirthDatePicker��53   !   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��Страна:��6    #��[  6/   �� 57      -   5        $ CountryComboBox��57      58      59      �� 5:      .+�5;      �� -   5        
 ��Name$
 RunnerImage��5;      $��50��6-   $��50��69   �� 5<      $ 
Horizontal=�6   .+�5=      �� $��Фото файл:��6    �� 5>      -   5        $ PhotoPathTextBox��5>      $
��auto��68    . $��0q�6W   �� 5?      -	   5         ��Name$ 
FileButton��5?   _     SmallButtonBorder#��[ 6   $��0q�6H   $��30��6S   ._�5@      �� $��Просмотр...��6$   5A      5B      �� 5C      $��Смена пароля��6   �� 5D      $���{Оставте эти поля, незаполненными, если вы не хотите изменять пароль��6   $
��Wrap=�6g   �� 5E      $ 
Horizontal=�6   .+�5F      �� $��Пароль��6    #��[  6.   G� 5G      -
   5         G�Name$ PasswordTextBox��5G   "   5H      �� 5I      $ 
Horizontal=�6   .+�5J      �� $%��Повторите пароль��6    #��[  68   G� 5K      -   5        $ PasswordRepeatTextBox��5K   "   6D   5L      5M      �� 5N   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   .+�5O      �� -   5        $ 
SaveButton��5O   @   #��[ 6   ._�5P      �� $��Сохранить��6   5Q      �� 5R      -   5        $ CancelButton��5R   @   #��[ 6   ._�5S      �� $��Отмена��6   5T      5U      5V      5W      