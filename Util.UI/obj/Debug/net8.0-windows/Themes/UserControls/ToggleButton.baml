   M S B A M L   `   `   `  ����B  >Util.UI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ALMACO.UI	ALMACO.UI  5      )    #ALMACO.UI.UserControls.ToggleButton   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )themeclr-namespace:ALMACO.UI     5        � DataContext  5      ��  �� RelativeSource �� *Self+ � 	Resources 5#         ToggleTemplate �� 
TargetType � Cursor&    ALMACO.UI.ThemeResourceExtension   ResourceKey �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value  ToggleStyle �� 
TargetType  
ToggleList � ColumnDefinitions  bodyCopy �� BasedOn �� FallbackValue d� 	IsChecked��%,  &	        &	 �    &	     7  7  �� 5%      " ��6-   .R�5)      �� $
 Hand��6   $��40��5*      $��20��6   .+�5-   
   F� $��bg��6   m�������     �    ���  ��� ��� ׀��  -1 ��� ��� р�� -1� Zb���  ��� ��� ׀��     ��� ��� 	��50        $ TabItemStaticBackground=�F� 55   
   $��slider��6   d���� -1��� ׀��  -1���� ��� �    ��� ���� ��� ׀��     ���� ��� � -1��� ���� ��� 	��58        $ BlueButtonBackground=�5:   	    5?      P� 5@   
    � {�$ false��6'   . �5A      �� $	 bg��6   
 �@J�Opacity$	 0.4Q�5B   &   5C      P� 5D   
    �@J�IsMouseOver$
 true��6)   . �5E      �� $	 slider��6    5G        $ DarkBlue=�
 � ��5H      P� 5I   
    �@d�	IsChecked$
 trueY�6'   . �5J      �� $	 slider��6   
 �@��Left$ 20��5K   *   5L      P� 5M   
    �@d�	IsChecked$ falseY�6'   . �5N      �� $	 slider��6   
 �@��Left$ 0��5O   *   5P      5R      �� 5V      " ��6    .�5W      �� 
 � ��# �   6#   5X      �� 5[      " ��6   .�5]      �� 
 � ��$ Disabled=�6E   �� 5^      
 � ��$ Disabled=�6C   �� 5_      
 � ��$ False��68   �� 5`      
 �@��PanningMode$
 None=�63   �� 5a      
 �@��IsFlicksEnabled$ False��61   �� 5b      
 � ��$ Center=�63   �� 5d      
 � �� 5e   
   �� 5f      " ��6   .R�5g      �  5i      �� 5j      $
��Auto �6#   �� 5k      $
��Auto �6#   �� 5l      $
��Auto �6#    5n      ���� 5q      '��       " ��6   8   .�5r      �� 
 � ��$	 5,3q�6-   5s      5t      .+�5v      �� $��0��6   $��Right=�5x      ��5w      �� *OptionList[0]+$ 1��5x      �� 5{      $��1��6   8��  5}      �� *	IsChecked+�� 5      $��2��6   $
��Left=�5�      ��5�      �� *OptionList[1]+$ 2��5�      5�       5�      P� 5�       � {�$ false��6-   . �5�      �� 
 �@J�Opacity$	 0.4Q�6,   5�      5�      5�   	   5�      5�      .��5�      �� #���  6   ��5�      �� *
OptionList+$ 12�� �� SelectedItem 5�      �� *SelectedOption+5�      