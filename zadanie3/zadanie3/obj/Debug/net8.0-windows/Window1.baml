   M S B A M L   `   `   `  ����  zadanie3    WpfApp2.CalculatorWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Kalkulator Podatku��5   	   $	��350��6$   $	��400��61   
�������.��5      � $��10q�6   .+�5   
   �� $��Center=�6   .+�5      �� $��Kalkulator Podatku��6   $��20(�62   $
��Bold"�6@   $��Center=�6R   $��0,0,0,20q�6o   
��� � �6�   �� 5	      $��Wpisz pensję brutto:��6   $��14(�64   $
��Left=�6B   $��	59,8,0,12q�6]   
��� � �6p   �� 5
       �� Orientation$ 
Horizontal=�6   $��Center=�62   $	��Top=�6O   $��0,8,0,0q�6g   .+�5      �� -   5         ��Name$ BruttoInput��5      $	��180��6/   $��14(�6;   �� 5      -   5        $��Oblicz��5      $��70��6*   $��5q�65   
��� � �
�������6f   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��Top=�6O   $��0,8,0,0q�6g   .+�5      	� -   5         	�Name$ stawk8_5��5      $
��8.5%��60   $��5q�6?   	� 5      -   5        $ stawk12��5      $	��12%��6/   $��5q�6=    d� 	IsChecked$
 TrueY�6H   	� 5      -   5        $ stawk19��5      $	��19%��6/   $��5q�6=   5      � 5      $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��5q�6-   .+�5      �� $��Pensje Brutto��6    $
��Bold"�65   $��0,0,0,5q�6G   
��� � �6X   �� 5      -   5         ��Name$ 
BruttoList��5      $	��100��62   5      �� 5       $��1��6   $��5q�6-   .+�5!      �� $��Pensje Netto��6    $
��Bold"�64   $��0,0,0,5q�6F   
��� � �6W   �� 5"      -   5        $ 	NettoList��5"      $	��100��61   5#      5$      5%      5&      5'      