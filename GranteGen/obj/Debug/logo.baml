   M S B A M L   `   `   `  ����D  @GranteGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GranteGen	GranteGen  5   	       GranteGen.logo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GranteGen     5   	     � Title$
  logo��5   	   $	��357��6   $	��642��6#    � WindowStyle$
 None=�6/    � 	Resources 5	         Storyboard1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%s  &	        �� 5
   
   -   5        .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ image��6�   .\�5        $ 0��6'   $	 109Q�63     5      $ 0:0:0.5��6'   $ -6Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ image1��6�   .\�5        $ 0��6'   $	 111Q�63     5      $ 0:0:0.5��6'   $ -4Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ image��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ image1��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ image2��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ label��6\   .\�5         $ 0��6'   $ 0Q�63     5!      $ 0:0:0.5��6'   $ 1Q�69   5"      5#      5$       � Triggers 5%      :� 5&   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5'      �� #��[  6   5(      .��5*      � .+�5+   
   �� $
��Left=�6   $	��375��6+   $	��Top=�68   $	��643��6P   {�.  $*��$87aad9d8f126ea2a4636ff30edb4b81e.jpg��6n   $��0,-11,-9,-6q�6�   �� 5-   
   -   5        	 ��Name$	 image��5-      $
��Left=�6   $��280.529��6:   $��41.309,83.471,0,-3q�6K   $	��Top=�6g   $��200.755��6   $��立ち絵01b_笑.png��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   z�5.      V� 5/      .~�50      �� �� 51      �� 52      T� 53      54      56      �� 57   
   -   5        $	 image1��57      $
��Left=�6    $��280.529��6;   $��242.064,83.471,0,0q�6L   $	��Top=�6h   $��200.755��6�   $��立ち絵2_3.png��6�   $
 0.5,0.5&�6�   z�58      V� 59      .~�5:      �� �� 5;      �� 5<      T� 5=      5>      5@      �� 5A   
   -   5        $	 image2��5A      $
��Left=�6    $��280.529��6;   $��442.245,103.471,-9,-23q�6L   $	��Top=�6l   $��200.755��6�   $��立ち絵5_3.png��6�   �� 5B   
   -   5         ��Name$ label��5B      $��Grante��6   $
��Left=�60   $	��Top=�6K   $��475.593,0,0,0q�6c   
�������$��48(�6�   $��Unispace)�6�   5D      5E      