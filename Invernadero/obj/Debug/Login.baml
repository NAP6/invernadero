   M S B A M L   `   `   `  ����F  BInvernadero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InvernaderoInvernadero  5   	       Invernadero.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Invernadero     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA46FE4��6#   � 5      $ 	#FF340051��6#    � Offset$ 1Q�65   � 5      $ 	#FF8522BD��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V   	 �� RadiusX$	 10��6c   
�������
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5       �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��5q�6Y   
�������$��18(�6v   �� 5!      $��Center=�6   $��15q�64   .+�5"      �� -   5         ��Name$ box_usuario��5"      $
��0,10q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ UASUARIO��6=    %  !MaterialDesignFloatingHintTextBox#��[  6g   $��Champagne & Limousines)�6�   $��18(�6�   G� 5#      -   5         G�Name$ box_contrasenia��5#      $
��0,10q�67   $ CONTRASEÑA��6E    ) %MaterialDesignFloatingHintPasswordBox#��[ 6q   $��Champagne & Limousines)�6�   $��18(�6�   5$      5%      �� 5&   
   -   5        $	��150��5&      $��Center=�6   $��Bottom=�6:   $
��0,65q�6U   $��LOGIN��6c   ���	#FF8522BD6�   �� 5'   
   $%��Ingreso al perfil deinvernadero��6   $��Center=�6<   $��Bottom=�6Y   $��30q�6t   
������� � Cursor$
 Hand��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5(   
      Kind$ Sprout=�6"   $	��100��60   $	��100��6<   $��Center=�6I   
�������$	��Top=�6y   $��30q�6�   5)      5*      