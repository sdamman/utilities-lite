   M S B A M L   `   `   `  ����B  >Util.UI, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ALMACO.UI	ALMACO.UI  5      a ]PresentationFramework.Aero, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxItemTemplate  �� 
TargetType ��Name&     ALMACO.UI.ThemeResourceExtension    ResourceKey �� Padding J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName	 �� Value
 �� Property  ComboBoxItemStyle �� 
TargetType �� BasedOn   ComboBoxToggleButtonTemplate F�Name  ComboBoxToggleButton  ComboBoxEditableTextBox ��Name  ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� RelativeSource �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome  Name �� MaxDropDownHeight   Color �� ElementName �� ClearTypeHint ��Name ��Name ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation d�Name d� 	IsChecked  �� Mode! ��Name" �� 
IsReadOnly# P� 
SourceName$ ]� 
Conditions% �� Property& �� Value  ComboBoxTemplate' ��Name( �� SelectionBoxItem#) �� SelectionBoxItemStringFormat* �� ContentStringFormat+ �� SelectionBoxItemTemplate, J� IsHitTestVisible  ComboBoxStyle- �� Triggers�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !themeclr-namespace:ALMACO.UI  5      [themeWindowsJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      8d2http://schemas.microsoft.com/expression/blend/2008  5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      %�&  &	        &	 L    7   '�� �    7  &	     &	 i
    7  &	 �    &	     7  7  &	 �    7  &	 �"    '�� K&    7  �� 5
      "  ��61   .R�5      � .+�5      �� $ FocusBorder��6   $��1q�5      $y�	Collapsed=�5      ��5         $ ComboBoxBorder=�5      �� 5      $ Bd��6   # z��5      #��z��5      #��z��5      #��z��5      $
 true��5      ._�5   
   �� #��z��6   #��z��5      $
 True��5      5   	   5       5      P� 5       �@J�IsMouseOver$
 true��6'   . �5   
   �� $ Bd��6   	 5         $! ComboBoxMouseOverBackground=�
 � ���� 5   
   $ Bd��6   	 5          $ ComboBoxMouseOverBorder=�
 � ���� 5!   
   	 5"         $! ComboBoxMouseOverForeground=�
 � ��5#   	   P� 5$       �@��
IsSelected$
 true��6&   . �5%   
   �� $ Bd��6   	 5&         $  ComboBoxSelectedBackground=�
 � ���� 5'   
   $ Bd��6   	 5(         $  ComboBoxSelectedBackground=�
 � ���� 5)   
   	 5*         $  ComboBoxSelectedForeground=�
 � ��5+   	   P� 5,       � {�$ false��6%   . �5-   
   �� 
 �@J�Opacity$		 0.4Q�6$   5.   	   50      �� 52      " ��6$   .�53      �� 
 �@J�SnapsToDevicePixels$
	 true��6,   �� 54      
 � ��$	 3,3,3,3q�6    �� 55      
 � ��	 6#      $ ComboBoxForeground=��� 56      
 � ��	 6#      $ ComboBoxBackground=��� 57      
 � ��	 6,   �� *HorizontalContentAlignment+�� 58      
 � ��	 6*   �� *VerticalContentAlignment+�� 59      
 � ��
	 ���� 6$   �� 5:      
 � ��$	 0q�6(   �� 5;      
 �@�FocusVisualStyle	 6)   Z� �� 5<      
 � ��8	   6!   �� 5=      
 � ��$	 Segoe UI Semibold)�6#   �� 5>      
 � ��$	 Medium"�6#   �� 5?      
 � ��$	 14(�6!   5@      �� 5B      8   " ��67   �� 5G      "  d�69   .R�5H      �� $ templateRoot��6   #��z��5I      $��0q�5J      $
 true��5K      ._�5L      �� $ splitBorder��6   $��Right=�5M      $��0q�5P      $	 3,0q�5Q      $��0q�5R      $
 true��5S      ��5N         $ CombineBlue=�._�5T   
   F� $ glyph��6   $
��Left=�5U      $��Center=�5V      =����@B �� ���-     ��pr  �D � �     р�� �� ��pr  �� 	��5X         $ White=�5Z   	   5[       5\      P� 5]       �@J�IsMouseOver$
 true��6'   . �5^   
   �� $ templateRoot��6   	 5_         $! ComboBoxMouseOverBackground=�
 � ���� 5`   
   $ splitBorder��6   	 5a         $ DarkBlue=�
 � ��5b   	   P� 5c       � {�$ false��6%   . �5d   
   �� 	 5e         $ ControlDisabledOpacity=�
 �@J�Opacity5f   	   5h      �� 5j      " d�6'   .�5k      �� 
 �@�OverridesDefaultStyle$
	 True��6.   �� 5l      
 � ��$	 False��6"   �� 5m      
 � |�$	 False��6"   �� 5n      
 �@��	ClickMode$	 Press=�6"   �� 5o      
 � ��8	   6!   �� 5p      
 � ��$	 Segoe UI Semibold)�6#   �� 5q      
 � ��$	 Medium"�6#   �� 5r      
 � ��$	 14(�6!   5s      �� 5v      " ��6*   .�5w      �� 
 �@�OverridesDefaultStyle$
	 true��6.   �� 5x      
 �@J�	AllowDrop$
	 true��6"   �� 5y      
 � ��$	 0��6!   �� 5z      
 � ��$	 0��6"   �� 5{      
 �@�FocusVisualStyle	 6)   Z� �� 5|      
 �@��PanningMode$	 VerticalFirst=�61   �� 5}      
 �@��IsFlicksEnabled$	 False��6/   �� 5~      
 � ��$	 Center=�61   �� 5      
 � ��$	 Segoe UI Semibold)�6#   �� 5�      
 � ��$	 Medium"�6#   �� 5�      
 � ��$	 14(�6!   �� 5�      
 �@��SelectionBrush	 5�         $ EditableComboBoxHighlight=��� 5�      
 � ��	 5�      �� 5�   
   "  ��6   .R�5�      �� $ PART_ContentHost��6   $|�false��5�      $��Hidden=�5�      $��Hidden=�5�      5�      5�      5�      �� 5�      "  ��65   .R�5�      � $ templateRoot��6   $
 true��6!    5�      �� 5�   
   $��4* �6   �� 5�   
   $��* �6   #��� r�6%   .+�5�      � $ 
PART_Popup��6   $��2��5�      $
 true��5�      $��Bottom=�5�      #��� .�5�      ��5�      �� *IsDropDownOpen+ �� $ TemplatedParent=�.��5�   
     $ shadow��5�      #��z 5�      $ Transparent��5�      ��5�      �� *ActualWidth+$ templateRoot��._�5�      �� $ dropDownBorder��6   #��z��5�      #��z��5�      $��1q�5�      ._�5�      �� $ DropDownScrollViewer��6   .��5�      � $
 grid��6   $ Enabled=�6#   .+�5�      �� $ canvas��6   $��0��5�      $��0��5�      $
��Left=�5�      $	��Top=�5�      .+�5�      �� $ 
opaqueRect��6   ��5�      �� *ActualWidth+$ dropDownBorder����5�      �� *ActualHeight+$ dropDownBorder����5�      �� *
Background+$ dropDownBorder��5�      �� 5�      $ ItemsPresenter��6!   $ 	Contained=�5�   !   # z 5�   !   5�      5�      5�      5�      5�   	   d� 5�      $ toggleButton��6   $��2��5�      #��z��5�      #��z��5�      #��z��5�      8��   5�      �� *IsDropDownOpen+$  TwoWay=� �� $ TemplatedParent=�5�      �� 5�      $ border��6   #��z��5�      
����i��._�5�   
   �� $! PART_EditableTextBox��6   #��z��5�      #��z��5�      $��Center=�5�      8�� " 5�      �� *
IsReadOnly+ �� $ TemplatedParent=�5�      5�   	   5�       5�      P� 5�       � {�$ false��6%   . �5�   
   �� $ border��6   
 �@J�Opacity$
	 0.56Q�68   5�   	   P� 5�       �@J�IsKeyboardFocusWithin$
 true��61   . �5�   
   �� 	 5�         $' !EditableComboBoxPressedBackground=�
 � ���� 5�   
   	 5�         $' !EditableComboBoxPressedForeground=�
 � ��5�   	   P� 5�      $# 
PART_Popup��6    �@�HasDropShadow$
 true��6A   . �5�   
   �� $ shadow��6   
 � ��$	 0,0,5,5q�67   �� 5�   
   $ shadow��6   
 �@ Color$	 	#71000000��66   5�   	   P� 5�       �@��HasItems$ false��6$   . �5�   
   �� $ dropDownBorder��6   
 � ��$	 95��6?   5�   	   ]� 5�      $ 5�   
   �� 5�      % �@��
IsGrouping$
& true��6,   �� 5�      "% �@%�IsVirtualizingWhenGrouping$& false��6N   ./�5�   
   �� 
 � ��$	 false��6:   5�   	   P� 5�      $# DropDownScrollViewer��6    � ��$ false��5�   9   . �5�   
   �� $ 
opaqueRect��6   	 5�      �� *VerticalOffset+$ DropDownScrollViewer��
 �@��Top�� 5�   
   $ 
opaqueRect��6   	 5�      �� *HorizontalOffset+$ DropDownScrollViewer��
 �@��Left5�   	   5�      �� 5�      "  ��6-   .R�5�      � $ templateRoot��6   $
 true��6!    5�      �� 5�   
   $��* �6   �� 5�   
   $��0 �6   #��� r�5�      .+�5�      � $ 
PART_Popup��6   $��2��5�      $��1q�5�      $
 true��5�      $��Bottom=�5�      #��� .�5�      ��5�      �� *IsDropDownOpen+$  TwoWay=� �� $ TemplatedParent=�.��5�   
     $ shadow��5�      #��z 5�      $ Transparent��5      ��5�      �� *ActualWidth+$ templateRoot��._�5     �� $ dropDownBorder��6   #��z��5     #��z��5     $��1q�5     ._�5     �� $ DropDownScrollViewer��6   .��5     � $
 grid��6   $ Enabled=�6#   .+�5     �� $ canvas��6   $��0��5     $��0��5	     $
��Left=�5
     $	��Top=�5     .+�5     �� $ 
opaqueRect��6   ��5     �� *ActualWidth+$ dropDownBorder����5     �� *ActualHeight+$ dropDownBorder����5     �� *
Background+$ dropDownBorder��5     �� 5     $ ItemsPresenter��6!   $ 	Contained=�5  !   # z 5  !   5     5     5     5     5  	   d� 5     $ toggleButton��6   $��2��5     #��z��5     #��z��5     #��z��5     8��   5     �� *IsDropDownOpen+$  TwoWay=� �� $ TemplatedParent=�5     �� 5!     $' contentPresenter��6   #��z��5"     #��z��5#     $��Center=�5$     #��z( 5%     #* z) 5&     #��z+ 5'     #��z��5(     $, false��5)     # z 5*     5+      5,     P� 5-      �@��HasItems$ false��6$   . �5.  
   �� $ dropDownBorder��6   
 � ��$	 95��6?   5/  	   ]� 50     $ 51  
   �� 52     % �@��
