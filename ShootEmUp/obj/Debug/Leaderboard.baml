   M S B A M L   `   `   `  ����D  @ShootEmUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShootEmUp	ShootEmUp  5          ShootEmUp.Leaderboard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ShootEmUp     5      -   5        $��leaderboardControls��5   7     � 	Resources  5	         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%�  &	        �� 5
   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !    . ._�5      �� 5       5      P� 5       �@��
IsSelected	 . . �5   "   �� $
 _Border��6)    6T   Z�  � ���� 5   "    6E   Z�  �@�FocusVisualStyle�� 5   "    � ��
 � ���6?   5      5      5      5      5      .��5      �  � ColumnDefinitions 5    
   �� 5!      6!   �� 5"      6!   �� 5#      6!    � RowDefinitions 5%   
   �� 5&      6   �� 5'      6   �� 5(      6   .+�5*   
   �� $��Top 10 Players��6   
�������$��OCR A Extended)�6<   $��32(�6X   $��Center=�6f   $	��Top=�6�   $��1��6�   $��0��6�   &   System.Windows.Controls.DataGrid  5,   
   -   5        $��dataGridLeaderboard��5,   �     GridLinesVisibility$
 None=�6   |�.  $��1��6@   $��1��6P      CanUserAddRows .  $��Center=�6t   $��Center=�6�      CanUserSortColumns .     AutoGenerateColumns .     CanUserDeleteRows .     
IsReadOnly .    CanUserReorderColumns .  
��� ���$��OCR A Extended)�6�  $��32(�6�     RowBackground 6-  Z� ��6F  Z� ��6\  Z�    	CellStyle 5.      �� 5/      *  $System.Windows.Controls.DataGridCell"  6    �� Triggers 50      P� 51       �@ 
IsSelected	 . . �52      ��  � �� 53   "   �� 54   &    �� Color$ Transparent��66   56      �� 58       � ��
 � ���59      �� 5:       �@�FocusVisualStyle 6A   Z� �� 5;       � �� 5<   "   �� 5=   &   $ Transparent��66   5?      5@      5B         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ Player��6%      
Foreground
 �����   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H    �� 
IsSelected .     
FontFamily$ OCR A Extended)�6�      FontSize$ 32Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *
nickname+    ElementStyle  5G      �� 5H      " ��6    .�5I      ��  � ��$ Center=�6D   �� 5J       � �� 6;   Z� �� 5K       �@�FocusVisualStyle 6A   Z� 5L      5N        5O      $ Score��6%   $ * 64   
 ����� .  $ OCR A Extended)�6�   $ 32Q�6�    6Q   �� *score+  5P      �� 5Q      " ��6    .�5R      ��  � ��$ Center=�6D   �� 5S       � �� 6;   Z� �� 5T       �@�FocusVisualStyle 6A   Z� 5U      5W      !   ColumnHeaderStyle! 5Y      �� 5Z      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5[      ��  � ��
 ���� 63   �� 5\       � ��$ Center=�6C   5]      "   RowHeaderStyle" 5`      �� 5a      :  4System.Windows.Controls.Primitives.DataGridRowHeader"  6   .�5b      ��  � ��
 ���� 63   �� 5c       �@�FocusVisualStyle 69   Z� 5d      5f      �� 5h   
   -   5        $��controlsListbox��5h      |�. $��1��6:   $��2��6J   # �� SelectedIndex$# 0��6W   #���   6i   $ J� IsHitTestVisible$ .  $
��Auto=�5i      $
��Auto=�5j      
�������$��Center=�6�   $��Bottom=�6�   ��6D   Z� ��6n   Z� .@�5k      �� -   5        $��	menuLabel��5k   q   |�. $��Center=�6+   $��Bottom=�6H   $��32(�6c   $��OCR A Extended)�6�   .��6�   Back to menu6�   5l      5m      5n      