   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.RequestWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  RequestWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� .+�5      �� $��ТехСервис��6   $��20(�6)   
��� � �$��6,3,6,6q�6J   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��
newRequest��5         AutoGenerateColumns .     CanUserAddRows .  
�������
��� � �$��5,33,5,5q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Id+  5      $ Дата создания��6)    6@   �� *	DateAdd+  5      $ Оборудование��6)    6?   �� *
Equpment+  5      $ Тип��6)    66   �� *Type+  5      $ Описание��6)    6;   �� *Description+  5      $ Клиент��6)    69   �� *Client+  5      $ Статус��6)    69   �� *Status+  5      $/ )Ответственный человек��6)    6H   �� *ResponsiblePerson+5      �� 5   
   -   5        $��addNewRequestBtn��5      $.��(Добавить новую заявку��6)   
�������
��� � �$��Bottom=�6o   $
��Left=�5      $��10q�64   6@   �� 5   
   -   5        $��editRequestBtn��5      $#��Изменить заявку��6'   
�������
��� � �$��Bottom=�6g   $
��Left=�5      $��
160,0,0,10q�64   6H   �� 5   
   -   5        $��backBtn��5      $��
Назад��6    
�������
��� � �$��Bottom=�6V   $
��Left=�5      $��
740,0,0,10q�64   6H   5       5!      