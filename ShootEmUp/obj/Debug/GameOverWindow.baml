   M S B A M L   `   `   `  ����D  @ShootEmUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShootEmUp	ShootEmUp  5   	       ShootEmUp.GameOverWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShootEmUp     5   	   -   5        $��gameOverWindow��5   Z     � Title$  GameOverWindow��6	    J� IsHitTestVisible .   � Cursor$
 None��69   
���   � � WindowState$ 	Maximized=�6p    � WindowStyle$
 None=�6�    � 	Resources 5	         _ListBoxItemStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Padding J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ��Name ��Name��%�  &	        '�� e    �� 5
   
   " ��6*   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      �� $��_Border��6!   $
 2q�5   !    . ._�5      �� 5       5      P� 5       �@��
IsSelected . . �5   "   �� $ _Border��6)    6T   Z�  � ���� 5   "    � ��
 � ���6?   5      5      5      5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5       "	 ��6&   .R�5!      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5"      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5#       5$      P� 5%       � {� .  . �5&   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5'      P� 5(       �@J�IsMouseOver . . �5)   "   �� $ border��6@    � �� �	#FF7EB4EA6T   5*      P� 5+       �@J�	IsFocused . . �5,   "   �� $ border��6@    6T   Z�  � ��5-      5/      51      52      53      .��54      � $
 None��6    � RowDefinitions 55   
   �� 56      $
��169* �6   6,   �� 57      $
��100* �6   6,   .+�59   
   r� -   5        $��gameoverbgmPlayer��59   ;   $y�	Collapsed=�6T    r� LoadedBehavior$ Manual=�6k   6�   �� 5:   
   -   5        $��scoreTextblock��5:      $��0��6*   $L��FScore: 
Game Over!
Inserisci il tuo nickname
per salvare il tuo record��67    �� TextAlignment$ Center=�6�   
�������$��32(�6�   $��OCR A Extended)�6�   $��Center=�6�   $��Center=�6  �� 5;   
   -   5        $��nicknameTextbox��5;   8   $�� ��6   
������� �� 	MaxLength$ 10��6�   $��32(�6�   $��OCR A Extended)�6�   $��0��6�   $��Center=�6�   $��Bottom=�6  $��397,10,397,0q�6*  ��6�   Z� ��6@  Z�  �� SelectionBrush 6W  Z� �� 5=   
   -   5        $��ListboxButtons��5=   -   $��Center=�6   #���   6C    .  $��1��6�   $
��Auto=�5>      $
��Auto=�5?      
�������$��0,0,0,40q�6�   ��6D   Z� ��6n   Z� .@�5@      �� -   5        $��	saveLabel��5@   D   $��32(�66   $��OCR A Extended)�6m   $��Center=�6�   $��Bottom=�6�   .��6�   Save6�   �� 5A      -   5        $��mainMenuLabel��5A   (   $��32(�6   $��OCR A Extended)�6Y   $��Center=�6u   $��Bottom=�6�   .��6�   Back to menu6�   5B      5C      5D      