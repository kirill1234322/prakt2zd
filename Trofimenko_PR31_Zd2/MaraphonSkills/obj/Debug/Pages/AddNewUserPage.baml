   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      )    #MaraphonSkills.Pages.AddNewUserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  AddNewUserPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%J  '��       'G� I     '�� �     '�� �     �� 5   
   " ��6   .�5      ��  � ��$	 150��6&   5      �� 5   
   " G�6   .�5      ��  � ��$	 150��6&   5      �� 5   
   " ��6   .�5      ��  � ��$	 100��6&   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      5      .��5      � .+�5   
   �� -   5         ��Name$ 	PageLabel��5   E   $��Center=�6   $	��Top=�6-   6E   � 5   
   $��Center=�6   $��Center=�61   .+�5       �� .+�5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $��Email:��6       DescriptionTextBlock#��[  6.   �� 5#      -   5         ��Name$ EmailTextBox��5#      ��64   �� *Email+ �� Mode$ TwoWay=�5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Имя:��6    #��[  6,   �� 5'      -   5        $ FirstNameTextBox��5'      ��68   �� *	FirstName+$ TwoWay=�5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��Фамилия:��6    #��[  60   �� 5+      -   5        $ LastNameTextBox��5+      ��67   �� *
LastName+$ TwoWay=�5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��	Роль:��6    #��[  6-   �� 5/      -   5        	 ��Name$	 RoleComboBox��5/      
 �� SelectedValue
 65   �� *RoleId+$ TwoWay=�50      51      �� 52      .+�53      �� -   5        $ PasswordLabel��53      �� 54      -   5         ��Name$ PasswordTextBlock��54      $
��Wrap=�67   �� 55      $ 
Horizontal=�6   .+�56      �� $��Пароль��6    #��[  6.   G� 57      -   5         G�Name$ PasswordTextBox��57   "   58      �� 59      $ 
Horizontal=�6   .+�5:      �� $��Повтор пароля��6    #��[  65   G� 5;      -	   5        $ PasswordRepeatTextBox��5;   "   5<      �� 5=      -
   5        $ PasswordValue��5=   W   $y�Hidden=�6C   ��6   �� *
Password+$ TwoWay=�6W   �� 5>      -   5        $ ErrorsTextBlock��5>      5?      5@      �� 5B   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   .+�5C      �� -   5         ��Name$ 
SaveButton��5C   @     SmallButtonBorder#��[ 6   ._�5D      �� $��Сохранить��6   5E      �� 5F      -   5        $ CancelButton��5F   @   #��[ 6   ._�5G      �� $��Отмена��6   5H      5I      5J      5K      