   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      1    +MaraphonSkills.Pages.ViewerRegistrationPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  ViewerRegistrationPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%J  '��       'G� I     '�� �     '�� �     �� 5   
   " ��6   .�5      ��  � ��$	 150��6&   5      �� 5   
   " G�6   .�5      ��  � ��$	 150��6&   5      �� 5   
   " ��6   .�5      ��  � ��$	 100��6&   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      5      .��5      � .+�5   
   �� .+�5      �� .+�5       �� $+��%Регистрация зрителя��6   �� 5!      $����Пожалуйста заполните всю информация, чтобы зарегистрироваться в качестве зрителя��6   $
��Wrap=�6t   5"      �� 5#      $��Center=�6   .+�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� $��Email:��6       DescriptionTextBlock#��[  6.   �� 5&      -   5         ��Name$ EmailTextBox��5&      $��0��64   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��Пароль:��6    #��[  6/   G� 5*      -   5         G�Name$ PasswordTextBox��5*   "   $��1��6;   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $&�� Повторите пароль:��6    #��[  69   G� 5.      -   5        $ PasswordRepeatTextBox��5.   "   $��2��6A   5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��Имя:��6    #��[  6,   �� 52      -   5        $ FirstNameTextBox��52      $��3��68   53      �� 54      $ 
Horizontal=�6   .+�55      �� $��Фамилия:��6    #��[  60   �� 56      -   5        $ LastNameTextBox��56      $��4��67   57      �� 58      $ 
Horizontal=�6   .+�59      �� $��Пол��6    #��[  6+   �� 5:      -   5         ��Name$ GenderComboBox��5:      $��5��67   	 �� SelectedValue	 6D   �� *	Gender1+5;      �� 5<      $ 
Horizontal=�6   .+�5=      �� $��Страна:��6    #��[  6/   �� 5>      -   5        $ CountryComboBox��5>      $��6��68   ��. 	 6V   �� *CountryName+5?      �� 5@      -   5        
 ��Name$
 ErrorsTextBlock��5@      5A      �� 5B      $ 
Horizontal=�6   $��Center=�62   .+�5C      �� -	   5         ��Name$ RegistrationButton��5C   D     SmallButtonBorder#��[ 6   ._�5D      �� $��Регистрация��6    5E      �� 5F      -
   5        $ CancelButton��5F   D   #��[ 6   ._�5G      �� $��Отмена��6    5H      5I      5J      5K      5L      