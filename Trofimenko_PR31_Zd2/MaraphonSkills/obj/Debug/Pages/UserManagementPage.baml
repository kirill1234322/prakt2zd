   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      -    'MaraphonSkills.Pages.UserManagementPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  UserManagementPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       '�� I     '�� �     �� 5   
   " ��6   .�5      ��  � ��$	 150��6&   5      �� 5   
   " ��6   .�5      ��  � ��$	 100��6&   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      .+�5   
   �� $7��1Управление пользователями��6   $��Center=�64   $	��Top=�6Q   $��0��6i   � 5   
   $��1��6   $��Center=�6!   .+�5      �� -   5         ��Name$ AddNewUserButton��5   }      SmallButtonBorder#��[  6   $��Center=�6E   $��Center=�6b   ._�5       �� $)��#+ Добавление нового��6    $
��Wrap=�6;   5!      �� 5"      .+�5#      ��  �� Orientation$ 
Horizontal=�6!   .+�5$      �� $#��Фильтр по ролям:��6$     DescriptionTextBlock#��[ 6<   �� 5%      -   5         ��Name$ RoleFilterComboBox��5%   #   	 �� SelectedValue	 6?   �� *RoleId+5&      �� 5'      $ 
Horizontal=�6!   .+�5(      �� $"��Сортировать по:��6$   #��[ 6;   �� 5)      -   5        $ SortComboBox��5)   #   5*      �� 5+      $ 
Horizontal=�6!   .+�5,      �� $��Поиск:��6$   #��[ 62   �� 5-      -   5        
 ��Name$
 SearchTextBox��5-   "   5.      �� 5/      -   5        $ RefreshButton��5/   e   #��[  6   $��Center=�6H   ._�50      �� $��Обновить��6$   51      52      53      �� 54   
   -   5         ��Name$ UserCountTextBlock��54      $
��Left=�60   $��Bottom=�6K   $��1��6f   �� 56   
   $��Visible=�6   $��2��6=   .��57      &   System.Windows.Controls.DataGrid  -   5          Name$ UsersDataGrid��57   3      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6\      Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	FirstName+  5:      $ Фамилия��6)    6:   �� *
LastName+  5;      $ Email��6)    69   �� *Email+  5<      $ Роль��6)    68   �� *Role.RoleName+4  .System.Windows.Controls.DataGridTemplateColumn  5=         Width$	 100 6-      CellTemplate 5>      �� 5?      .R�5@   "   �� $ 
EditButton��6T   -   5        #��[  5@   )   ._�5A   &   �� $
��Edit��60   5B   #   5C      5E      5G      5H      5I      5J      