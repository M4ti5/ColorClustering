   M S B A M L   `   `   `  ���� M  IGUIColorClustering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  #    GUIColorClustering.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:WPF     ���#36393E  � Title$  ColorClusturing��$	��450��$	��800�� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $	��87* ��� $
��130* �.+��� $��  ColorClustering��$��Center=�$��0,10,0,0q�$	��Top=�$��24(�
�������$
��Bold"�$��45��$	��210��$&�� Segoe UI Variable Small Semibold)��� -    ��Name$ importButton��$��Import an Image��$
��Left=�$��	50,50,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.661,0.533&�$��20��$	��215���� -    ��Name$ importRectangle��$	��290��$��	50,70,0,0q�$��2��$
��Left=�$	��Top=�$	��215�����	#FFC2C2C2�� -    ��Name$ importImage��$��Uniform=�$	��290��$��	50,70,0,0q�$
��Left=�$	��Top=�$	��215��$��2���� -   $ exportButton��${�False��$��Export the Image��$��Right=�$��	0,50,50,0q�$	��Top=�$ 0.661,0.533&�$��20��$	��216���� -   $ exportRectangle��$��Right=�$	��290��$��	0,70,50,0q�$��2��$	��Top=�$	��215�����	#FFC2C2C2�� -   $ exportImage��$��Uniform=�$	��290��$��	0,70,50,0q�$	��Top=�$��Right=�$	��215��$��2���� -   $ 	runBotton��${�False��$	��Run��$��Center=�$��	0,167,0,0q�$	��Top=�$ 0.661,0.533&�$��43��$	��108��$��1���� $��
0,60,0,100q�$��Center=�$	��210��$��2��.@��� $��K-means��$��
-2,0,-50,0q�.��� 
�������.+��� $��Distance method��$
��Left=�$��	23,35,0,0q�$	��Top=��� -    ��Name$ distanceMethod��$
��Left=�$��	25,61,0,0q�$	��Top=�$	��149��$��20��.@���  �� 
IsSelected$
 True��.��	Euclidian�� .��	Manhattan�� $��Number of clusters��$
��Left=�$��	23,95,0,0q�$	��Top=��� -	   	 ��Name$	 numberClustersTextBox��$��Right=�$��
0,100,30,0q�$��1��
 �� TextWrapping$

 Wrap=�$	��Top=�$��32��$��20���� $��Number of iterations��$
��Left=�$��
23,145,0,0q�$	��Top=��� -
   $	 numberInterationsTextBox��$��Right=�$��
0,150,30,0q�$��1��$

 Wrap=�$	��Top=�$��32��$��20���� -    ��Name$ 	DBScanTab��$��DBscan��$��50,0,-100,0q�$��20��$	��Top=�.��� 
�������.+��� $��Minimal size of groups��$
��Left=�$��	20,60,0,0q�$	��Top=��� -   $	 minimalSizeofGroupTextBox��$��Right=�$��	0,66,20,0q�$��1��$

 Wrap=�$	��Top=�$��32��$��20���� $��Maximal Distance��$
��Left=�$��
23,145,0,0q�$	��Top=��� -   $	 distanceTextBox��$��Right=�$��
0,150,20,0q�$��1��$

 Wrap=�$	��Top=�$��32��$��20���� -    ��Name$ statusProgress��$�� ��$
��Left=�$��	0,224,0,0q�$��1��$	��Top=�$	��596��
�������$��Italic$�� $��13��$��Bottom=�$��1��$��	0,0,100,0q��� $��Made by Matis C.��$��Right=�$��Bottom=�$��0,0,0,-6q�
�������$��1��$	��100��