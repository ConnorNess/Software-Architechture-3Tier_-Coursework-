   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	        Presentation.CreateBooking   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  CreateBooking��5   	   $��647.819��6   $��375.63��60   .��5	      � .+�5
   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��396��6@   $��
10,137,0,0q�6M   
���   �$	��Top=�6p   $	��348��6�   �� 5   
   -   5         ��Name$ EdNapUni_Logo_RGB_jpg��5      $��10,10,122,535q�6/   $��EdNapUni_Logo_RGB.jpg��6F   $
��Fill=�6e   $	��236��6t   $��72��6�   �� 5   
   -   5         ��Name$ lblBook��5      $��Booking��6!   $
��Left=�63   $��32��6N   $��
10,100,0,0q�6Z   $	��Top=�6n   $	��143��6�   �� 5   
   -   5        $ 
lblArrival��5      $��Arrival Date��6$   $
��Left=�6;   $��28��6V   $��
21,148,0,0q�6b   $	��Top=�6v   $	��100��6�   �� 5   
   -   5        $ 	lblDepart��5      $��Departure Date��6#   $
��Left=�6<   $��28��6W   $��179,148,0,0q�6c   $	��Top=�6x   $	��100��6�   �� 5   
   -   5         ��Name$ btnBack��5      $��< Back��6"   $
��Left=�66   $��30��6Q   $��
308,10,0,0q�6]   $	��Top=�6q   $��50��6�   6�   �� 5   
   -   5        $ 	btnSubmit��5      $��Submit��6$   $
��Left=�65   $��70��6P   $��112,538,0,0q�6\   $	��Top=�6q   $	��134��6�   6�   �� 5   
   -   5         ��Name$ extraCar��5      $��Car Hire��6%   $
��Left=�68   $��30��6S   $��
23,326,0,0q�6_   $	��Top=�6s   $	��100��6�   �� 5   
   -   5        $ extraEvening��5      $��Evening Meals��6)   $
��Left=�6A   $��30��6\   $��237,326,0,0q�6h   $	��Top=�6}   $	��100��6�   �� 5   
   -	   5        $ extraBreakfast��5      $��	Breakfast��6+   $
��Left=�6?   $��30��6Z   $��132,326,0,0q�6f   $	��Top=�6{   $	��100��6�   �� 5   
   -
   5        $ lblExtra��5      $��Extras��6"   $
��Left=�63   $��26��6N   $��
23,295,0,0q�6Z   $	��Top=�6n   $	��150��6�   �� 5   
   -   5         ��Name$ 
txtArrival��5      $
��Left=�6&   $��30��6A   $��
21,181,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��132��6�   �� 5   
   -   5        $ 	txtDepart��5      $
��Left=�6%   $��30��6@   $��179,181,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��130��6�   �� 5   
   -   5        $ 	txtChalet��5      $
��Left=�6%   $��30��6@   $��
21,253,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��132��6�   �� 5   
   -   5        $ label��5      $��Chalet��6   $
��Left=�60   $��28��6K   $��
21,220,0,0q�6W   $	��Top=�6k   $	��100��6�   �� 5   
   -   5        $ txtCarStart��5      $
��Left=�6'   $��30��6B   $��
21,391,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��132��6�   �� 5   
   -   5        $ label1��5      $��Car Hire Start��6    $
��Left=�69   $��25��6T   $��
21,361,0,0q�6`   $	��Top=�6t   $	��100��6�   �� 5   
   -   5        $ 	txtCarEnd��5      $
��Left=�6%   $��30��6@   $��179,391,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��130��6�   �� 5   
   -   5        $ label2��5      $��Car Hire End��6    $
��Left=�67   $��25��6R   $��179,361,0,0q�6^   $	��Top=�6s   $	��100��6�   �� 5   
   -   5        $ 
txtCarName��5      $
��Left=�6&   $��30��6A   $��
23,476,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��130��6�   �� 5   
   -   5        $ label3��5      $��Name of Driver��6    $
��Left=�69   $��28��6T   $��
23,443,0,0q�6`   $	��Top=�6t   $	��100��6�   5       5!      