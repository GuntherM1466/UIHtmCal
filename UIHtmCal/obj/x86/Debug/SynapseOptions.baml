   M S B A M L   `   `   `  ����C  ?UIHtmCal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HTM.UIHtmCalHTM.UIHtmCal  5   	   L HPhoenixControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:PhoenixControlLib;assembly=PhoenixControlLibPhoenixControlLib 5   	   !    HTM.UIHtmCal.SynapseOptions   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *srcclr-namespace:HTM.UIHtmCal     5   	   Jpcl:clr-namespace:PhoenixControlLib;assembly=PhoenixControlLib     5   	     � SizeToContent$  WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Synapse Options��5   	    � 	Resources 5
      #  HTM.UIHtmCal.UserInputSynapse   MySynapseInput��%   &	          5   
   6   5      .��5      �  � DataContext 5   
   �� 5       �� Source# [  6   6A    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   .+�5%   
   �� $��0��6   $��5��6'   $��0��6;   $
��Auto��6H   $��2��6U   $��Stretch=�5&      $	��Top=�60   $��-2q�6H   �� 5'   
   $��0��6   $��5��6'   $��2��6;   $
��Auto��6H   $��2��6U   $��Stretch=�5(      $	��Top=�60   $��-2q�6H   �� 5)   
   $��0��6   $��5��6'   $��1��6;   $
��Auto��6H   $��2��6U   $��Stretch=�5*      $	��Top=�60   $��-2q�6H   �� 5+   
   $��2��6   $��5��6$   $��0��65   $��2��6E   $��Right=�6O   $��Stretch=�5,      $��1q�67   �� 5-   
   $��0��6   $��5��6'   $��7��6;   $
��Auto��6H   $��2��6U   $��Stretch=�5.      $	��Top=�60   $��-2q�6H   �� 5/   
   $��2��6   $��5��6$   $��3��65   $��2��6E   $��Right=�6O   $��Stretch=�50      $��1q�67   �� 51   
   $��0��6   $��5��6'   $��7��6;   $
��Auto��6H   $��2��6U   $��Stretch=�52      $	��Top=�60   $��-2q�6H   �� 53   
   $��0��6   $��5��6'   $��10��6;   $
��Auto��6I   $��2��6V   $��Stretch=�54      $	��Top=�60   $��-2q�6H   �� 57   
   $��2��6   $��0��6   $��Connected Permanence��6-    � ToolTip 6L   ��   Settings# [ 	 �� Path$	 Default.ToolTipPerColText��� 58   
   $��2��6   $��3��6   $��Permanence Increase��6-   �� 59   
   $��3��6   $��0��6   $��Initial Permanence��6-   �� 5:   
   $��3��6   $��3��6   $��Permanence Decrease��6-   -  'PhoenixControlLib.NumericSpinnerControl  5>   
   $��1��6$   $��2��64   
 � Minimum$
 0Q�6A    � Maximum$	 100Q�6M      IncrementValue$ 1Q�6�    � Value 6[   �� $	 ConnectedPerm�6�     5?   
   $��1��6$   $��3��64   $
 0Q�6A   $	 100Q�6M   $ 1Q�6z    6[   �� $	 IncPerm�6z     5@   
   $��4��6$   $��2��64   $
 0Q�6A   $	 100Q�6M   $ 1Q�6z    6[   �� $	 DecPerm�6z     5A   
   $��4��6$   $��3��64   $
 0Q�6A   $	 100Q�6M   $ 1Q�6~    6[   �� $	 InitialPerm�6~   �� 5D   
   $��2��6   $��0��6%   $��10��65   $��3q�6C   $��Cancel��5E      $
��Left=�6&    �� IsCancel . 6A   �� 5F   
   -   5        $��	ok_Button��5F      $��2��6"   $��3��66   $��10��6F   $��3q�6T   $��Ok��5G      $��Right=�6"   6>   5J      5K      