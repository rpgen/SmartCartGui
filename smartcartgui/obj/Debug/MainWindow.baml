   M S B A M L   `   `   `  ����G  Csmartcartgui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:smartcartguismartcartgui  5   	       smartcartgui.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:smartcartgui     5   	     � WindowState$  	Maximized=�5   	    � Title$ 
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   �� -   5         ��Name$ button��5      $��	Check Out��6!   $��Right=�65   $��	0,0,11,17q�6Q   $��Bottom=�6d   $��75��6   6�   �� 5   
   -   5         ��Name$ label��5      $��Total:��6   $��Right=�60   $��0,0,146.667,14.333q�6L   $��Bottom=�6h   $��38��6�   �� 5   
   -   5        $ label1��5      $��36(�6   $��	SmartCart��6.   $
��Left=�6B   $��	10,10,0,0q�6]   $	��Top=�6p   $��60��6�   $	��203��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   +      CanUserAddRows .  $��10,75,9.667,56.333q�6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *name+6L     5      $ Price��6%   	 64   �� *price+  5      $ Quantity��6%   	 67   �� *
quantity+5      � 5   
   -   5        $
��Left=�5      $��10��61   $��27,0,0,13.333q�6=   $��Bottom=�6T   $	��125��6o   6{   �� 5   
   -   5        $ label2��5      $ ��Progress to Spending Limit��6    $��Right=�6E   $��0,0,366.667,23.333q�6a   $��Bottom=�6}   $��Italic$�6�   $��10(�6�   $	��125��6�   �� 5   
   -   5        $��	ComboBox1��5      $
��Left=�6$   $	��Top=�6?   $	��120��6W   $��
388,33,0,0q�6c   .@�5      �� -   5        $��cb_limit��5      .��6+   Set Spending Limit Click6E   �� 5      .��6   
Override6%   �� 5      .��6   Help6!   �� 5      .��6   Help6!   5      �� 5"   
   -	   5        $ 	SomeLabel��5"      
 �� ContentStringFormat$
 yyyy-MM-dd HH:mm:ss��6G   $��
218,33,0,0q�6q   $��10��6�   $	��Top=�6�   $
��Left=�6�   $��10��6�   ��6#   �� *CurrentDateTime+6�   �� 5#   
   -
   5        $ total_output��5#      $	��lll��6&   $��Right=�64   $��0,0,108.667,14.333q�6P   $��Bottom=�6l   $��38��6�   5%      5&      