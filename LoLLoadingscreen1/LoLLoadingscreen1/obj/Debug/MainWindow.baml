   M S B A M L   `   `   `  ����L  HLoLLoadingscreen1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LoLLoadingscreenLoLLoadingscreen  5   	   !    LoLLoadingscreen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5   	   *localclr-namespace:LoLLoadingscreen  5   	     � Title$*  $LoL Loadingscreen by EONA Bloodrayne��5	   	   $��180.986��66   $��427.817��6G    � 
ResizeMode$ NoResize=�6W    � Icon$0 *pack://siteoforigin:,,,/Resources/test.ico��6m   .��5      � .+�5   
   3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  -   5          Name$ 
NotifyIcon��5      $y�Visible=�6-   �� 5   
   -   5         ��Name$ label��5      $��SummonerName:��6   $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label1��5      $��Server:��6    $
��Left=�62   $��	10,41,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ label2��5      $��Options:��6    $
��Left=�63   $��	10,72,0,0q�6N   $	��Top=�6a   �� 5   
   $
��Left=�6   $��33��60   $��
117,72,0,0q�6<   $	��Top=�6P   $	��293��6h   .+�5      �� -   5         ��Name$ 	checkBox1��5      $"��Use animated loading screens��6_    � ToolTip$R LIf activated the loading screen will use animated videos for the champions. ��6�    d� 	IsChecked 6*   ��  �� Path$ useAnimatedLoadingscreens�6�   �� 5      -   5        $ checkBox��5      $:��4Use video of default skin if skin hasn`t got a video��6_    6)   �� $  useDefaultIfSkinHasNoVideo�6_   5      �� 5   
   -   5        	 ��Name$	 textBox��5      $
��Left=�6#   $��23��6>   $��
117,13,0,0q�6J   
 �� TextWrapping$

 Wrap=�6^   $	��Top=�6�   $	��162��6�   ��6r   �� $ SummonerName�6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��175,114,0,0q�6L   $	��Top=�6a   $��75��6y   �� 5   
   -	   5        $ btnHide��5      $
��Hide��6"   $
��Left=�61   $��255,114,0,0q�6L   $	��Top=�6a   $��75��6y   �� 5   
   -
   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��335,114,0,0q�6N   $	��Top=�6c   $��75��6{   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��
117,45,0,0q�6@   $	��Top=�6T   $	��162��6l    �� SelectedIndex 6x   �� $ Region�.@�5      �� $	��EUW��6   �� 5      $
��EUNE��6   �� 5      $��NA��6   5      �� 5   
   -   5        $ btnSave_Copy��5      $��Start��6'   $
��Left=�67   $��
95,114,0,0q�6R   $	��Top=�6f   $��75��6~    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5       �� �� 5!      �� 5"       �� Angle$ 51.482Q�6&   T� 5#      5$      5&      5(      5*      