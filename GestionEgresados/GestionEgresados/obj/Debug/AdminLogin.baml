   M S B A M L   `   `   `  ����K  GGestionEgresados, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GestionEgresadosGestionEgresados  5   	   0    *GestionEgresados.ViewController.AdminLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GestionEgresados     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5	   	   $	��500��6   $	��800��6$   .��5
      � .+�5   
   �� ���#27519B$��Center=�6#   $��35��6@   ���	#00000000$	��Top=�6_   $	��794��6w   �� 5   
   $)��#Sistema de seguimiento de egresados��6   $��Center=�6>   $��Center=�6[   $	��376��6v   $��31��6�   $��210,4,206,434q�6�   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $��Iniciar sesión��6   $��Center=�6)   $��Center=�6F   $	��138��6a   $��31��6m   $��328,40,326,398q�6y   $��Arial)�6�   $��20(�6�   $
��Bold"�6�   
���   �6�   �� 5   
   $��Usuario��6   $
��Left=�6"   $��
305,80,0,0q�6=   $	��Top=�6Q   $��70��6i   $��33��6t   $��Right=�6�   $��16(�6�   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��305,146,0,0q�6@   $	��Top=�6U   $��89��6m   $��37��6x   $��Right=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ txt_user��5      $
��Left=�6$   $��23��6?   $��305,118,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��185��6�   G� 5   
   -   5         G�Name$ txt_pass��5      $
��Left=�6(   $��305,183,0,0q�6C   $	��Top=�6X   $	��185��6p   $��24��6|   �� 5   
   -   5        $��Iniciar sesión��5      $��328,370,326,0q�6*   $	��Top=�6A   ���	#FF00983D���	#FF00983D$��0,1,1,1q�6�   $��34��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6�   �� 5   
   $��Tipo de usuario��6   $
��Left=�6*   $��305,228,0,0q�6E   $	��Top=�6Z   $	��122��6r   $��38��6~   $��Right=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ cb_tipoUsuario��5      $
��Left=�6+   $��307,271,0,0q�6F   $	��Top=�6[   $	��183��6s   .@�5      �� .��6   Administrador6*   �� 5      .��6   
Egresado6%   �� 5      .��6   	Empleador6&   5      �� 5   
   -   5         ��Name$ 	btnVolver��5      $��Salir��6&   $
��Left=�66   $��
28,403,0,0q�6Q   $	��Top=�6e   $��85��6}   ���	#FF00983D���	#FF747C77$��0,1,1,1q�6�   $��36��6�   $��Arial)�6�   $��15(�6�   $
��Bold"�6�   
�������6#  5      5      