   M S B A M L   `   `   `  ����  zadanie3    WpfApp2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Panel logowania��5   	   $	��300��6!   $	��400��6.   
�������.��5      � $��10q�6   .+�5   
   �� $��Center=�6   .+�5      �� $��Panel logowania��6   $��20(�6/   $
��Bold"�6=   $��Center=�6O   $��0,0,0,20q�6l   
��� � �6~   � 5	      $��0,0,0,10q�6    � ColumnDefinitions 5
      �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5      �� $��Użytkownik:��6   $��Center=�6.   $��0��6I   $��	0,0,-25,0q�6Y   
��� � �6l   �� 5      -   5         ��Name$ UsernameInput��5      $	��200��61   $��1��6=   5      � 5      $��0,0,0,20q�6    5      �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5      �� $��Hasło:��6   $��Center=�6)   $��0��6D   $��0,0,5,0q�6T   
��� � �6e   G� 5      -   5         G�Name$ PasswordInput��5      $	��200��65   $��1��6A   5      �� 5      -   5        $��Zaloguj��5      $	��100��6'   $��Center=�63   
��� � �
�������6v   �� 5      -   5         ��Name$ 	ErrorText��5      
���  �� �� TextAlignment$ Center=�6<   $��0,10,0,0q�6S   5      5      5      