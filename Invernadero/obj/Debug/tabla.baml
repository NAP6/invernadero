   M S B A M L   `   `   `  ����F  BInvernadero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InvernaderoInvernadero  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          Invernadero.tabla   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Invernadero     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      $	��600��5	      $
��1024��6#     � 
ResizeMode$  NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F    � WindowStyle$
 None=�6k    � 	Resources 5         ScrollThumbs �� 
TargetType �� Property �� Value �� 
TargetType �Name	 ��Name
 �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5   
   %�  &	        '�� D    �� 5      " n�6)   .�5      ��  � �� 5      �� 5      " n�6*   .R�5      � $
 Grid��6#   .+�5   "   �� $��Stretch=�6,   $��Stretch=�6J   $
��Auto��6f   $
��Auto��6s   
������ 6�   �� 5   "   $	 
Rectangle1��6)   $
 10��6=   $��Stretch=�6O   $��Stretch=�6m   $
��Auto��6�   $
��Auto��6�   #��z��6�   5       5      P� 5   "    �@�Tag$ 
Horizontal��69   . �5   &   �� $ 
Rectangle1��6-    � ��$
 Auto��6V   �� 5   &   $ 
Rectangle1��6-    � ��$ 7��6W   5   #   5      5      5      �� 5"      " ��6/   .�5#      ��  �@��IsFlicksEnabled .  6;   �� 5$       � ��
 �����6/   �� 5%       � ��
 �����6/   �� 5&       � ��$ 10��6*   �� 5'       � �� 5(      �� 5)      " ��6*   .R�5*      � $ GridRoot��6#   $��19��65   ��6@   Z� .+�5+   "   ]� $ 
PART_Track��6(   $��0��6<   ��. |�.   5,   &   n� 5-   *   $ Thumb��60   #��z��6?   #���   6i    5/   &   �� 50   *   $ PageUp��67   $��ScrollBar.PageDownCommand��6G   $ 0Q�6k   |�.  6w    52   &   �� 53   *   $ PageDown��67   $��ScrollBar.PageUpCommand��6I   $ 0Q�6k   |�.  6w   55   #   56       58      P� 59   "   $ Thumb��6*    �@J�IsMouseOver . . �5:   &   �� # �  6-   $ Thumb��6Y    � ��6l   5;   #   P� 5<   "   $ Thumb��6*    �@n�
IsDragging . . �5=   &   �� # �  6-   $ Thumb��6Q    � ��6d   5>   #   P� 5@   "    � {� .  . �5A   &   �� $ Thumb��6-    � y�$ 	Collapsed=�6V   5B   #   P� 5C   "    �@��Orientation$ 
Horizontal=�6A   . �5D   &   �� $ GridRoot��6-    �@�LayoutTransform 5E   *   �� 5F   .   $	 -90Q�6>   5H   '   �� 5I   &   $ 
PART_Track��6-    �@�LayoutTransform 5J   *   �� 5K   .   $	 -90Q�6>   5M   '   �� 5N   &    � ��$
 Auto��6>   �� 5O   &    � ��$ 12��6?   �� 5P   &   $ Thumb��6-    �@�Tag$ 
Horizontal��6O   �� 5Q   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5R   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5S   #   5U      5W      5X      5Y      .��5]      �  � ColumnDefinitions 5^   
   �� 5_      $	��200 �6   �� 5`      $��* �6    � RowDefinitions 5b   
   �� 5c      $��30 �6   �� 5d      $��* �6   .+�5g   
   � -   5        $ GridBarraTitulo��5g      $��2��6N   ���	#FF8522BD.+�5h      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5i      �� -   5         ��Name$ btn_notificaciones��5i       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6V   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5j      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Bell=�6.   5k      �� 5l      -   5        $ 	btn_login��5l      #��[ 6D   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5m        $ Account=�6.   5n      �� 5o      -   5        $ BtnSalir��5o      #��[ 6B   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5p        $ Power=�6.   5q      5r      5s      � 5t   
   $��1��6   ��5u      �� 5v       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5w      �  � Color$ 	#FFC5C5C5��6#     � Offset$  1Q�65   � 5x      $ 	LightGray��6#   5y       5{      �� 5|      $	��100 �6    �� 5}      $��* �6    ! J� Effect! 5      3  -System.Windows.Media.Effects.DropShadowEffect  5�      "   
BlurRadius$" 20Q�6#   #   Color$# 	#FFECE4E4��63   $   RenderingBias$$ Quality=�6E   %   ShadowDepth$% 1Q�6]   .+�5�      � ���	#FFA46FE4.+�5�      �� $��INVERNADERO��6   $��Center=�6/   $��Center=�6L   $��Cooper Std Black)�6g   $��20(�6�   ���	#FFF6E6FF6�   5�      �� 5�      $��1��6   .+�5�      �� -   5        $ btn_escritorio��5�      $��10q�6N   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ViewDashboard=�62   $��Center=�6G   �� 5�      $��Center=�6$   $��
Escritorio��6A   $��Gadugi)�6S   5�      5�      �� 5�      -   5        $ 
btn_perfil��5�      $��10q�6F   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Account=�62   $��Center=�6A   �� 5�      $��Center=�6$   $��Perfil��6A   $��Gadugi)�6O   5�      5�      �� 5�      -   5        $ 
btn_tablas��5�      $��10q�6F   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ContentPaste=�62   $��Center=�6F   �� 5�      $��Center=�6$   $��Tablas��6A   $��Gadugi)�6O   5�      5�      �� 5�      -   5        $ btn_invernadero��5�      $��10q�6P   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Sprout=�62   $��Center=�6@   �� 5�      $��Center=�6$   $��Invernaderos��6A   $��Gadugi)�6U   5�      5�      �� 5�      -	   5        $ btn_control��5�      $��10q�6H   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ControllerClassic=�62   $��Center=�6K   �� 5�      $��Center=�6$   $��Control��6A   $��Gadugi)�6P   5�      5�      �� 5�      -
   5        $ btn_configuracion��5�      $��10q�6T   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Settings=�62   $��Center=�6B   �� 5�      $��Center=�6$   $��Configuracion��6A   $��Gadugi)�6V   5�      5�      5�      5�      � 5�   
   $��1��6   $��1��6   ���	#FFDEDFE0.+�5�      �� .��5�      �� $��5q�6   $	��400��6$   
�������$	��Top=�6F   & �� Padding$& 30q�6^   $
 10��6k   ! 5�        5�      $" 30Q�6+   $# 	LightGray��6;   $% 0Q�6M   ._�5�      �� $ Vertical=�6!   .+�5�      &   System.Windows.Controls.DataGrid  -   5        '  Name$' Tabla��5�   #   (   CanUserAddRows( .  )   SelectionUnit$
) Cell=�6I   *   SelectionMode$* Extended=�6^   5�      5�      5�      5�      5�      5�      