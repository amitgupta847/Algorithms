   M S B A M L   `   `   `  ���� !  DataStructureAndAlgorithms.UI+    %DataStructureAndAlgorithms.UI.TreesUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Basics�� � WindowState$ 	Maximized=�.���  � RowDefinitions �� �� ��  � ColumnDefinitions �� �� $��10 ��� �� $��10 ��� �� $��10���� �� $��10 �.+��� -    ��Name$ lstInput��$��0��$��0���� -   $ 	lstOutput��$��0��$��2���� $��0��$��4��
���   �$��1q�._��� $��0��$��4��$
��Auto=�$
��Auto=�.���� .+��� .+��� $	��Top=�$
��Left=����� $��Choose Input Type���� $
��Bold"�$��10q��� $!�Comparison Based Algorithms���� $��15q� �� Orientation$ 
Horizontal=�.+��� �� $!�Number of elements to sort:���� -    ��Name$ txtNumberOfElements��$��5,0,0,0q�$��65��$
��1000��� $��1��$��5��.+��� $��15q�
���   �$��1q� �� CornerRadius$ 10��._��� $ Vertical=�.+��� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -    ��Name$ btnQuickFind��$��2��$��
Quick Find���� $��15q�
���   �$��1q�$ 10��._��� $ Vertical=�.+��� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� -   $ btnQuickUnion��$��2��$��Quick Union��� $��2��$��5��.+��� $��15q�
���   �$��1q�$ 10��._��� $��15q�.+��� $��20q�$ 
Horizontal=�.+��� $��A���� -   $ txtGCDNumberA��$��50,0,0,0q�$	��100��$	��357���� $��20q�$ 
Horizontal=�.+��� $��B���� -   $ txtGCDNumberB��$��50,0,0,0q�$	��100��$	��234���� -   	 ��Name$	 txtAnalysisGCD���� $�Analysis���� -	   $	 txtTotalTimeGCD���� $�Total time:���� -
   $	 txtResultGCD���� $�Result:���� -   $ btnGCD��$��10q�$��2��$��Greatest Common Divisior��