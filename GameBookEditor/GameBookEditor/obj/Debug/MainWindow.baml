   M S B A M L   `   `   `  ����I  EGameBookEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GameBookEditorGameBookEditor  5   	       GameBookEditor.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GameBookEditor     5   	     � Title$  Game Book Editor��5   	   $	��450��6"   $	��800��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5"   
   �� $��Story��6   $��1��6    $��1��60   6?   �� 5#   
   -   5         ��Name$ lblStoryName��5#      $��Not selected��6&   $��2��6=   $��1��6M   6\   �� 5&   
   $��Stories��6   $��1��6"   $��2��62   6A   �� 5(   
   -   5         ��Name$ 
cboStories��5(      $��2��6'   $��2��67   ��5)      �� 5*      .R�5+      �� ��6    �� *	firstName+5,      5.      �� 51   
   -   5         ��Name$ btnNewStory��51      $��Add New Story��6&   $��1��6>   $��3��6N   6[   �� 52   
   -   5        $ btnNewStoryBlock��52      $��Add New Story Block��6+   $��1��6I   $��4��6Y   6f   �� 53   
   -   5        $��Refresh��53      $��1��6#   $��5��63   6@   �� 54   
   $��Story blocks��6   $��1��6'   $��6��67   6F   �� 55   
   -   5        $ cboStoryBlocks��55      $��2��6+   $��7��6;   ��56      �� 57      .R�58      �� ��6    �� *	firstName+59      5;      �� 5=   
   -   5        $��Export Story��5=      $��1��6(   $��8��68   6^   5@      5A      