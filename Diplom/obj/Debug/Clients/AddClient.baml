   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Diplom.ClientsDiplom.Clients  5          Diplom.Clients.AddClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Diplom.Clients     5        N� Title$  	AddClient��5	      .��5      � ���	#FFD9F3CA$��0,0,0,60q�6"    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Фамилия*��6   $��28(�6$   $
��auto��64   $��Right=�6A   $��0,0,10,0q�6]   �� 5   
   $��1��6   $��28(�6!   $��Имя*��61   $
��auto��6=   $��Right=�6J   $��0,0,10,0q�6f   �� 5   
   $��2��6   $��28(�6!   $��Отчество ��61   $
��auto��6B   $��Right=�6O   $��0,0,10,0q�6k   �� 5   
   $��3��6   $��28(�6!   $��Телефон*��61   $
��auto��6A   $��Right=�6N   $��0,0,10,0q�6j   �� 5   
   $��4��6   $��28(�6!   $��E-mail ��61   $
��auto��6@   $��Right=�6M   $��0,0,10,0q�6i   �� 5   
   $��1��6   $
��Left=�6"    �� 	MaxLength$ 25��6\   ��6=   �� *ClientSurname+6\   �� 5    
   $��1��6   $��1��6"   $
��Left=�6/   $ 25��6f   ��6J   �� *
ClientName+6f   �� 5!   
   $��1��6   $��2��6"   $
��Left=�6/   $ 25��6l   ��6J   �� *ClientPatronymic+6l   �� 5"   
   -   5        $��TxtPhone��5"   �   $��1��6   $��3��6"   $
��Left=�6/   $	��200��6�   $ 11��6�   ��6J   �� *ClientPhone+6�   �� 5#   
   $��1��6   $��4��6"   $
��Left=�6/   $
��auto��6J   $	��350��6W   $ 50��6�   ��6f   �� *ClientEmail+6�   �� 5&   
   -   5        $��BtnSaveClient��5&      $��1��6A   $��5��6Q   $	��200��6^   $��Right=�6j   $��0,0,15,0q�6�   .��5'      �� $��Сохранить��6   $��28(�6)   5(      5)      5*      