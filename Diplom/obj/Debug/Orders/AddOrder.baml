   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Diplom.OrdersDiplom.Orders  5          Diplom.Orders.AddOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Diplom.Orders     5        N� Title$  AddOrder��5	      .��5      � ���	#FFD9F3CA$��0,0,0,60q�6"    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Тип заказа*��6   $��28(�6'   $
��auto��67   $��Right=�6D   $��0,0,10,0q�6`   �� 5   
   $��1��6   $��Клиент*��6!   $��28(�60   $
��auto��6@   $��Right=�6M   $��0,0,10,0q�6i   �� 5   
   $��2��6   $*��$Подробности заказа*��6!   $��28(�6<   $
��auto��6L   $��Right=�6Y   $��0,0,10,0q�6u   �� 5   
   $��4��6   $��Стоимость*��6!   $��28(�63   $
��auto��6C   $��Right=�6P   $��0,0,10,0q�6l   �� 5   
   $��5��6   $��Выполнено ��6!   $��28(�63   $
��auto��6C   $��Right=�6P   $��0,0,10,0q�6l   �� 5    
   -   5        $��ComboTypeOrder��5    t   $��1��6   $
��Left=�6#   $��22(�6d    �� DisplayMemberPath$ OrderTypeName��6�    �� SelectedItem 6>   �� *TOrdersTypes+6�   �� 5!   
   -   5        $��ComboClientOrder��5!   �   $��1��6   $��22(�6#   $��1��63   $
��Left=�6@   $	��600��6[    �� IsTextSearchEnabled . $ 	ClientFIO��6�    6g   �� *
TClients+6�   �� 5"   
   $��1��6   $��2��6"   $��2��6/   $
��auto��6A   $	��120��6O   $��	0,15,0,15q�6_   $��Stretch=�6r   $	��600��6�    �� TextWrapping$ WrapWithOverflow=�6�   $
��Left=�6�   ��6�   �� *OrderDetails+�� 5#   
   -   5        $��TxtCost��5#   d   $��1��6   $��4��6"   $
��Left=�6/   $	��150��6J    �� 	MaxLength$ 5��6V   ��6�   �� *	OrderCost+�� 5$   
   $��1��6   $��5��6#   $
��Left=�60   $��Center=�6K    d� 	IsChecked 6g   �� *OrderComplete+	 � LayoutTransform	 5%      �� 5&      
 �� ScaleX$	
 2.3Q�6!    �� ScaleY$	 2.3Q�6.   5(      �� 5*   
   -   5        $��BtnSaveOrder��5*      $��1��6?   $��7��6O   $	��200��6\   $��Right=�6h   $��0,0,15,0q�6�   .��5+      �� $��28(�6   $��Сохранить��6(   5,      5-      5.      