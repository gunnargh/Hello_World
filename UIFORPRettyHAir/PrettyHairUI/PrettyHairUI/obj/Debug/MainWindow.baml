   M S B A M L   `   `   `  ����G  CPrettyHairUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PrettyHairUIPrettyHairUI  5   	       PrettyHairUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PrettyHairUI     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	      "   PrettyHairUI.EJL72_DBDataSet   eJL72_DBDataSet  colorViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6    �� 5   
    67   �� *Color+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��261��6D   $��	24,41,0,0q�6Q   $	��Top=�6d   $	��355��6|   .@�5      �� $��Products��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6-   $	��234��6H   $��-4,0,0,0q�6U   $	��Top=�6g   $	��353��6   ��6�   �� 5      5      �� 5      $��Orders��6   5      �� 5      $��Customer��6   5      5      �� 5   
   -   5         ��Name$ button��5      $	��Add��6!   $
��Left=�6/   $	��Top=�6J   $��75��6b   $��
405,75,0,0q�6m   $��1q�6�   �� 5   
   -   5        $ button_Copy��5      $
��Edit��6&   $
��Left=�65   $	��Top=�6P   $��75��6h   $��405,125,0,0q�6s   �� 5   
   -   5        $ button_Copy1��5      $��Delete��6'   $
��Left=�68   $	��Top=�6S   $��75��6k   $��405,100,0,0q�6v   5!      5"      