   M S B A M L   `   `   `  ����>  :UI3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UI3UI3  5   	       UI3.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:UI3     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
AdminsGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 UserID��6<   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 120 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6L     5      $	 Title��6?   $	
 125 6N    6%   �� *Title+6N     5      $
	 Name��6>   $	
 125 6L    6%   �� *Name+6L     5      $
	 Date��6>   $
 80 6L    6%   �� *Date+6L   5      �� 5   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5      �� -   5         ��Name$ updateButton��5      $��Обновить��6+   6>   5       5!      5"      