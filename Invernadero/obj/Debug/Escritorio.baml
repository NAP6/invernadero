   M S B A M L   `   `   `  ����F  BInvernadero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InvernaderoInvernadero  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          Invernadero.Escritorio   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      +localclr-namespace:Invernadero     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      $	��600��5	      $
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
Horizontal��6O   �� 5Q   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5R   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5S   #   5U      5W      5X      5Y      .��5]      �  � ColumnDefinitions 5_   
   �� 5`      $	��200 �6   �� 5a      $��* �6    � RowDefinitions 5c   
   �� 5d      $��30 �6   �� 5e      $��* �6   .+�5h   
   � -   5        $ GridBarraTitulo��5h      $��2��6N   ���	#FF8522BD.+�5i      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5j      �� -   5         ��Name$ btn_notificaciones��5j       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6V   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5k      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Bell=�6.   5l      �� 5m      -   5        $ 	btn_login��5m      #��[ 6D   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5n        $ Account=�6.   5o      �� 5p      -   5        $ BtnSalir��5p      #��[ 6B   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5q        $ Power=�6.   5r      5s      5t      � 5v   
   $��1��6   ��5w      �� 5x       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5y      �  � Color$ 	#FFC5C5C5��6#     � Offset$  1Q�65   � 5z      $ 	LightGray��6#   5{       5}      �� 5~      $	��100 �6    �� 5      $��* �6    ! J� Effect! 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      "   
BlurRadius$" 20Q�6#   #   Color$# 	#FFECE4E4��63   $   RenderingBias$$ Quality=�6E   %   ShadowDepth$% 1Q�6]   .+�5�      � ���	#FFA46FE4.+�5�      �� $��INVERNADERO��6   $��Center=�6/   $��Center=�6L   $��Cooper Std Black)�6g   $��20(�6�   ���	#FFF6E6FF6�   5�      �� 5�      $��1��6   .+�5�      �� -   5        $ btn_escritorio��5�      $��10q�6N   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ViewDashboard=�62   $��Center=�6G   �� 5�      $��Center=�6$   $��
Escritorio��6A   $��Gadugi)�6S   5�      5�      �� 5�      -   5        $ 
btn_perfil��5�      $��10q�6F   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Account=�62   $��Center=�6A   �� 5�      $��Center=�6$   $��Perfil��6A   $��Gadugi)�6O   5�      5�      �� 5�      -   5        $ 
btn_tablas��5�      $��10q�6F   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ContentPaste=�62   $��Center=�6F   �� 5�      $��Center=�6$   $��Tablas��6A   $��Gadugi)�6O   5�      5�      �� 5�      -   5        $ btn_invernadero��5�      $��10q�6P   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Sprout=�62   $��Center=�6@   �� 5�      $��Center=�6$   $��Invernaderos��6A   $��Gadugi)�6U   5�      5�      �� 5�      -	   5        $ btn_control��5�      $��10q�6H   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ ControllerClassic=�62   $��Center=�6K   �� 5�      $��Center=�6$   $��Control��6A   $��Gadugi)�6P   5�      5�      �� 5�      -
   5        $ btn_configuracion��5�      $��10q�6T   ���	#FF8522BD���	#FFA46FE4.��5�      � $	��150��6   .+�5�        $ Settings=�62   $��Center=�6B   �� 5�      $��Center=�6$   $��Configuracion��6A   $��Gadugi)�6V   5�      5�      5�      5�      � 5�   
   $��1��6   $��1��6   ���	#FFDEDFE0.+�5�      �� .��5�      �  5�      �� 5�      $	��200 �6(   �� 5�      $��1* �6(   �� 5�      $��1* �6(   �� 5�      $��1* �6(    5�      �� 5�      $��1* �6+   �� 5�      $��1* �6+   �� 5�      $��1* �6+   .+�5�      � $��0��6   $��0��6(   .+�5�      �� $	��120��6$   $��20q�61   
