   M S B A M L   `   `   `  ����K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestionEgresados.ViewControllerGestionEgresados.ViewController  5   	   7    1GestionEgresados.ViewController.modificarEgresado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GestionEgresados.ViewController     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ modificarEgresado��5	   	   $	��570��6#   $	��565��60   .��5
      � .+�5   
   �� -   5         ��Name$ labelMatricula��5      $��
Matrícula��6(   $
��Left=�6<   $��	49,83,0,0q�6W   $	��Top=�6j   $��16(�6�   $��Arial Black)�6�   �� 5   
   -   5        $ labelNombre��5      $��Nombre��6%   $
��Left=�66   $��
49,145,0,0q�6Q   $	��Top=�6e   $��16(�6}   $��Arial Black)�6�   �� 5   
   -   5        $ labelApellidos��5      $��	Apellidos��6(   $
��Left=�6<   $��
50,212,0,0q�6W   $	��Top=�6k   $��16(�6�   $��Arial Black)�6�    J� RenderTransformOrigin$ 0.511,-0.462&�6�   �� 5   
   -   5        $ labelLicenciatura��5      $��Licenciatura��6+   $
��Left=�6B   $��
50,275,0,0q�6]   $	��Top=�6q   $��16(�6�   $��Arial Black)�6�   �� 5   
   -   5        $ labelCorreo��5      $��Correo��6%   $
��Left=�66   $��
50,337,0,0q�6Q   $	��Top=�6e   $��16(�6}   $��Arial Black)�6�   �� 5   
   -   5         ��Name$ textboxCorreo��5      $
��Left=�6)   $��29��6D   $��274,337,0,0q�6P   $	��Top=�6e   $	��264��6}   $��14(�6�    �� 	MaxLength$ 50��6�   �� 5   
   -   5        $ textboxNombre��5      $
��Left=�6)   $��29��6D   $��274,145,0,0q�6P   $	��Top=�6e   $	��264��6}   $��14(�6�   $ 50��6�   �� 5   
   -   5        $ textboxApellidos��5      $
��Left=�6,   $��29��6G   $��274,212,0,0q�6S   $	��Top=�6h   $	��264��6�   $��14(�6�   $ 50��6�   �� 5   
   -	   5        $ textboxMatricula��5      $
��Left=�6,   $��29��6G   $��
274,80,0,0q�6S   $	��Top=�6g   $	��264��6   $��14(�6�   $ 50��6�   �� 5   
   $��	Teléfono��6   $
��Left=�6#   $��
49,402,0,0q�6>   $	��Top=�6R   $��16(�6j   $��Arial Black)�6x   �� 5   
   -
   5        $ textboxTelefono��5      $
��Left=�6+   $��29��6F   $��274,402,0,0q�6R   $	��Top=�6g   $	��264��6   $��14(�6�   $ 50��6�   �� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6'   $
��Left=�69   $��426,482,0,0q�6T   $	��Top=�6i   $��98��6�   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��33��6�   $��Arial)�6�   $��12(�6�   $
��Bold"�6  
�������6'  �� 5   
   -   5        $ 	btnVolver��5      $��Volver��6&   $
��Left=�67   $��
21,482,0,0q�6R   $	��Top=�6f   $��83��6~   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��33��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6$  �� 5   
   ���#27519B$��Center=�6#   $��35��6@   ���	#00000000$	��Top=�6_   $	��557��6w   $��-1,0,1,0q�6�   �� 5   
   $��Datos egresado��6   $��Center=�6)   $��Center=�6F   $	��170��6a   $��31��6m   $��196,4,191,505q�6y   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ comboLicenciatura��5      $
��Left=�6.   $��274,275,0,0q�6I   $	��Top=�6^   $	��264��6v   .@�5      �� $��Ingeniería de Software��6   $
��Left=�6<   $	��262��6W   �� 5      $#��Redes y servicios de cómputo��6   $
��Left=�6B   $	��262��6]   �� 5      $%��Tecnologías de la computación��6   $
��Left=�6C   $	��262��6^   5      5      5       