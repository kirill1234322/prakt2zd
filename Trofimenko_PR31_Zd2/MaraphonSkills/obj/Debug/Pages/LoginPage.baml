   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      $    MaraphonSkills.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  	LoginPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%Q   '��       �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      5      .��5      � .+�5   
   �� $��Center=�6   .+�5      �� $'��!Форма авторизации��6   �� 5      $����Пожалуйста авторизируйтесь в системе, используя ваш адрес электронной почты и пароль.��6   $
��Wrap=�6u   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��Email:��6      DescriptionTextBlock#��[  6*   �� 5      -   5         ��Name$ EmailTextBox��5      $	��150��60   $��0��6<   $��30��6I   .��6U   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   5   �� 6   6sys&clr-namespace:System;assembly=mscorlib     65   " ��6     �� 	Resources 5        CueBannerBrush j� 
AlignmentX	 j� 
AlignmentY
 j� Stretch !� Visual��%�   &	       !� 5   "   $
 Left=�6E   $		 Top=�6W   $

 None=�6h    5   "   �� 5   &   
�������}�. ��5   *   �� 5   .   " ��64   .�5   2   ��  � ��$ Введите Email��6L   5    /   5"   '   5$   #   5%       �� Triggers 5&      P� 5'   "    P� Property � �� �� Empty P� Value# Z 6:   . �5(   &   ��  � ��# [ 6C   5)   #   P� 5*   "    � �� 6:   Z� . �5+   &   ��  � ��# [ 6C   5,   #   P� 5-   "    �@J�IsKeyboardFocused . . �5.   &   ��  � ��
 �����6C   5/   #   53      .��54   %   55      56      �� 57      $ 
Horizontal=�6   .+�58      �� $��	Password:��6   #��[  6-   G� 59      -   5         G�Name$ PasswordTextBox��59      $	��150��67   $��1��6C   ��. $��30��6a   5:      �� 5;      $��Center=�6   .+�5<      �� $��Капча:��6   $��Center=�6*   �� 5=      
���   �$��2q�6-   $
��auto��6A   ._�5>      �� -   5         ��Name$ CapchaTextBlock��5>       $��20(�69   $
��auto��6G   $��Center=�6T   5?      �� 5@      -   5        $ CapchaTextBox��5@      $	��150��61   $��Center=�6=   $��10q�6Z   $��30��6f   5A      �� 5B      $ 
Horizontal=�6   $��Center=�62   .+�5C      �� -   5         ��Name$ LoginButton��5C   D     SmallButtonBorder#��[ 6   ._�5D      �� $��Login��6    $��Center=�6-   $��Center=�6H   5E      �� 5F      -   5        $ CancelButton��5F   D   #��[ 6   ._�5G      �� $��Cancel��6    $��Center=�6.   $��Center=�6I   5H      5I      �� 5J      -   5        $ TimerTextBox��5J      $y�Hidden=�6.   $��Center=�6B   5L      �� 5M   
   $��Right=�6   $��Bottom=�61   .+�5N   
   �� -   5         ��Name$ DebugRunnerButton��5N      $&�� Перейти как бегун��6,   6H   �� 5O   
   -	   5        $ DebugCoordinatorButton��5O      $*��$Перейти как зритель��61   6O   �� 5P   
   -
   5        $ DebugViewerButton��5P      $6��0Перейти как администратор��6,   6P   �� 5Q   
   -   5        $ DebugAdminButton��5Q      $2��,Перейти как координатор��6+   6M   5R      5S      5T      