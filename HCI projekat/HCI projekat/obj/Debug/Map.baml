   M S B A M L   `   `   `  ����G  CHCI projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HCI_projekatHCI_projekat  5   	       HCI_projekat.Map   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HCI_projekat     5   	     � Title$	  Map��5   	   $	��800��6   $	��800��6"   .��5	      � .+�5
   
   �� -   5         ��Name$
 mapa��5
      $	��752��6   $��Center=�6+   $	��414��6H   $	��Top=�6U   $��0,0,0,0q�6m    J� 	AllowDrop . ��5      �� 5       �� ImageSource$> 8C:\Users\Nastasja\Desktop\Hci\HCI projekat\world-map.gif��6   5      �� 5   
   -   5         ��Name$ PrikazIkone��5      $��5��6%   $
��Left=�65   $��97��6P   $��141.2,459,0,0q�6\   $	��Top=�6�   $	��116��6�    � Cursor$
 Hand��6�   6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dogadjajiGrid��5         AutoGenerateColumns .  $	��250��6G   $��5��6�   $��400,420,10,100q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Ime��6%   
   
IsReadOnly
 .    Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Name+6]     5      $		 Tip��6%   
 . $ 3* 6]    6D   �� *Type+6]   5      �� 5   
   -   5        $��80��5      $��30��6   $��2q�5      ���	#FF116FA4���	#FF116FA4
������� � ToolTip$ Cancel��5   G   $
��Back��6X   $��Center=�5      $��Center=�6:   $��	0,650,0,0q�6U   $
��13.5(�6h   6x   �� 5   
   -   5        $	��130��5      $��30��6   $��2q�5      ���	#FF116FA4
���\\��
�������$ Cancel��5   G   $��Remove from map��6X   $��Center=�5      $��Center=�6:   $��-400,450,0,0q�6U   $
��13.5(�6k   6{   5      5       