   M S B A M L   `   `   `  ����B  >Util.UI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ALMACO.UI	ALMACO.UI  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   RadioButtonTemplate  �� 
TargetType �Name J� SnapsToDevicePixels � ColumnDefinitions ��Name �� CornerRadius A�Name J� Opacity&     ALMACO.UI.ThemeResourceExtension    ResourceKey	 ��Name
 �� Triggers P� Property P� Value �� Property �� Value �� 
TargetName  RadioButtonStyle �� 
TargetType  FocusVisual �� BasedOn�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !themeclr-namespace:ALMACO.UI  5      %|
  &	        &	 �    '	� =
    7  �� 5      "  	�62   .R�5      � $ templateRoot��5      
������ $
 True��5
       5      �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5      �� $ radioButtonBorder��5      $��1,1,2,1q�5      #��z��5      #��z��5      #��z��5      #��z��5      #��z��5      $	 100��5      ._�5      � $ markGrid��6   $��2q�6-   .+�5      A� $ 
optionMark��5      $��15��5      $��15��5      $ 0Q�5      ��5         $ IconForeground=�5      5      5       �� 5!      $	 contentPresenter��5#      $��1��5$      #��z��5%      #��z��5&      $��Center=�5'      $|�False��5(      $
��True��5)      # z 5*      5+      
 5,   
   P� 5-       � ��$
 true��6,   . �5/      ��  � ��$ 4,-1,0,0q�6,   50      P� 51       �@J�IsMouseOver$
 true��6-   . �52      �� $ radioButtonBorder��6    6N      $$ RadioButtonMouseOverBackground=� � ���� 53      $ radioButtonBorder��6    6O      $  RadioButtonMouseOverBorder=� � ���� 54      $ 
optionMark��6    6A      $$ RadioButtonMouseOverForeground=� � ��55      P� 56       � {�$ false��6+   . �57      �� $ radioButtonBorder��6    �@J�Opacity$	 0.4Q�6K   �� 58      $ radioButtonBorder��6    �@J�Opacity$	 0.4Q�6K   �� 59      $ 
optionMark��6    �@J�Opacity$	 0.4Q�6D   5:      P� 5;       � ��$
 true��6+   . �5<      �� $ radioButtonBorder��6    6N      $" RadioButtonPressedBackground=� � ���� 5=      $ radioButtonBorder��6    6O      $ RadioButtonPressedBorder=� � ���� 5>      $ 
optionMark��6    6A      $" RadioButtonPressedForeground=� � ��5?      P� 5@       �@d�	IsChecked$
 trueY�6+   . �5A      �� $ 
optionMark��6    �@J�Opacity$ 1Q�6D   5B      P� 5C       �@d�	IsChecked$ falseY�6+   . �5D      �� $ 
optionMark��6    �@J�Opacity$ 0Q�6D   5E      P� 5F       6+   Z�  �@d�	IsChecked. �5G      �� $ 
optionMark��6    �@J�Opacity$
 0.56Q�6D   5H      5J      �� 5L      " 	�6%   .�5M   
   ��  �@�FocusVisualStyle# �  6-   �� 5N   
    � �� 6'      $ RadioButtonBackground=��� 5O   
    � �� 6(      $ RadioButtonBorder=��� 5P   
    � �� 6'      $ RadioButtonForeground=��� 5Q   
    � ��$ Segoe UI Semibold)�6'   �� 5R   
    � ��$ 14(�6%   �� 5S   
    � ��$ 1q�6,   �� 5T   
    � ��# �   6%   5U      �� 5W      8   " 	�68   5Y      