   M S B A M L   `   `   `  ����F  BDashboardUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DashboardUIDashboardUI  5   	   G(clr-namespace:DashboardUI.MVVM.ViewModelDashboardUI.MVVM.ViewModel  5   	       DashboardUI.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DashboardUI     5   	   >	viewModel(clr-namespace:DashboardUI.MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��720��5
   	   $
��1280��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5   
   .   (DashboardUI.MVVM.ViewModel.MainViewModel  5      .��5   
   �� ���#202020._�5      ]� .+�5      �� $	��Top=�6   $��38��5       J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6'    �� Command 5   '   �� *MoveWindowCommand+._�5       �  � ColumnDefinitions 5!      �� 5"      $��6* �6/   �� 5#      $��1* �6/   .+�5&      �� $��0��6$   $��🐧 DashboardUI��5'   $      NormalTextBlockStyleBold#��[  5(   $   $��12,2,2,0q�5)   $   $��Center=�5*   $   �� 5-      $��1��6%   	 �� Orientation$	 
Horizontal=�5.   %   $��Right=�5/   %   $��4q�50   %   .+�51      �� $��-��6%     TitlebarBtnTheme#��[ 53   %   ��52   %   �� *MinimizeWindowCommand+53   %   �� 54      $	��□��6%   #��[ 56   %   ��55   %   �� *MaximizeWindowCommand+56   %   �� 57      $��x��6%   #��[ 59   %   ��58   %   �� *ShutDownWindowCommand+59   %   5:      5;      5<      � 5?      $	��Top=�6    5@      �� 5A      $��60 �6+   �� 5B      .+�5F      �� $��0��6!   $��4,0,0,0q�61   $��Center=�6B   .+�5H      	� $
��🏠��6&   
 � ToolTip$
 HomeView��5J   &   ��5I   &   �� *ShowHomeViewCommand+5J   &   	� 5L      $
��📈��6&    d� 	IsChecked$
 TrueY�5N   &   $
 DashboardView��5O   &   ��5M   &   �� *ShowDashboardViewCommand+5O   &   	� 5Q      $
��🔔��6&   $
 NotificationView��5S   &   ��5R   &   �� *ShowNotificationViewCommand+5S   &   	� 5U      $��⚙️��6&   $
 SettingsView��5W   &   ��5V   &   �� *ShowSettingsViewCommand+5W   &   �� 5Y      
�������$��12q�6;   	� 5\      $	��❓��6&   $
 HelpView��5^   &   ��5]   &   �� *ShowHelpViewCommand+5^   &   	� 5`      $��✉️��6&   $
 SendMessageView��5b   &   ��5a   &   �� *ShowSendMessageViewCommand+5b   &   5c      �� 5f      $��1��6   ���#323232._�5h      �� ��6+   �� *CurrentView+5i      5k      5l      5m      5o      