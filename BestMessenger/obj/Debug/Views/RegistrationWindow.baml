   M S B A M L   `   `   `  ����H  DBestMessenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BestMessenger.ViewsBestMessenger.Views  5   	   C&clr-namespace:BestMessenger.ViewModelsBestMessenger.ViewModels  5   	   ,    &BestMessenger.Views.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BestMessenger.Views     5   	   5vm&clr-namespace:BestMessenger.ViewModels     5   	   -   5          � Title$  RegistrationWindow��5   	   $	��600��5	   	   $	��800��6    � AllowsTransparency .  ���#212121 � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � DataContext 5      4   .BestMessenger.ViewModels.RegistrationViewModel  5   
   6%   .��5      ]� .+�5   
   �� 
������ $	��Top=�6*   ._�5      � $��Stretch=�6   .+�5      �� $��Best Messenger��6   
�������$
��Bold"�5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�5      .+�5      ��    MinimizeBtnStyle#��[  6   ��5      �� *WindowMinimizeCommand+�� 5!        MaximizeBtnStyle#��[ 6   ��5"      �� *WindowMaximizeCommand+�� 5$        CloseWindowBtnStyle#��[ 6   ��5%      �� *CloseWindowCommand+5'      5(      5)      o� 5*   
   $	��Top=�6   .@�5+      m� $��Application��6   .@�5,      m� $��CloseApp��6   5.      5/      50      �� 51   
   .+�52      �� $	��250��6   $��25q�6"   ��53      �� *	FirstName+63   �� 54      $��First name incorrect data��6   $��Center=�55      ��56      �� 57       �� 
TargetType" ��6   .�58      ��  �� Property � �� �� Value
 �  ��67   �� 59       � y�$ 	Collapsed=�67   	 �� Triggers	 5:      �� 5;      
 �� Binding
 6*   �� *	NameValid+ �� Value	 False6H   .a�5<   "   ��  � y�$ Visible=�6?   5=      5?      5A      �� 5B      $	��250��6   $��20q�6"   ��5C      �� *
LastName+5D      �� 5E      $��Last name incorrect data��6   $��Center=�5F      
���  ��$y�	Collapsed=�5H      5I      �� 5J      $	��250��6   $��20q�6"   ��5K      �� *Email+5M      �� 5N      $��Email incorrect data��6   $��Center=�5O      
���  ��$y�	Collapsed=�5Q      5R      �� 5S      $	��250��6   $��20q�6"   ��5T      �� *
NickName+5U      �� 5V      $��NIckname incorrect data��6   $��Center=�5W      
���  ��$y�	Collapsed=�5Y      5Z      �� 5[      $	��250��6   $��20q�6"   ��5\      �� *
Password+5]      �� 5^      $��Password incorrect data��6   $��Center=�5_      
���  ��$y�	Collapsed=�5a      5b      �� 5c      $	��250��6   $��20q�6"   60   �� 5d      $!��Photo source incorrect data��6   $��Center=�5e      
���  ��$y�	Collapsed=�5g      5h      �� 5i      $	��150��6   $��20��6!   $��Register��6-   ��5j      �� *RegistrationCommand+5l      5m      5n      5o      