   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      #    MaraphonSkills.Pages.HowLongs   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  HowLongs��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��66 �6   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��90 �6   �� 5      $��50 �6   �� 5      �� 5      $
��Auto �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��162.034 �6   �� 5      $��157.966 �6   �� 5      $��6 �6   �� 5      $��178.288 �6   �� 5      $��141.712 �6   �� 5      .+�5"   
   �� $��148,26,100,44q�6   $
��Wrap=�6+   $��22(�6?   
���   � �� TextAlignment$ Center=�6`   $��5��6w   $��1��6�   $5��/Насколько долгий марафон?��6�   $��2��6�   �� 5#   
   -   5        $��txtName��5#      $��
14,10,10,3q�6#   $
��Wrap=�67   $��22(�6K   ���	#FF6C6C6C$ Center=�6p   $��2��6�   $��1��6�   $��2��6�   $.��(Имя выбранного пункта��6�   �� 5$   
   -   5        $��txtName2��5$      $��10,37,14,42q�6$   $
��Wrap=�69   $��22(�6M   ���	#FF6C6C6C$ Center=�6r   $��2��6�   $��1��6�   $��1��6�   $.��(Имя выбранного пункта��6�   $��2��6�   �� 5&   
   $��2��5'      $��4��5(      $
��Left=�5)      $��1��5*      $��6��5+      $	��263��5,      $��
57,61,0,10q�5-      .@�5.      �� $��Скорость��6    �� 
IsSelected . .��5/      � ���	#FFE5E5E5.+�50      &   System.Windows.Controls.DataGrid  -   5          Name$ 	gridSpeed��50      $
��Left=�62   $	��257��6M      HeadersVisibility$
 None=�6Y      AutoGenerateColumns .     SelectionMode$ Single=�6�   $��0,0,0,-2q�6�   	   Columns	 51      4  .System.Windows.Controls.DataGridTemplateColumn  52      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Logo��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6C      CellTemplate 53   "   �� 54   &   .R�55   *   �� $	��100��60   ��6=   �� *Image+56   '   58      0  *System.Windows.Controls.DataGridTextColumn  59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Name+5;      5=      5>      �� 5?      $��
Длина��6   .��5@      � ���	#FFE5E5E5.+�5A        -   5        $��gridDistance��5A      $
��Left=�63   $	��276��6N   $	��Top=�6[   $	��257��6s   $
 None=�6    .  $ Single=�6�   	 5B        5C      $

 Logo��65   $ 1* 6C    5D   "   �� 5E   &   .R�5F   *   �� $	��100��60   ��6=   �� *Image+5G   '   5I        5J       61   �� *Name+5L      5M      5N      5O      �� 5P   
   -   5        $��txtInfo��5P      $�� ��6#   $��1��6+   $��65,25,65,74q�6;   $��5��6P   $
��Wrap=�6]   $��2��6r   $��16(�6�   $ Center=�6�   $��2��6�   �� 5Q   
   -   5        $��txtInfo2��5Q      $�� ��6$   $��1��6,   $��65,29,65,10q�6<   $��6��6Q   $
��Wrap=�6^   $��2��6s   $��16(�6�   $ Center=�6�   �� 5S   
   -   5        $��imgInfo��5S      $��1��6   $	��125��6/   $��
10,10,10,0q�6<   $��3��6P   $��3��6]   $	��Top=�6n   $��2��6�   5T      5U      