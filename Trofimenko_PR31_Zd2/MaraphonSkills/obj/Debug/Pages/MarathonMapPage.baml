   M S B A M L   `   `   `  ����I  EMaraphonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MaraphonSkills.PagesMaraphonSkills.Pages  5      *    $MaraphonSkills.Pages.MarathonMapPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MaraphonSkills.Pages     5        N� Title$  MarathonMapPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $"��../Resources/MarathonMap.png��6   $
��Left=�66   $	��380��6Q   $	��Top=�6^   �� 5   
   -   5         ��Name$ InteractiveMapCanvas��5      $��0��6/   .+�5      �� -   5        $��1��5         CircleButton#���   6!    �� Left$ 21��6H   
��� ���6m   �� 5      -   5        $��2��5      #���   6!   $ 58��6H   
 �� Top$	 119��6Y   
��� ���6~   �� 5      -   5        $��3��5      #���   6!   $	 131��6H   $	 330��6Z   
��� ���6   �� 5      -   5        $��4��5      #���   6!   $	 330��6H   
��� ���6n   �� 5      -   5        $��5��5      #���   6!   $	 330��6H   $	 266��6Z   
��� ���6   �� 5      -   5        $��6��5      #���   6!   $	 179��6H   $	 158��6Z   
��� ���6   5      �� 5   
   -   5         ��Name$ CheckPointInfoBorder��5      $��10q�5       �� Padding$ 5q�5      
���   �$��2q�5      $��1��5      $��Right=�5       $	��Top=�5!        SecondColor#��[ 5"      $	��300��5#      $	��200��5$      $y�	Collapsed=�5%      ._�5&      �� .+�5'      �� -	   5         ��Name$ 
CrossImage��5*      $��../Resources/cross.png��5'      $��15��5(      $��Right=�5)      5+      �� 5,      -
   5         ��Name$ CheckpointNameLabel��5,      �� 5-      $��Особенности:��6   �� 5.      -   5        	 ��Name$	 CheckpointPerksTextBlock��5.      5/      50      51      52      