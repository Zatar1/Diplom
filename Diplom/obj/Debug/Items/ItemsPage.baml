   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Diplom.ItemsDiplom.Items  5          Diplom.Items.ItemsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Diplom.Items     5      -   5          N� Title$  	ItemsPage��5	      .��5      � ���	#FFD9F3CA$��0,0,0,60q�6"    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   .+�5      �� $��/Other/search.png��6   $��30��6/   $��30��6:   $��15,0,0,0q�6F   �� 5      -   5        $��ItemSearchBox��5   (   $��5,5,15,5q�6   6=   �� 5       J� IsHitTestVisible .  $��Модель товара��61   $��-260,5,15,5q�6F   $��28(�6[   
���������5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�67    �� Triggers 5      �� 5      	 �� Binding	 6*   �� *Text+
 �� ElementName$
 ItemSearchBox�� �� Value  6^   .a�5   "   ��  � y�$ Visible=�6?   5       5"      5$      5&      �� 5(   
   $ 
Horizontal=�6   $��1��6.   $��Right=�6>   $��0,0,15,0q�6Z   .+�5)      �� $��Цена��6   $��28(�6$   $
��0,10q�64   $��75��6B   $
��Auto��6M   �� 5+      $ Vertical=�6   $��1��60   $��Center=�6@   .+�5-      �� $ 
Horizontal=�6   $��1��66   .+�5.      �� $��/Other/up.png��6   $��15��63   $��15��6>   �� 5/      -   5        $��UpCost��5/   6   $��15��6   $��15��6*   6D   50      �� 52      $ 
Horizontal=�6   $��1��66   .+�53      �� $��/Other/down.png��6   $��15��65   $��15��6@   �� 54      -   5        $��DownCost��54   6   $��15��6   $��15��6*   6F   55      57      58      �� 5:   
   $ 
Horizontal=�6   $��Right=�6.   $��	10,0,10,0q�6J   .+�5;      �� -   5        $��NewItem��5;      $	��150��69   $��	10,0,10,0q�6E   .��5<      �� $��  Добавить��6   $��28(�6.   $	��150��6>   5=      �� 5>      -   5        $��
DeleteItem��5>      $	��150��6?   .��5?      �� $��   Удалить��6   $��28(�6.   $	��150��6>   5@      5A      �� 5C   
   $ 
Horizontal=�6   $��Right=�6.   $��1��6J   $��	10,0,10,0q�6W   .+�5D      �� -   5        $��NewMark��5D      $	��250��69   $��	10,0,10,0q�6E   .��5E      �� $#�� + Производитель��6   $��28(�64   $	��250��6D   5F      �� 5G      -   5        $��NewTypeItem��5G      $	��250��6A   .��5H      �� $��   + Тип товара��6   $��28(�63   $	��250��6C   5I      5J      �� 5L   
   $ 
Horizontal=�6   $��1��6.   $
��Left=�6>   $��10,0,0,0q�6Y   .+�5M      �� $!��       Тип товара:��6   $��28(�62   $
��0,10q�6B   $	��210��6P   �� 5N      -	   5        $��	ComboType��5N      $��22(�6(    �� DisplayMemberPath$ ItemTypeName��68   6Y   5O      �� 5Q   
   $ 
Horizontal=�6   $��1��6.   $��1��6>   $
��Left=�6K   $��10,0,0,0q�6f   .+�5R      �� $!��Производитель:��6   $��28(�6.   $
��0,10q�6>   $	��210��6L   �� 5S      -
   5        $��	ComboMark��5S      $��22(�6(   $ MarkName��68    �� IsTextSearchEnabled . 6p   5T      �� 5W   
   -   5        $��	ItemsList��5X   K   $��2��5W      $��2��6    $��15q�64   $��Disabled=�6@    �� SelectionMode$ Single=�5X      $��Stretch=�6\   ��5Y      �� 5Z      .R�5[      �� 
���   �$��0,0,0,2q�61   ._�5\      � .+�5]      �� $
��Left=�6)   .+�5^   "   �� $
��auto��6V   $��36(�6c   ��6,   �� *TItemsTypes.ItemTypeName+6c   �� 5_   "   $
��auto��6L   $��28(�6Y   ��6,   �� *TMark.MarkName+6Y   �� 5`   "   $
��auto��6F   $��28(�6S   ��6,   �� *
ItemName+6S   �� 5a   "   $	��650��6I   $
��Wrap=�6U   $��18(�6i   $
��auto��6w   $��0,0,0,5q�6�   ��6,   �� *ItemDetails+6�   5b      �� 5d      $ 
Horizontal=�6)   $��Right=�6B   .+�5e   "   �� $ Vertical=�6-   .+�5f   &   �� $��Цена:  ��60   $
��auto��6?   $��28(�6L   $��Right=�6\   �� 5g   &   $��Количество:  ��60   $
��auto��6E   $��28(�6R   $��Right=�6b   5h   #   �� 5i   "   $ Vertical=�6-   .+�5j   &   �� $
��auto��6J   $��28(�6W   $
��Left=�6g   ��60   �� *
ItemCost+6g   �� 5k   &   $
��auto��6K   $��28(�6X   $
��Left=�6h   $��5,0,0,0q�6�   ��60   �� *	ItemCount+6�   5l   #   5m      5n      5o      5p      ��5r      �� 5s      " ��6   .�5t      -   5        5u      5w      5x      5y      