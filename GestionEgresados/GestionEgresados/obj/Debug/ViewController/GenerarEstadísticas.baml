   M S B A M L   `   `   `  ����K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   :    4GestionEgresados.ViewController.GenerarEstadísticas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GestionEgresados.ViewController     5   	   DWpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	     � Title$  GenerarEstadísticas��5	   	   $	��450��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T   .��5
      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� ���	#FFB9CDE0$
��Left=�6%   $��33��6@   $��239,162,0,0q�6L   ���	#00000000$	��Top=�6t   $	��319��6�   �� 5   
   ���	#FFB9CDE0$
��Left=�6%   $��52��6@   $��
239,83,0,0q�6L   ���	#00000000$	��Top=�6s   $	��319��6�   �� 5   
   ���#27519B$��Center=�6#   $��35��6@   ���	#00000000$	��Top=�6_   $	��794��6w   $
��-1,0q�6�   �� 5   
   $��Generar Estadísticas��6   $��Center=�6/   $��Center=�6L   $	��211��6g   $��31��6s   $��297,4,286,386q�6   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $��Generar gráfica por:��6   $��Center=�6/   $��Center=�6L   $	��197��6g   $��39��6s   $��311,96,286,286q�6   $��Arial)�6�   $��18(�6�   $
��Bold"�6�   
���   � J� RenderTransformOrigin$ 0.665,0.417&�6�   	� 5   
   -   5         	�Name$ radioButtonGenero��5      $��Género��61   $
��Left=�6B   $��351,168,0,0q�6]   $	��Top=�6r   ���	#FF00983D6�   �� 5   
   -   5         ��Name$ btnGenerarEstadistica��5      $��Generar Estadística��62   $
��Left=�6P   $��311,365,0,0q�6k   $	��Top=�6�   $	��176��6�   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6  $
��Bold"�6  
�������6?  �� 5   
   ���	#FFB9CDE0$
��Left=�6%   $��33��6@   $��239,206,0,0q�6L   ���	#00000000$	��Top=�6t   $	��319��6�   	� 5   
   -   5        $ radioButtonCarrera��5      $��Carrera��62   $
��Left=�6D   $��351,212,0,0q�6_   $	��Top=�6t   ���	#FF00983D6�   �� 5   
   ���	#FFB9CDE0$
��Left=�6%   $��33��6@   $��239,251,0,0q�6L   ���	#00000000$	��Top=�6t   $	��319��6�   	� 5   
   -   5        $ radioButtonNivelEstudios��5      $��Nivel de estudios��68   $
��Left=�6T   $��351,257,0,0q�6o   $	��Top=�6�   ���	#FF00983D6�   �� 5   
   ���	#FFB9CDE0$
��Left=�6%   $��33��6@   $��239,295,0,0q�6L   ���	#00000000$	��Top=�6t   $	��319��6�   	� 5   
   -   5        $ radioButtonEstatusTrabajo��5      $��Estatus trabajo��6:   $
��Left=�6T   $��351,301,0,0q�6o   $	��Top=�6�   ���	#FF00983D6�   �� 5   
   -   5        $ 	btnVolver��5      $��Volver��6&   $
��Left=�67   $��
24,365,0,0q�6R   $	��Top=�6f   $��85��6~   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6$  5      5      