   M S B A M L   `   `   `  ����!  DataStructureAndAlgorithms.UI)    #DataStructureAndAlgorithms.UI.Clock   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��50 �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� 6   �� 5   
   -   5        $��	lblMinute��5   5   $��40(�6   $��SemiBold"�6   $��1��6F   $��1��6S   .��6c   006g   �� 5    
   $��40(�6   $��SemiBold"�6   $��1��64   $��2��6A   .��6Q   :6T   �� 5!   
   -   5        $��lblSec��5!   5   $��40(�6   $��SemiBold"�6   $��1��6C   $��3��6P   .��6`   006d   �� 5"   
   $��40(�6   $��SemiBold"�6   $��1��64   $��4��6A   .��6Q   :6T   �� 5#   
   -   5        $��
lblCounter��5#   5   $��40(�6   $��SemiBold"�6   $��1��6G   $��5��6T   .��6d   06g   �� 5%   
   $��10q�6   $��3��6!   $��1��6.   $��5��6>   $��1��6R    �� Orientation$ 
Horizontal=�6c   .+�5&      �� -   5        $��btnStart��5&      
���  ��$��SemiBold"�6M   ��6d   ��  �� ElementName$ btnReset�� �� Path$ Width�.��6�   Start6�   �� 5'      -   5        $��btnReset��5'   )   $��10,0,0,0q�6   
���  ��$��SemiBold"�6K   $��50��6w   $	��100��6�   .��6�   Reset6�   5(      5)      5*      