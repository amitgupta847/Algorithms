   M S B A M L   `   `   `  ���� !  DataStructureAndAlgorithms.UI,    &DataStructureAndAlgorithms.UI.BasicsUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Basics�� � WindowState$ 	Maximized=�.���  � RowDefinitions �� �� ��  � ColumnDefinitions �� �� $��10 ��� �� $��10 ��� �� $��10���� �� $��10 �.+��� -    ��Name$ lstInput��$��0��$��0���� -   $ 	lstOutput��$��0��$��2���� $��0��$��4��
���   �$��1q�._��� $��0��$��4��$
��Auto=�$
��Auto=�.���� .+��� .+��� $	��Top=�$
��Left=����� $��Choose Input Type��.���� -    ��Name$ sSelectionType�� �� Orientation$ Vertical=�.+�	� -    	�Name$ rdoBtnUnsorted��$��10q�$��UnSorted�� d� 	IsChecked$
 TrueY�	� -   $! rdoBtnUnsortedWithDulicates��$��10q�$��UnSorted With Duplicates��$ FalseY�	� -   $ rdoBtnAlreaySortedAsc��$��10q�$'��!Already Sorted In Ascending Order��$ FalseY�	� -   $ rdoBtnAlreaySortedDesc��$��10q�$'��!Already Sorted In Desending Order��$ FalseY��� $
��Bold"�$��10q��� $!�Comparison Based Algorithms���� $��15q�$ 
Horizontal=�.+��� �� $!�Number of elements to sort:���� -   	 ��Name$	 txtNumberOfElements��$��5,0,0,0q�$��65��$
��1000���� -	   $��Load Data/Refresh���� $ Vertical=�.+��� $��15q�
���   �$��1q�
 �� CornerRadius$
 10��._��� $��15q�.+��� -
    ��Name$ txtAnalysisSelectionSort���� $�Analysis���� -   $ txtTotalTimeSelectionSort���� $�Total time:���� -    ��Name$ btnSelection��$��2��$��Selection Sort���� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ txtAnalysisBubbleSort���� $�Analysis���� -   $ txtTotalTimeBubbleSort���� $�Total time:���� -   $ btnBubbleSort��$��2��$��Bubble Sort���� $��0��$��6��
���   �$��1q�._��� $��0��$��6��$
��Auto=�$
��Auto=�.���� $��0��$��6��.+��� $
��Bold"�$��10q��� $)�#Divide and Conquer Based Algorithms���� .+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ txtAnalysisQuickSort���� $�Analysis���� -   $ txtTotalTimeQuickSort���� $�Total time:���� -   $ btnQuickSort��$��2��$��
Quick Sort���� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ txtAnalysisMergeSort���� $�Analysis���� -   $ txtTotalTimeMergeSort���� $�Total time:���� -   $ btnMergeSort��$��2��$��
Merge Sort���� .+��� $
��Bold"�$��10q��� $(�"Input Restriction Based Algorithms���� $��15q�$ 
Horizontal=�.+��� �� $�Range elements to sort:���� -   $	 txtStartRange��$��5,0,0,0q�$��65��$	��100���� -   $	 txtEndRange��$��5,0,0,0q�$��65��$	��500���� -   $��Load Data/Refresh���� $ Vertical=�.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ txtAnalysisRadixSort���� $�Analysis���� -   $ txtTotalTimeRadixSort���� $�Total time:���� -   $ btnRadixSort��$��2��$��
Radix Sort���� $ Vertical=�.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ txtAnalysisCountSort���� $�Analysis���� -   $ txtTotalTimeCountSort���� $�Total time:���� -   $ btnCountSort��$��2��$��
Count Sort���� $ Vertical=�.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -   $ btnQuickFind��$��2��$��
Quick Find���� $ Vertical=�.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� -    $ btnQuickUnion��$��2��$��Quick Union��� $��1��$��5��.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� $��20q�$ 
Horizontal=�.+��� $��Number���� -!   $	 txtFibNumberRec��$��50,0,0,0q�$	��100��$��5���� -"   $! txtAnalysisFibocciRecursive���� $�Analysis���� -#   $" txtTotalTimeFibocciRecursive���� $�Total time:���� -$   $ txtResultFibocciRecursive���� $�Result:���� -%   $ 	btnFibRec��$��10q�$��2��$!��Fibonoci Recursive Solution���� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� $��20q�$ 
Horizontal=�.+��� $��Number���� -&   $	 txtFibNumberNonRec��$��50,0,0,0q�$	��100��$��50���� -'   $$ txtAnalysisFibocciNonRecursive���� $�Analysis���� -(   $( "txtTotalTimeNonFibocciNonRecursive���� $�Total time:���� -)   $" txtResultFibocciNonRecursive���� $�Result:���� -*   $ btnFibNonRec��$��10q�$��2��$!��Fibonoci Non Recursive Sort��� $��2��$��5��.+��� $��15q�
���   �$��1q�$
 10��._��� $��15q�.+��� $��20q�$ 
Horizontal=�.+��� $��A���� -+   $	 txtGCDNumberA��$��50,0,0,0q�$	��100��$	��357���� $��20q�$ 
Horizontal=�.+��� $��B���� -,   $	 txtGCDNumberB��$��50,0,0,0q�$	��100��$	��234���� --   $ txtAnalysisGCD���� $�Analysis���� -.   $ txtTotalTimeGCD���� $�Total time:���� -/   $ txtResultGCD���� $�Result:���� -0   $ btnGCD��$��10q�$��2��$��Greatest Common Divisior��