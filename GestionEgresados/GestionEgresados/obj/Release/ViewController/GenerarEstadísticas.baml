   M S B A M L   `   `   `  ���� K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf :    4GestionEgresados.ViewController.GenerarEstadísticas   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ?local-clr-namespace:GestionEgresados.ViewController     DWpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf       � Title$  GenerarEstadísticas��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� .+��� ���	#FFB9CDE0$
��Left=�$��33��$��239,162,0,0q����	#00000000$	��Top=�$	��319���� ���	#FFB9CDE0$
��Left=�$��52��$��
239,83,0,0q����	#00000000$	��Top=�$	��319���� ���#27519B$��Center=�$��35�����	#00000000$	��Top=�$	��794��$
��-1,0q��� $��Generar Estadísticas��$��Center=�$��Center=�$	��211��$��31��$��297,4,286,386q�$��Arial)�$��20(�$
��Bold"�
��������� $��Generar gráfica por:��$��Center=�$��Center=�$	��197��$��39��$��311,96,286,286q�$��Arial)�$��18(�$
��Bold"�
���   � J� RenderTransformOrigin$ 0.665,0.417&�	� -    	�Name$ radioButtonGenero��$��Género��$
��Left=�$��351,168,0,0q�$	��Top=����	#FF00983D�� -    ��Name$ btnGenerarEstadistica��$��Generar Estadística��$
��Left=�$��311,365,0,0q�$	��Top=�$	��176�����	#FF00983D���	#FF00983D$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
��������� ���	#FFB9CDE0$
��Left=�$��33��$��239,206,0,0q����	#00000000$	��Top=�$	��319��	� -   $ radioButtonCarrera��$��Carrera��$
��Left=�$��351,212,0,0q�$	��Top=����	#FF00983D�� ���	#FFB9CDE0$
��Left=�$��33��$��239,251,0,0q����	#00000000$	��Top=�$	��319��	� -   $ radioButtonNivelEstudios��$��Nivel de estudios��$
��Left=�$��351,257,0,0q�$	��Top=����	#FF00983D�� ���	#FFB9CDE0$
��Left=�$��33��$��239,295,0,0q����	#00000000$	��Top=�$	��319��	� -   $ radioButtonEstatusTrabajo��$��Estatus trabajo��$
��Left=�$��351,301,0,0q�$	��Top=����	#FF00983D�� -   $ 	btnVolver��$��Volver��$
��Left=�$��
24,365,0,0q�$	��Top=�$��85�����	#FF00983D���	#FF747C77$��0,1,1,1q�$��36��$��Arial)�$��15(�$
��Bold"�
�������