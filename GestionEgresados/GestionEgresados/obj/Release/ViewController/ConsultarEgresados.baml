   M S B A M L   `   `   `  ���� K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  8    2GestionEgresados.ViewController.consultarEgresados   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:GestionEgresados.ViewController       � WindowStartupLocation$  CenterScreen=� � Title$ Consultar Egresados��$	��500��$	��800��.��� .+��� ���#27519B$��Center=�$��35�����	#00000000$	��Top=�$	��794���� $��Consultar egresados��$��Center=�$��Center=�$	��222��$��31��$��282,3,288,435q�$��Arial)�$��20(�$
��Bold"�
��������� $��Selecciona un egresado��$��31��$��300,34,306,404q�$��Arial)�$��15(�$
��Bold"�
���   �&   System.Windows.Controls.DataGrid  -     Name$ dataGridEgresados��   SelectionMode$ Single=�   AutoGenerateColumns .     
IsReadOnly . $	��252��$��77,102,68,0q�$	��Top=�   RowBackground �	#FFF1E6E6   CanUserResizeRows .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��
   HeaderStringFormat$
 Nombre��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 190    CanUserReorder .     CanUserResize .     CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ nombre�   ClipboardContentBinding Z�   $	 
Matrícula��$
 
Matrícula��$	 100  .   .   .   �� $ 	matricula� Z�   $	 Correo��$
 Correo��$	 170  .   .   .   �� $ correo� Z�   $	 	Teléfono��$
 Telefono��$ 85  .   .   .   �� $ telefono� Z�   $	 Genero��$
 Genero��$ 75  .   .   .   �� $ genero� Z� �� -   $��	Modificar��$
��Left=�$��568,408,0,0q�$	��Top=�$	��106�����	#FF00983D���	#FF747C77$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
��������� -    ��Name$ 	btnVolver��$��Salir��$
��Left=�$��
61,405,0,0q�$	��Top=�$��85�����	#FF00983D���	#FF747C77$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
�������