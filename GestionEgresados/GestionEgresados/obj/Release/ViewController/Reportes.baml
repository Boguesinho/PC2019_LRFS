   M S B A M L   `   `   `  ���� K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  .    (GestionEgresados.ViewController.Reportes   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:GestionEgresados.ViewController       � WindowStartupLocation$  CenterScreen=� � Title$ Reporte��$	��500��$	��800�� � 
ResizeMode$ NoResize=�.��� $
��Left=�$	��794��.+��� ���#27519B$��Center=�$��35�����	#00000000$	��Top=�$	��794���� $��Reportes��$��Center=�$��Center=�$��97��$��31��$��339,4,358,436q�$��Arial)�$��20(�$
��Bold"�
��������� -    ��Name$ prueba��$1��+Selecciona el/los egresados para el reporte��$��Center=�$��Center=�$	��625��$��31��$��116,40,53,400q�$��Arial)�$��15(�$
��Bold"�
���   �&   System.Windows.Controls.DataGrid  -     Name$ dataGridEgresados��   SelectionMode$ Single=�   AutoGenerateColumns .     
IsReadOnly . $	��252��$��116,71,115,0q�$	��Top=�   RowBackground �	#FFF1E6E6	   CanUserResizeRows	 .  ���� 
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��   HeaderStringFormat$ Nombre��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 170    CanUserReorder .     CanUserResize .     CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ nombre�   ClipboardContentBinding Z�   $ 	Matricula��$ 
Matrícula��$ 95  .   .   .   �� $ 	matricula� Z�   $ Correo��$ Correo��$	 180  .   .   .   �� $ correo� Z�   $ 	Teléfono��$ Telefono��$ 90  .   .   .   �� $ telefono� Z� �� $��Selecciona la encuesta��$��Center=�$��Center=�$	��176��$��28��$��116,328,502,115q�$��Arial)�$��15(�$
��Bold"�
���   � J� RenderTransformOrigin$ 0.665,0.417&��� ���	#FFB9CDE0$
��Left=�$��40��$��116,356,0,0q����	#00000000$	��Top=�$	��563��	� -    	�Name$ rb_satisfaccion��$��Encuesta de satisfacción��$
��Left=�$��170,367,0,0q�$	��Top=�$��20��$	��199��$��Arial)�$��15(����	#FF1C7A42	� -   $ 
rb_laboral��$&�� Encuesta de información laboral��$
��Left=�$��392,367,0,0q�$	��Top=�$��20��$	��257��$��Arial)�$��15(����	#FF146434�� -    ��Name$ btnGenerarReporte��$��Generar reporte��$
��Left=�$��314,417,0,0q�$	��Top=�$	��172�����	#FF00983D���	#FF00983D$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
��������� -   $ 	btnVolver��$��Salir��$
��Left=�$��
28,417,0,0q�$	��Top=�$��85�����	#FF00983D���	#FF747C77$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
�������