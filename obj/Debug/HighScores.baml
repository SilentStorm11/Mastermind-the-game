   M S B A M L   `   `   `  ����D  @Projekat2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Projekat2	Projekat2  5          Projekat2.HighScores   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Projekat2     5        N� Title$  
HighScores��5	      .��5      � 
��� ��� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $��6* �6   .+�5   
   �� -   5        $
��back��5      $��0��6   $��10,10,10,10q�6+   $��Right=�6@   
���2�2�
���   �$��12(�6�   $��	UltraBold"�6�   $��30��6�   $��40��6�   .��6�   	Go Back6�   r� 5   
   -   5        $��
klik_sound��5       r� LoadedBehavior$ Manual=�6)    r� Source$ Sounds/inmenubtns.mp3?�6d   $��-201,54,1014,304.8q�6�   $y�	Collapsed=�6�   �� 5   
   -   5        $��naslov��5      $��0��6   $��Center=�6+   $��Center=�6I   $��0q�6d   $��30(�6o   $��Oblique$�6}   $��
UltraBlack"�6�   .��6�   High Scores6�   �� 5   
   -   5        $	��lab��5   0   $��1��6   $��	0,-15,0,0q�6   $y�Visible=�6;   $��Center=�6P   $��Center=�6n   $��Italic$�6�   $��13(�6�   $��DemiBold"�6�   
���2�2�.��6�   Choose game difficulty6�   �� 5   
   -   5        $��tezine��5   "   $��2��6   $��Center=�60    �� Orientation$ 
Horizontal=�6N   $��
0,-30,0,-4q�6g   $y�Visible=�6{   .+�5      �� -   5        $
��easy��5   -   $��Center=�69   $��Center=�6W   $��Oblique$�6r   $��	ExtraBold"�6�   .��6�   easy6�   �� 5      -   5        $��normal��5   ,   $��Center=�6:   $��Center=�6W   $��Oblique$�6r   $��	ExtraBold"�6�   .��6�   normal6�   �� 5      -   5        $
��hard��5   ,   $��Center=�69   $��Center=�6V   $��Oblique$�6q   $��	ExtraBold"�6�   .��6�   hard6�   5      &   System.Windows.Controls.DataGrid  5   
   -	   5        $��tabela��5   ?   $��3��62      CanUserDeleteRows .     CanUserAddRows .     CanUserSortColumns .    AutoGenerateColumns .  	   
IsReadOnly	 . $	��Top=�5   k   $	��250��6�   $	��420��6�   
   MinColumnWidth$	
 130Q�6�   ��6/   ��  �� Source$ 
GeTSetEasy��   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 63      MinWidth$	 200Q�6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6V   �� *Name+  5"      $ Score��6%   $ SizeToCells 64   $	 200Q�6H    6W   �� *Score+5%      5(      5)      