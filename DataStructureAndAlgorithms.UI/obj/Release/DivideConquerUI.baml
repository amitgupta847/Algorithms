   M S B A M L   `   `   `  ���� !  DataStructureAndAlgorithms.UI3    -DataStructureAndAlgorithms.UI.DivideConquerUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  DivideConquerUI�� � WindowState$ 	Maximized=�.��� -   $��graphMainGrid�� � RowDefinitions �� $��9* ��� ��  � ColumnDefinitions �� �� $��10 ��� �� $��10 ��� �� $��80 �.+��� $��0��$��0��$
��Auto=�$
��Auto=�.���� .+��� $
��Bold"�!Graph representation for cities�� -   $��lstInput������  �� Path$ CityGraph.Vertices����� .R��� .+��� ���� *Description+�� ���� $ Edges��� $��0��$��2��$
��Auto=�$
��Auto=�.���� .+��� $
��Bold"�Graph operation result�� -   $��	lstOutput������ $ ResultedGraph.Vertices����� .R��� .+��� ���� *Description+�� ���� $ Edges��� $��0��$��4��$��Visible=�$��Visible=�$��2��$��0.2,0,79.6,0.2q�.���� $��0��$��4��.+��� .+��� $	��Top=�$
��Left=����� $��Choose Input Type���� $��15q� �� Orientation$ 
Horizontal=�.+��� N:�� -   $��txtNumberOfElements��$��5,0,0,0q�$��65��.��1000�� -   .��Load Data/Refresh�� $ Vertical=�.+��� $��15q�
���   �$��1q� �� CornerRadius$ 10��._��� $��15q�.+��� -   $��txtAnalysisInsertionSort��
Analysis�� -   $��txtTotalTimeInsertionSort��Total time:�� -   $��btnCountingInversion��.�� Counting Inversion (Mergesort)�� -	   $ ��btnMinimumRefillsEfficient��$��2��.��Minimum Refills (Efficient)�� -
   $��btnOneDiminPeakFind��.��One Dim Peak Finding�� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� '%Enter node short name("A,B C extra"):�� -   $��txtTotalTimeSelectionSort��From:�� -   $��txtFrom��$��65���� -   $��txtfa��To:�� -   $��txtTo��$��65���� -   $��btnDijsktra��$��2��.��Dijsktra shortest path�� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -   $��txtAnalysisBubbleSort��
Analysis�� -   $��txtTotalTimeBubbleSort��Total time:�� -   $��btnBubbleSort��$��2��.��Bubble Sort�� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -   $��txtAnalysisQuickSort��
Analysis�� -   $��txtTotalTimeQuickSort��Total time:�� -   $��btnQuickSort��$��2��.��
Quick Sort�� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -   $��txtAnalysisMergeSort��
Analysis�� -   $��txtTotalTimeMergeSort��Total time:�� -   $��btnMergeSort��$��2��.��
Merge Sort�� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -   $��txtAnalysisRadixSort��
Analysis�� -   $��txtTotalTimeRadixSort��Total time:�� -   $��btnRadixSort��$��2��.��
Radix Sort