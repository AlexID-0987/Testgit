   M S B A M L   `   `   `  ����I  ETravelCatalogi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TravelCatalogi.ViewModelTravelCatalogi.ViewModel  5   	   9!clr-namespace:TravelCatalogi.ViewTravelCatalogi.View  5   	   "    TravelCatalogi.View.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5vm&clr-namespace:TravelCatalogi.ViewModel     5   	   3local!clr-namespace:TravelCatalogi.View     5   	     � Title$  MainView��5	   	   $	��550��6   $	��800��6'    � DataContext 5      (  "TravelCatalogi.ViewModel.ViewModel  5   
   6   .��5      � -   5         �Name$ L��5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   .+�5       �� -   5        $��R��5!      
���P��$��Disabled=�5#      ��5       �� *	Countries+ �� SelectedItem 5"      �� *SelectedCountry+��5$      �� 5&      .R�5'      �� .+�5(      �� $	��200��6!   $��5q�5)   !   
���**�� �� CornerRadius$ 5��5+   !   ._�5,      �� $��UniformToFill=�5-   $   ��5,   $   �� *Image+5-   >   5.      � 5/       50      �� 51   "   65   �� 52   "   65   �� 53   "   65    55      �� 56   "   62   �� 57   "   62   �� 58   "   62   .+�5;   "   �� ��6,   �� *Id+6B   �� 5<   "   $��1��6K    �� TextAlignment$ Center=�5=   $   ��5<   ,   �� *TravelCountry+5=   =   �� 5>   "   $��30��6)   $��2q�5?   !   
���**��$ 5��5A   !   $��3��62   ._�5B   &   �� ��6,   �� *CountryImage+6N   5C   #   �� 5D   "   $��1��6G   $��2��6W   $ Center=�5E   (   ��5D   ,   �� *	CityHotel+5E   A   �� 5F   "   $��2��6D   $��2��5G   (   ��5F   ,   �� *Street+5G   7   �� 5H       ��Name$ myTextBlock��6(   $��30��6n   ��6=   �� 	 �� ElementName$	 	myTextBox��
 �� Path$

 Text�6|   5L      5M      5N      ��5P      �� 5Q      .R�5R      � 6"   5S      5U      �� 5X   
   $��1��6   
���i��.+�5\      �� $	��200��6   $��5q�5]   !   
���**��$ 5��5_   !   ._�5`      �� $��UniformToFill=�5a   $   ��5`      �� *SelectedCountry.HImage+5a   >   5b      �� 5d      $ Center=�6   �� 5e      �6   �� *SelectedCountry.Id+6@    �� 5f      �6   �� *SelectedCountry.Street+6D   5g      �� 5j      $	��200��6   $��5q�5k   !   
���**��$ 5��5m   !   ._�5n      �� $��UniformToFill=�5o   $   ��5n      �� *SelectedCountry.Image+5o   >   5p      �� 5q      $	��200��6   $��5q�5r   !   
���**��$ 5��5t   !   ._�5u      �� $��UniformToFill=�5v   $   ��5u      �� *SelectedCountry.ImageRoom+5v   >   5x      �� 5y      -   5        $ myTextBlock1��5y      $��30��6`   $ Center=�6l   ��6.   �� $	 
myTextBox1��$

 Text�6l   5|      �� 5}   
   $��2��6   ���#eb4034.+�5~   
   �� -   5         ��Name$ 
myTextBox1��5~      $��30��6&   
����d�62   �� 5   
   -   5        $ myTextBlock��5      $��30��6[   ��6)   �� $	 
myTextBox1��$

 Text�6[   �� 5�       � 	Resources 5�       �� 
TargetType �� Property �� Value��%�   '��       �� 5�      " ��6   .�5�      ��  � ��$ 20q�63   6@   �� 5�       � ��$ 14(�65   6B   �� 5�       � �� �#9f91d96I   �� 5�       � ��$ 10q�64   6A   5�      5�      .+�5�      �� ��6   �� *	AddTravel+.��67   Add Country6D   �� 5�      ��6   �� *RemoveTravel+.��6:   Remove Country6J   �� 5�      ��6   �� *Print+.��63   Print6:   �� 5�      ��6   �� *Save+.��62   Save68   �� 5�      ��6   �� *ShowCommandTravel+.��6?   Info6E   5�      5�      5�      5�      