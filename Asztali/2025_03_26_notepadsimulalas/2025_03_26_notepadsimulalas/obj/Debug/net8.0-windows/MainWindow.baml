   M S B A M L   `   `   `  ����V  R2025_03_26_notepadsimulalas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_2025_03_26_notepadsimulalas_2025_03_26_notepadsimulalas  5   	   -    '_2025_03_26_notepadsimulalas.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_2025_03_26_notepadsimulalas     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��567��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$
 Save��5
      6(     5   
   -   5        $
 Open��5      6(     5   
   -   5        $	 New��5      6'     5   
   -   5        $ Close��5      6)   .��5      � $��0,0,0,-6q�6    � ColumnDefinitions 5   
   �� 5      .+�5   
   o� $��20��6   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $
��Save��6    m� Command$
 Save��6)   m� 5      $
��Open��6   $
 Open��6)   m� 5      $	��New��6   $	 New��6(   m� 5      $
��Exit��6   $ Close��6)   5      5      c� 5   
   $
��Left=�6   $��26��6-   $��0,20,0,0q�69   $	��Top=�6K   $	��766��6c   .@�5      �� $
��Save��6   $
��Save��6$   �� 5      $
��Open��6   $
��Open��6$   �� 5      $	��New��6   $	��New��6#   5       �� 5!   
   $��0,46,0,0q�6   . �5"      /� .T�5#      J� .*�6   .*�5$      �� $�RichTextBox��6   5%      5&      5'      5(      5)      