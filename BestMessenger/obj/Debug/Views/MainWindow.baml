   M S B A M L   `   `   `  ����H  DBestMessenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BestMessenger.ViewsBestMessenger.Views  5   	   C&clr-namespace:BestMessenger.ViewModelsBestMessenger.ViewModels  5   	   $    BestMessenger.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BestMessenger.Views     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   /vm&clr-namespace:BestMessenger.ViewModels  5   	   -   5          � Title$  
MainWindow��5
   	   $	��600��6   $	��900��6)    � WindowStyle$
 None=�5   	   ���#212121 � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�5   	    � DataContext 5      ,   &BestMessenger.ViewModels.MainViewModel  5   
   -   5        MainViewModel��5   4   .��5      ]� .+�5   
   �� $	��Top=�6      WindowBorderStyle#��[  5      o� 5   
   $	��Top=�6   .@�5      m� $��Application��6   .@�5      m� $��Close��6   5      5      5      � 5   
    � ColumnDefinitions 5      �� 5       $	��250 �6#   �� 5!      .+�5#      � $��0��6   ���#423a3a � RowDefinitions 5$      �� 5%      $��50 �6$   �� 5&      .+�5(      A�  A� Columns$ 2��6   .+�5)      �� $��0��6   
�������$��Friends��5+      $��Center=�5,      $
��Bold"�5-      $��15,0,0,0q�5.      �� 50      -   5        $��30��50      $��30��6(   ��52      �� 53      .R�54   "   "  FontAwesome.WPF.ImageAwesome     Icon$
 Plus=�62   	   
Foreground
	 �����55   G   56      58      59      �� 5;      $��1��6   
������ $��0q�5=        MemberListStyle#��[ 5>      ��5?      �� *AllChatMembers+
 �� SelectedItem
 5@      �� *SelectedMember+5B      5E      � 5F      $��1��6   $��10,0,0,0q�6#    5G      �� 5H      $��80 �6$   �� 5I      �� 5J      $	��100 �6$   .+�5L      �� ._�5M      � $��Stretch=�6   .+�5N      �� $��Center=�6$   
�������$
��Bold"�5P   $   $��16(�5Q   $   ��5S      `� 5T   "    �� StringFormat$ {0} {1}��6/   .1�5U   &   ��  �� Path$ SelectedMember.FirstName�6.   6P   �� 5V   &   $ SelectedMember.LastName�6.   6P   5W   #   5Z      �� 5[      $��Right=�6%    �� Orientation$ 
Horizontal=�5\   %   .+�5^        $ Camera=�6.   $��50��5_   .   $��50��69   
	 �����$��	10,0,10,0q�5a   .     5c      $ Phone=�6.   $��50��5d   .   $��50��69   
	 �����$��	10,0,10,0q�5f   .   5h      5i      5j      �� 5k      $��1��6   
������ $��0q�5m        ChatItem#��[ 5o      ��5n      �� *MessagesWithSelectedUser+5o      � 5q      $��2��6    5r      �� 5s      �� 5t      $��80 �6+   .+�5v      �� $��0��6   $��Placeholder��5w        CustomTextBox#��[ 5x      �� 5z      $��1��6   $��25q�6-   ��5{      �� 5|      .R�5}   "     $
 Send=�62   $��40��5~   2   $��40��5   2   
	 �����5�   2   5�      5�      5�      5�      5�      5�      5�      