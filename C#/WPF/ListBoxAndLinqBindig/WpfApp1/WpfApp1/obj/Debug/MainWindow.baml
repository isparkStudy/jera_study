   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	         WpfApp1.Duties 
  duties  
MyTemplate � RowDefinitions � ColumnDefinitions �� Path  GrayBlueGradientBrush �� 
StartPoint �� EndPoint � Color � Offset	 �� 
TargetType
 �� Property �� Value��%  &	        &	      &	     '�� �    7    5
   
   6   �� 5   
   .R�5      �� $��border��6   ._�5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $��0��6    $��0��6-   $��
Duty Name:��6=   �� 5      $��0��6    $��1��6-   ��6=   �� $ DutyName��� 5      $��1��6    $��0��6-   $��
Duty Name:��6=   �� 5      $��1��6    $��1��6-   ��6=   �� $ DutyType��� 5      $��2��6    $��2��6-   5      5      5      �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5       � $ DarkGray��6   $ 0Q�6,   � 5!      $ #CCCCFF��6   $	 0.5Q�6+   � 5"      $ DarkGray��6   $ 1Q�6,   5#      �� 5%   
   "	 ��6   .�5&      �� 
 � ��8   6+   �� 5'      
 � ��$ 80��6&   �� 5(      
 � ��$ 10q�6'   5)      5*      .��5+      �� .+�5,   
   �� -   5         ��Name$	 Add��5,      .��64   직무 추가6;   �� 5-   
   $��10,0,0,0q�6   " 직무타입을 선택하세요.64   �� 5.   
   -   5        $��
myListBox1��5.       �� SelectedIndex$ 0��5/      $��	10,0,10,0q�6$   .@�50      �� .��6   Inner6!   �� 51      .��6   	OutSide6#   52      �� 53   
   $��10,10,0,-10q�6   직무6-   �� 54   
   -   5        $��
myListBox2��54   7   $	��400��6   $	��150��6   $��10q�6+   $��Stretch=�6I   #��[ 55      ��54   n   �� 55   =   56      57      