   M S B A M L   `   `   `  ����X  TDataStructureAndAlgorithms.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:DataStructureAndAlgorithms.UIDataStructureAndAlgorithms.UI  5   	   -    'DataStructureAndAlgorithms.UI.SortingUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =UserC+clr-namespace:DataStructureAndAlgorithms.UI     5   	     � Title$  Sorting��5   	    � WindowState$ 	Maximized=�6   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��9* �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��10 �6   �� 5      �� 5      $��10 �6   �� 5      �� 5      $��10��6   �� 5      �� 5      $��10 �6   .+�5   
   )   #DataStructureAndAlgorithms.UI.Clock  $��0��6   $��2��6#   $��3��63   6I   �� 5    
   -   5         ��Name$ lstInput��5       $��1��6$   $��0��61   �� 5!   
   -   5        $ 	lstOutput��5!      $��1��6&   $��2��63   �� 5#   
   $��1��6   $��4��6   
���   �$��1q�6B   ._�5$      �� $��0��6   $��4��6(   $
��Auto=�68   $
��Auto=�6]   .��5%      �� .+�5&      �� .+�5'      �� $	��Top=�6#   $
��Left=�6;   ��5(      �� 5)   "   $��Choose Input Type��6,   .��5+      �� -   5         ��Name$ sSelectionType��5+   )    �� Orientation$ Vertical=�6A   .+�5,   "   	� -   5         	�Name$ rdoBtnUnsorted��5,   .   $��10q�6l   $��UnSorted��6x    d� 	IsChecked$
 TrueY�6�   	� 5-   "   -   5        $! rdoBtnUnsortedWithDulicates��5-   .   $��10q�6y   $��UnSorted With Duplicates��6�   $ FalseY�6�   	� 5.   "   -   5        $ rdoBtnAlreaySortedAsc��5.   .   $��10q�6s   $'��!Already Sorted In Ascending Order��6   $ FalseY�6�   	� 5/   "   -   5        $ rdoBtnAlreaySortedDesc��5/   .   $��10q�6u   $'��!Already Sorted In Desending Order��6�   $ FalseY�6�   50      51      52      �� 54      $
��Bold"�6    $��10q�62   �� 6?   $!�Comparison Based Algorithms��6C   6i   �� 55      $��15q�6!   $ 
Horizontal=�6-   .+�56      �� �� 6%   $!�Number of elements to sort:��6)   6O   �� 57      -   5        	 ��Name$	 txtNumberOfElements��57   3   $��5,0,0,0q�6"   $��65��6P   $
��1000��6[   58      �� 59      -	   5        $��Load Data/Refresh��59   6   �� 5;      $ Vertical=�6!   .+�5=      �� $��15q�6!   
���   �$��1q�6A   
 �� CornerRadius$
 10��6U   ._�5>      �� $��15q�6)   .+�5?   "   �� -
   5         ��Name$ txtAnalysisInsertionSort��5?   -   �� 6P   $�Analysis��6T   6g   �� 5@   "   -   5        $ txtTotalTimeInsertionSort��5@   -   �� 6Q   $�Total time:��6U   6k   �� 5A   "   -   5         ��Name$ btnInsertion��5A   *   $��2��6S   $��Insertion Sort��6c   5B      5C      �� 5E      $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5F      �� $��15q�6)   .+�5G   "   �� -   5        $ txtAnalysisSelectionSort��5G   -   �� 6P   $�Analysis��6T   6g   �� 5H   "   -   5        $ txtTotalTimeSelectionSort��5H   -   �� 6Q   $�Total time:��6U   6k   �� 5I   "   -   5        $ btnSelection��5I   *   $��2��6S   $��Selection Sort��6c   5J      5K      �� 5M      $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5N      �� $��15q�6)   .+�5O   "   �� -   5        $ txtAnalysisBubbleSort��5O   -   �� 6M   $�Analysis��6Q   6d   �� 5P   "   -   5        $ txtTotalTimeBubbleSort��5P   -   �� 6N   $�Total time:��6R   6h   �� 5Q   "   -   5        $ btnBubbleSort��5Q   *   $��2��6T   $��Bubble Sort��6d   5R      5S      5V      5X      5Y      5Z      �� 5\   
   $��1��6   $��6��6   
���   �$��1q�6C   ._�5]      �� $��0��6   $��6��6(   $
��Auto=�68   $
��Auto=�6]   .��5^      �� $��0��6   $��6��6*   .+�5_      �� $
��Bold"�6    $��10q�62   �� 6?   $)�#Divide and Conquer Based Algorithms��6C   6q   �� 5`      .+�5a      �� $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5b      �� $��15q�6)   .+�5c   "   �� -   5        $ txtAnalysisQuickSort��5c   -   �� 6L   $�Analysis��6P   6c   �� 5d   "   -   5        $ txtTotalTimeQuickSort��5d   -   �� 6M   $�Total time:��6Q   6g   �� 5e   "   -   5        $ btnQuickSort��5e   *   $��2��6S   $��
Quick Sort��6c   5f      5g      �� 5i      $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5j      �� $��15q�6)   .+�5k   "   �� -   5        $ txtAnalysisMergeSort��5k   -   �� 6L   $�Analysis��6P   6c   �� 5l   "   -   5        $ txtTotalTimeMergeSort��5l   -   �� 6M   $�Total time:��6Q   6g   �� 5m   "   -   5        $ btnMergeSort��5m   *   $��2��6S   $��
Merge Sort��6c   5n      5o      5p      �� 5s      .+�5t      �� $
��Bold"�6$   $��10q�66   �� 6C   $(�"Input Restriction Based Algorithms��6G   6t   5�      �� 5�      $��15q�6!   $ 
Horizontal=�6-   .+�5�      �� �� 6%   $�Range elements to sort:��6)   6K   �� 5�      -   5        $	 txtStartRange��5�   3   $��5,0,0,0q�6"   $��65��6J   $	��100��6U   �� 5�      -   5        $	 txtEndRange��5�   3   $��5,0,0,0q�6"   $��65��6H   $	��500��6S   5�      �� 5�      -   5        $��Load Data/Refresh��5�   6   �� 5�      $ Vertical=�6!   .+�5�      �� $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5�      �� $��15q�6)   .+�5�   "   �� -   5        $ txtAnalysisRadixSort��5�   -   �� 6L   $�Analysis��6P   6c   �� 5�   "   -   5        $ txtTotalTimeRadixSort��5�   -   �� 6M   $�Total time:��6Q   6g   �� 5�   "   -   5        $ btnRadixSort��5�   *   $��2��6S   $��
Radix Sort��6c   5�      5�      5�      �� 5�      $ Vertical=�6!   .+�5�      �� $��15q�6!   
���   �$��1q�6A   $
 10��6U   ._�5�      �� $��15q�6)   .+�5�   "   �� -   5        $ txtAnalysisCountSort��5�   -   �� 6L   $�Analysis��6P   6c   �� 5�   "   -    5        $ txtTotalTimeCountSort��5�   -   �� 6M   $�Total time:��6Q   6g   �� 5�   "   -!   5        $ btnCountSort��5�   *   $��2��6S   $��
Count Sort��6c   5�      5�      5�      5�      5�      5�      5�      5�      