   M S B A M L   `   `   `  ����K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  5   	   .    (GestionEgresados.ViewController.Reportes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GestionEgresados.ViewController     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Reporte��5	   	   $	��500��6   $	��800��6&    � 
ResizeMode$ NoResize=�62   .��5
      � $
��Left=�6   $	��794��6&   .+�5   
   �� ���#27519B$��Center=�6#   $��35��6@   ���	#00000000$	��Top=�6_   $	��794��6w   �� 5   
   $��Reportes��6   $��Center=�6#   $��Center=�6@   $��97��6[   $��31��6f   $��339,4,358,436q�6r   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ prueba��5      $1��+Selecciona el/los egresados para el reporte��6!   $��Center=�6W   $��Center=�6t   $	��625��6�   $��31��6�   $��116,40,53,400q�6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridEgresados��5         SelectionMode$ Single=�6.      AutoGenerateColumns .     
IsReadOnly . $	��252��6t   $��116,71,115,0q�6�   $	��Top=�6�      RowBackground �	#FFF1E6E6	   CanUserResizeRows	 .  ��6�   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6h      HeaderStringFormat$ Nombre��6x      Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 6�      CanUserReorder .     CanUserResize .     CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ nombre�   ClipboardContentBinding 6E   Z� 6�     5      $ 	Matricula��6k   $ 
Matrícula��6~   $ 95 6�    .   .   .   6%   �� $ 	matricula� 6H   Z� 6�     5      $ Correo��6h   $ Correo��6x   $	 180 6�    .   .   .   6%   �� $ correo� 6E   Z� 6�     5      $ 	Teléfono��6j   $ Telefono��6|   $ 90 6�    .   .   .   6%   �� $ telefono� 6G   Z� 6�   5      �� 5   
   $��Selecciona la encuesta��6   $��Center=�61   $��Center=�6N   $	��176��6i   $��28��6u   $��116,328,502,115q�6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
���   � J� RenderTransformOrigin$ 0.665,0.417&�6�   �� 5   
   ���	#FFB9CDE0$
��Left=�6%   $��40��6@   $��116,356,0,0q�6L   ���	#00000000$	��Top=�6t   $	��563��6�   	� 5   
   -   5         	�Name$ rb_satisfaccion��5      $��Encuesta de satisfacción��6/   $
��Left=�6R   $��170,367,0,0q�6m   $	��Top=�6�   $��20��6�   $	��199��6�   $��Arial)�6�   $��15(�6�   ���	#FF1C7A426�   	� 5   
   -   5        $ 
rb_laboral��5      $&�� Encuesta de información laboral��6*   $
��Left=�6T   $��392,367,0,0q�6o   $	��Top=�6�   $��20��6�   $	��257��6�   $��Arial)�6�   $��15(�6�   ���	#FF1464346�   �� 5   
   -   5         ��Name$ btnGenerarReporte��5      $��Generar reporte��6.   $
��Left=�6H   $��314,417,0,0q�6c   $	��Top=�6x   $	��172��6�   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6  $
��Bold"�6  
�������67  �� 5   
   -   5        $ 	btnVolver��5      $��Salir��6&   $
��Left=�66   $��
28,417,0,0q�6Q   $	��Top=�6e   $��85��6}   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6#  5       5!      