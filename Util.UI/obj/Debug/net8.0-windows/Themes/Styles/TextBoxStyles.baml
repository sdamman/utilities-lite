   M S B A M L   `   `   `  ����B  >Util.UI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ALMACO.UI	ALMACO.UI  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TextBoxTemplate  �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value&     ALMACO.UI.ThemeResourceExtension
    ResourceKey  TextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation �� Triggers ]� 
Conditions �� Property �� Value  TextBoxTechnical  TextBoxReadOnly�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !themeclr-namespace:ALMACO.UI  5      %�  &	        &	 �    7   &	 V    7   &	 �    �� 5      "  ��6,   .R�5      �� $ border��5      #��z��5	      #��z��5
      #��z��5      $
 True��5      ._�5      �� $ PART_ContentHost��5      $|�false��5      $��Hidden=�5      $��Hidden=�5      5       5      P� 5       � {�$ false��6%   . �5   
   �� $ border��6    �@J�Opacity$		 0.4Q�68   5   	   P� 5       �@J�IsMouseOver$
 true��6'   . �5   
   �� $ border��6   	 6<      $
 TextBoxMouseOverBorder=� � ��5   	   P� 5       �@J�IsKeyboardFocused$
 true��6-   . �5   
   �� $ border��6   	 6<      $
 TextBoxPressedBorder=� � ��5   	   5      �� 5!      " ��6   .�5"      ��  � ��	 6#      $
 TextBoxBackground=��� 5#       � ��	 6$      $
 TextBoxBorder=��� 5$       � ��	 6#      $
 TextboxForeground=��� 5%       �@��SelectionBrush	 6'      $
 TextBoxHighlight=��� 5&       � ��$	 Segoe UI Semibold)�6#   �� 5'       � ��$	 Medium"�6#   �� 5(       � ��$	 14(�6!   �� 5)       � ��$	 1q�6(   �� 5*       �@��AcceptsReturn$
	 True��6&   �� 5+       �@��
AcceptsTab$
	 True��6#   �� 5,       �@��TextWrapping$
	 Wrap=�6%   �� 5-       �@ TabNavigation$
	 None=�69   �� 5.       � ��$
	 Left=�63   �� 5/       �@�FocusVisualStyle	 6)   Z� �� 50       �@J�	AllowDrop$
	 true��6"   �� 51       �@��PanningMode$	 VerticalFirst=�61   �� 52       �@��IsFlicksEnabled$	 False��6/   �� 53       � ��8	   6!    54      ]� 55       56   
   �� 57      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6E   �� 58       �@��IsSelectionActive$ false��63   ./�5:   
   ��  �@��SelectionBrush	 6+      $
 TextBoxHighlight=�5;   	   5=      �� 5@      " ��6#   .�5A      ��  � ��	 6#      $
 TextBoxBackground=��� 5B       � ��	 6$      $
 TextBoxBorder=��� 5C       � ��	 6#      $
 TextboxForeground=��� 5D       �@��SelectionBrush	 6'      $
 TextBoxHighlight=��� 5E       � ��$	 Segoe UI Semibold)�6#   �� 5F       � ��$	 Medium"�6#   �� 5G       � ��$	 16(�6!   �� 5H       � ��$	 1q�6(   �� 5I       �@��AcceptsReturn$
	 True��6&   �� 5J       �@��
AcceptsTab$
	 True��6#   �� 5K       �@��TextWrapping$	 NoWrap=�6%   �� 5L       � ��$	 Center=�6*   �� 5M       � ��$	 Center=�61   �� 5N       � ��$	 Center=�6,   �� 5O       � ��$	 Center=�63   �� 5P       � ��$	 26��6"   �� 5Q       � ��$	 85��6!   �� 5R       � ��$	 2q�6   �� 5S       �@�FocusVisualStyle	 6)   Z� �� 5T       �@J�	AllowDrop$
	 true��6"   �� 5U       �@��PanningMode$	 VerticalFirst=�61   �� 5V       �@��IsFlicksEnabled$	 False��6/   �� 5W       � ��8	   6!    5X      ]� 5Y       5Z   
   �� 5[      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6E   �� 5\       �@��IsSelectionActive$ false��63   ./�5^   
   ��  �@��SelectionBrush	 6+      $
 TextBoxHighlight=�5_   	   5a      �� 5c      " ��6"   .�5d      ��  � ��	 6#      $
 WindowBackground=��� 5e       � ��	 6#      $
 MaxContrast=��� 5f       �@��SelectionBrush	 6'      $
 TextBoxHighlight=��� 5g       � ��$	 0q�6(   �� 5h       � ��$	 Segoe UI Semibold)�6#   �� 5i       � ��$	 Medium"�6#   �� 5j       � ��$	 14(�6!   �� 5k       �@��TextWrapping$	 NoWrap=�6%   �� 5l       � ��$	 Center=�6*   �� 5m       � ��$	 Center=�61   �� 5n       � ��$
	 Left=�6,   �� 5o       � ��$
	 Left=�63   �� 5p       � ��$	 20��6"   �� 5q       � ��$	 85��6!   �� 5r       � ��$	 2q�6   �� 5s       �@�FocusVisualStyle	 6)   Z� �� 5t       �@J�	AllowDrop$	 False��6"   �� 5u       �@��
IsReadOnly$
	 True��6#    5v      P� 5w       �@J�IsMouseOver$
 true��6'   . �5x   
   ��  � ��$	 0q�6,   5y   	   5{      5}      