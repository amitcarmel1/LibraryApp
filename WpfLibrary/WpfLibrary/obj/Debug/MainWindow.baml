   M S B A M L   `   `   `  ????E  AWpfLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfLibrary
WpfLibrary  5   	   =#clr-namespace:WpfLibrary.UIelementsWpfLibrary.UIelements  60       WpfLibrary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfLibrary     5   	   :
uielements#clr-namespace:WpfLibrary.UIelements     60     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? DataContext 5	      ??    Locator ?? Source# [   ?? Path$ TBViewModel?.??5
      ? .+?5   
   ?? -   5         ??Name$ 
tabControl??5       ?? SelectedIndex 6)   ?? *Num+ ?? Mode$ TwoWay=?.@?5      ?? $??25??6   $??80??6"   
?????? ??5      ?? 5       ?? Orientation$ 
Horizontal=?6!   .+?5      ?? $??/Images/library-icon.png??6   $??20??68   ?? 5      $??Register??6$   66   5      .??5      (   "WpfLibrary.UIelements.MainRegister  6,   5      ?? 5      
?????? y?6/   ?? *IsVisibleForWorker+??5      ?? 5      $ 
Horizontal=?6!   .+?5      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5      $??Workers??6$   65   5      .??5      (   "WpfLibrary.UIelements.WorkerAction  6,   5      ?? 5      
?????? y?6/   ?? *IsVisibleForWorker+??5       ?? 5!      $ 
Horizontal=?6!   .+?5"      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5$      $??Add\Delete Item??6$   6=   5%      .??5'      %   WpfLibrary.UIelements.AddItemUC  6)   5(      ?? 5,      
?????? y?60   ?? *IsVisibleForCustomer+??5-      ?? 5.      $ 
Horizontal=?6!   .+?5/      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 50      $??Borrow??6$   64   51      .??53      "   WpfLibrary.UIelements.Borrow  6&   54      ?? 55      
?????? y?60   ?? *IsVisibleForCustomer+??56      ?? 57      $ 
Horizontal=?6!   .+?58      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5:      $??
End Borrow??6$   68   5;      .??5=      %   WpfLibrary.UIelements.EndBorrow  6)   5>      ?? 5?      
?????? y?60   ?? *IsVisibleForWorker+??5@      ?? 5A      $ 
Horizontal=?6!   .+?5B      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5C      $??Reports??6$   65   5D      .??5F      ,   &WpfLibrary.UIelements.ReportProduction  60   5G      ?? 5H      
?????? ??5I      ?? 5J      $ 
Horizontal=?6!   .+?5K      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5L      $??Top 5??6$   63   5M      .??5O      %   WpfLibrary.UIelements.TopFiveUc  6)   5P      ?? 5Q      
?????? y?6/   ?? *IsVisibleForCustomer+??5R      ?? 5S      $ 
Horizontal=?6!   .+?5T      ?? $??/Images/library-icon.png??6    $??20??6B   ?? 5U      $??Returnes??6$   66   5V      .??5X      #   WpfLibrary.UIelements.Returns  6'   5Y      5Z      5[      5\      