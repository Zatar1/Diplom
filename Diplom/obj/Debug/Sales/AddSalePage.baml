   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Diplom.SalesDiplom.Sales  5          Diplom.Sales.AddSalePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Diplom.Sales     5        N� Title$  AddSalePage��5	      .��5      � ���	#FFD9F3CA$��0,0,0,60q�6"    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Клиент*��6   $��28(�6#   $
��auto��63   $��Right=�6@   $��0,0,10,0q�6\   �� 5   
   -   5        $��TxtBlockItem��5   )   $��Выбор товара*��6   $��1��6=   $��28(�6J   $
��auto��6Z   $��Right=�6g   $��0,0,10,0q�6�   �� 5   
   $��4��6   $,��&Подробности продажи ��6!   $��28(�6=   $
��auto��6M   $��Right=�6Z   $��0,0,10,0q�6v   �� 5   
   $��6��6   $��Стоимость: ��6!   $��28(�64   $
��auto��6D   $��Right=�6Q   $��0,0,5,0q�6m   �� 5    
   -   5        $��ComboClientSale��5    �   $��1��6   $��22(�6#   $
��Left=�64    �� IsTextSearchEnabled . $	��250��6�   $
��auto��6�   {�.   �� DisplayMemberPath$ 	ClientFIO��6�    �� SelectedItem 6O   �� *
TClients+6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��ItemsDataGrid��5"      $��1��5!      $��1��6    $��18(�60   $��3��6>   $��	0,15,0,15q�6O   $	��600��6b   $
��auto��6n   $	��160��6|   $
��Left=�6�      HeadersVisibility$
 None=�6�   $y�Hidden=�6�      CanUserDeleteRows .     AutoGenerateColumns .  ��5"   ^   �� *listItemsViewModel+ 6�   �� *SelectedElement+	   Columns	 5#      4  .System.Windows.Controls.DataGridComboBoxColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6)   -   5        Itm��   DisplayMemberPath$ ItemInf��5$   m      SelectedItemBinding 63   �� *selectedItem+6m   5&      �� 5'   
   -   5        $��ItemsListBox��5(      $��1��5'      $��1��6   $��18(�6/   $��3��6=   $��	0,15,0,15q�6N   $	��600��6a   $
��auto��6m   $	��160��6{   $
��Left=�6�   $
 Info��5(   R   {�.  $y�Hidden=�6}   ��6'   �� *listItemsViewModel+ 6�   �� *SelectedElement+�� 5)   
   -   5        $��
TxtDetails��5)   �   $��1��6   $��4��6"   $��2��6/   $	��600��6@    �� TextWrapping$ WrapWithOverflow=�6L   $
��Left=�6l   $
��auto��6�   $	��120��6�   $��	0,15,0,15q�6�   $��Stretch=�6�   ��6�   �� *SaleDetails+6�   �� 5*   
   -   5        $��TxtCost��5*   v   $��1��6   $��6��6"   $
��Left=�6/   $	��150��6J   {�.   �� 	MaxLength$ 5��6h   ��6�   �� *
SaleCost+�� 5,   
   -   5        $��BtnSaveSale��5,      $��1��6=   $��7��6M   $	��200��6Z   $��Right=�6f   $��0,0,15,0q�6�   .��5-      �� $��28(�6   $��Сохранить��6(   5.      5/      50      