   M S B A M L   `   `   `  ����K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  5   	   8    2GestionEgresados.ViewController.consultarEgresados   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GestionEgresados.ViewController     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Consultar Egresados��5	   	   $	��500��6%   $	��800��62   .��5
      � .+�5   
   �� ���	#FFB9CDE0$
��Left=�6%   $��30��6@   $��
77,102,0,0q�6L   ���	#00000000$	��Top=�6s   $	��647��6�   �� 5   
   ���#27519B$��Center=�6#   $��35��6@   ���	#00000000$	��Top=�6_   $	��794��6w   �� 5   
   $��Consultar egresados��6   $��Center=�6.   $��Center=�6K   $	��222��6f   $��31��6r   $��282,3,288,435q�6~   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $��Selecciona un egresado��6   $��31��61   $��300,40,68,398q�6=   $��Arial)�6T   $��15(�6g   $
��Bold"�6u   
���   �6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridEgresados��5         SelectionMode$ Single=�6.      AutoGenerateColumns .     
IsReadOnly . $	��252��6t   $��77,132,68,0q�6�   $	��Top=�6�      RowBackground �	#FFF1E6E6   CanUserResizeRows .  ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��6c   
   HeaderStringFormat$
 Nombre��6s      Width5  /System.Windows.Controls.DataGridLengthConverter$	 210 6�      CanUserReorder .     CanUserResize .     CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *nombre+   ClipboardContentBinding 6@   Z� 6�     5      $	 
Matrícula��6f   $
 
Matrícula��6y   $	 100 6�    .   .   .   6%   �� *	matricula+ 6C   Z� 6�     5      $	 Correo��6c   $
 Correo��6s   $	 170 6�    .   .   .   6%   �� *correo+ 6@   Z� 6�     5      $	 	Teléfono��6e   $
 Telefono��6w   $	 100 6�    .   .   .   6%   �� *
telefono+ 6B   Z� 6�   5      �� 5   
   -   5        $��	Modificar��5      $
��Left=�6%   $��434,407,0,0q�6@   $	��Top=�6U   $	��139��6m   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6   $
��Bold"�6  
�������6   �� 5   
   -   5         ��Name$ 	btnVolver��5      $��Volver��6&   $
��Left=�67   $��
32,405,0,0q�6R   $	��Top=�6f   $��84��6~   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6$  �� 5   
   $��Filtrar por matrícula:��6   $��31��61   $��77,101,529,337q�6=   $��Arial)�6U   $��15(�6h   $
��Bold"�6v   
���   �6�   �� 5   
   -   5        $ 	btnBuscar��5      $��Buscar��6&   $
��Left=�67   $��383,103,0,0q�6R   $	��Top=�6g   $��83��6   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��24��6�   $��Arial)�6�   $��12(�6�   $
��Bold"�6   
�������6%  �� 5   
   -   5        $ btnMostrarTodos��5      $��Mostrar todos��6,   $
��Left=�6D   $��573,103,0,0q�6_   $	��Top=�6t   $	��119��6�   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��24��6�   $��Arial)�6�   $��12(�6   $
��Bold"�6  
�������63  �� 5   
   -   5         ��Name$ 
textFiltro��5      $
��Left=�6&   $��23��6A   $��234,102,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ 
btnAgregar��5      $��Agregar Nuevo��6'   $
��Left=�6?   $��260,407,0,0q�6Z   $	��Top=�6o   $	��140��6�   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6	  
�������6.  5      5       