�������& �� RadiusY$& 10��6J   ' �� RadiusX$' 10��6W   ! 5�        5�   "   $" 20Q�63   $# 	#FFD1D1D1��6C   $$ Quality=�6U   $% 1Q�6m   5�      � 5�      $��25q�6   $	��120��6+   .+�5�      � $��35��6#   $��50��6.   ���	#FFFFAF24$
��Left=�6Q   $	��Top=�6l   $
��20 0q�6�   ! 5�   "     5�   &   $" 20Q�67   $# 	#FFECECEC��6G   $$ Quality=�6Y   $% 1Q�6q   .+�5�   "     $ ThermometerLow=�6:   $��Center=�6P   $��Bottom=�6m   $��5q�6�   
�������$��20��6�   $��20��6�   5�      �� 5�      $��Temperatura��6(   $��Right=�6;   $��Comic Sans MS)�6W   $��5q�6r   $	��Top=�6}   
�������6�   �� 5�      $ 
Horizontal=�6)   $��Right=�6B   $��Center=�6^   $��10 20q�6y   .+�5�   "   �� -   5        ( ��Name$( Temperatura_interior��5�   ,   $��Comic Sans MS)�6s   $��Center=�6�   
�������$��50(�6�   ��6J   �� ) �� Path$) InternoTemperatura�6�   �� 5�   "   $��Comic Sans MS)�6U   $��Center=�6p   
�������$��20(�6�   ��6,   �� $) ExternoTemperatura�6�     5�   "   $ TemperatureCelsius=�6:   $
��0 5 q�6T   $��Bottom=�6b   
�������$��20(�6�   5�      �� 5�      $ 
Horizontal=�6)   $��Bottom=�6B   $��20q�6]   * � Cursor$
* Hand��6i   .+�5�   "     $ AlertOutline=�6:   
���  ��$��10��6_   $��10��6j   $��Center=�6v   $	��5 0q�6�   �� 5�   "   $��Temperatura muy alta��6,   $��8(�6H   ���	#FF8522BD6U   5�      5�      5�      � 5�      $��0��6   $��1��6(   .+�5�      �� $	��120��6$   $��20q�61   
�������$& 10��6J   $' 10��6W   ! 5�        5�   "   $" 20Q�63   $# 	#FFD1D1D1��6C   $$ Quality=�6U   $% 1Q�6m   5�      � 5�      $��25q�6   $	��120��6+   .+�5�      � $��35��6#   $��50��6.   ���	#FF41A43C$
��Left=�6Q   $	��Top=�6l   $
��20 0q�6�   ! 5�   "     5�   &   $" 20Q�67   $# 	#FFECECEC��6G   $$ Quality=�6Y   $% 1Q�6q   .+�5�   "     $ Water=�6:   $��Center=�6G   $��Bottom=�6d   $��5q�6   
�������$��20��6�   $��20��6�   5�      �� 5�      $��Humedad del suelo��6(   $��Right=�6A   $��Comic Sans MS)�6]   $��5q�6x   $	��Top=�6�   
�������6�   �� 5�      $ 
Horizontal=�6)   $��Right=�6B   $��Center=�6^   $��10 20q�6y   .+�5�   "   �� $��Comic Sans MS)�6Q   $��Center=�6l   
�������$��50(�6�   ��6,   �� $) InternoHumedad�6�   �� 5�   "   $��Comic Sans MS)�6Q   $��Center=�6l   
�������$��20(�6�   ��6,   �� $) ExternoHumedad�6�   �� 5�   "   $��%��6,   $��Comic Sans MS)�65   $
��0 5 q�6P   $��Bottom=�6^   
�������$��13(�6�   5�      �� 5�      $ 
Horizontal=�6)   $��Bottom=�6B   $��20q�6]   $
* Hand��6i   .+�5�   "     $ AlertOutline=�6:   
���  ��$��10��6_   $��10��6j   $��Center=�6v   $	��5 0q�6�   �� 5�   "   $��Suelo saturado��6,   $��8(�6B   ���	#FF8522BD6O   5�      5�      5�      � 5�      $��0��6   $��2��6(   .+�5�      �� $	��120��6$   $��20q�61   
�������$& 10��6J   $' 10��6W   ! 5�        5�   "   $" 20Q�63   $# 	#FFD1D1D1��6C   $$ Quality=�6U   $% 1Q�6m   5�      � 5�      $��25q�6   $	��120��6+   .+�5�      � $��35��6#   $��50��6.   ���	#FFCF1F1F$
��Left=�6Q   $	��Top=�6l   $
��20 0q�6�   ! 5�   "     5�   &   $" 20Q�67   $# 	#FFECECEC��6G   $$ Quality=�6Y   $% 1Q�6q   .+�5   "     $ MoleculeCo2=�6:   $��Center=�6M   $��Bottom=�6j   $��5q�6�   
�������$��20��6�   $��20��6�   5     �� 5     $��CO2 en el aire��6(   $��Right=�6>   $��Comic Sans MS)�6Z   $��5q�6u   $	��Top=�6�   
�������6�   �� 5     $ 
Horizontal=�6)   $��Right=�6B   $��Center=�6^   $��10 20q�6y   .+�5  "   �� $��Comic Sans MS)�6M   $��Center=�6h   
�������$��50(�6�   ��6,   �� $) 
InternoC02�6�   �� 5  "   $��Comic Sans MS)�6M   $��Center=�6h   
�������$��20(�6�   ��6,   �� $) 
ExternoC02�6�   �� 5  "   $	��ppm��6,   $��Comic Sans MS)�67   $
��0 5 q�6R   $��Bottom=�6`   
�������$��10(�6�   5     �� 5     $ 
Horizontal=�6)   $��Bottom=�6B   $��20q�6]   $
* Hand��6i   .+�5	  "     $ AlertOutline=�6:   
���  ��$��10��6_   $��10��6j   $��Center=�6v   $	��5 0q�6�   �� 5
  "   $��
CO2 escaso��6,   $��8(�6>   ���	#FF8522BD6K   5     5     5     � 5     $��1��6   $��3��6(   $	��380��6<   .+�5     � 
�������$��20 50 20 20q�62   + J� OpacityMask+ 5     !� 5  "   , !� Visual, 6.   �� - �� ElementName$- BorderG1��.+�5     �� -   5        $	 BorderG1��5  %   $
 5��67   
�������6H   �� 5     $��Bottom=�6)   $��	10 0 0 10q�6D   .+�5  "   �� $��Temperatura en el tiempo��6,   $��Comic Sans MS)�6L   $��Bottom=�6g   
�������$��30(�6�   � 5  "   $
��20 0q�6'   .+�5  &   �� $2��,Media: 21  -   Mediana: 20.5   -    Moda: 21��60   $��Comic Sans MS)�6d   
�������$��15(�6�   5  #   5     5     � 5     $��50 20 50 100q�6   + 5     !� 5  "   , 6.   �� $- BorderG2��.+�5      �� -   5        $	 BorderG2��5   %   $
 15��67   ���	#FF3400516I   #  LiveCharts.Wpf.CartesianChart  5"     -   5        $��Tiempo��5"  1   &   LiveCharts.Wpf.Charts.Base.Chart.   LegendLocation$
. Left=�6b   $��25,29,21,10q�6x   /   Series/ 6?   �� *HistorialTiempo+0   ChartLegend0 5#  "   "  LiveCharts.Wpf.DefaultLegend  5$  &   
�������68   1   AxisX1 5'  &     LiveCharts.Wpf.Axis  2   Title$
2 Size��6/   3   Labels3 6<   �� *EtiquetasTiempo+4   	Separator4 5(  *     LiveCharts.Wpf.Separator  5)  .   {�.  5   Step$5 1Q�6N   6Y   5+  '   6   AxisY6 5.  &     $2 	Frequency��6/   7   LabelFormatter7 6A   �� *FormatoAxisY+6k   50     52     53     � 55     $��2��6   $��3��6(   $	��380��6<   .+�56     � 
�������$��20 50 20 20q�62   + 57     !� 58  "   , 6.   �� $- 
BorderG1_1��.+�5:     �� -   5        $	 
BorderG1_1��5:  %   $
 5��69   
�������6J   �� 5;     $��Bottom=�6)   $��	10 0 0 10q�6D   .+�5<  "   �� $��Humedad en el tiempo��6,   $��Comic Sans MS)�6H   $��Bottom=�6c   
�������$��30(�6�   � 5=  "   $
��20 0q�6'   .+�5>  &   �� $2��,Media: 21  -   Mediana: 20.5   -    Moda: 21��60   $��Comic Sans MS)�6d   
�������$��15(�6�   5?  #   5@     5A     � 5B     $��50 20 50 100q�6   + 5C     !� 5D  "   , 6.   �� $- 
BorderG2_1��.+�5F     �� -   5        $	 
BorderG2_1��5F  %   $
 15��69   ���	#FF3400516K     5H     -   5        $��Humedad��5H  1   $
. Left=�6d   $��25,29,21,10q�6z   / 6@   �� *HistorialHumedad+0 5I  "     5J  &   
�������68   1 5M  &     $
2 Size��6/   3 6<   �� *EtiquetasHumedad+4 5N  *     5O  .   {�.  $5 1Q�6N   6Y   5Q  '   6 5T  &     $2 	Frequency��6/   7 6A   �� *FormatoAxisY+6k   5V     5X     5Y     � 5[     $��3��6   $��3��6(   $	��380��6<   .+�5\     � 
�������$��20 50 20 20q�62   + 5]     !� 5^  "   , 6.   �� $- 
BorderG1_2��.+�5`     �� -   5        $	 
BorderG1_2��5`  %   $
 5��69   
�������6J   �� 5a     $��Bottom=�6)   $��	10 0 0 10q�6D   .+�5b  "   �� $��CO2 en el tiempo��6,   $��Comic Sans MS)�6D   $��Bottom=�6_   
�������$��30(�6�   � 5c  "   $
��20 0q�6'   .+�5d  &   �� $2��,Media: 21  -   Mediana: 20.5   -    Moda: 21��60   $��Comic Sans MS)�6d   
�������$��15(�6�   5e  #   5f     5g     � 5h     $��50 20 50 100q�6   + 5i     !� 5j  "   , 6.   �� $- 
BorderG2_2��.+�5l     �� -   5        $	 
BorderG2_2��5l  %   $
 15��69   ���	#FF3400516K     5n     -   5        $	��Co2��5n  1   $
. Left=�6\   $��25,29,21,10q�6r   / 6<   �� *HistorialCo2+0 5o  "     5p  &   
�������68   1 5s  &     $
2 Size��6/   3 6<   �� *EtiquetasCo2+4 5t  *     5u  .   {�.  $5 1Q�6N   6Y   5w  '   6 5z  &     $2 	Frequency��6/   7 6A   �� *FormatoAxisY+6k   5|     5~     5     5�     5�     5�     5�     5�     