IsGrouping$
& true��6,   �� 53     "% �@%�IsVirtualizingWhenGrouping$& false��6N   ./�55  
   �� 
 � ��$	 false��6:   56  	   P� 57     $# DropDownScrollViewer��6    � ��$ false��59     . �5:  
   �� $ 
opaqueRect��6   	 5;     �� *VerticalOffset+$ DropDownScrollViewer��
 �@��Top�� 5<  
   $ 
opaqueRect��6   	 5=     �� *HorizontalOffset+$ DropDownScrollViewer��
 �@��Left5>  	   5@     �� 5B     " ��6    .�5C     �� 
 � ��	 5D        $  EditableComboBoxBackground=��� 5E     
 � ��	 5F        $  EditableComboBoxForeground=��� 5G     
 � ��$	 Segoe UI Semibold)�6#   �� 5H     
 � ��$	 Medium"�6#   �� 5I     
 � ��$	 14(�6!   �� 5J     
 � ��$	 0q�6(   �� 5K     
 � ��$
	 Auto=�6C   �� 5L     
 � ��$
	 Auto=�6A   �� 5M     
 � ��$	 6,3,5,3q�6    �� 5N     
 � ��$
	 true��66   �� 5O     
 �@��PanningMode$
	 Both=�61   �� 5P     
 �@��IsFlicksEnabled$	 False��6/   �� 5Q     
 � ��#	 �  6!   - 5R     P� 5S      �@��
IsEditable$
 true��6&   . �5T  
   �� 
 � ��$	 false��6&   �� 5U  
   
 � ��$	 2q�6$   �� 5V  
   
 � ��#	 �  6%   5W  	   P� 5X      � {�$ False��6%   . �5Y  
   �� 
 � ��	 5Z        $  EditableComboBoxBackground=�5[  	   5]     �� 5_     8   " ��63   5a     