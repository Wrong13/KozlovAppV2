   M S B A M L   `   `   `  ????F  BKozlovAppV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KozlovAppV2.ViewsKozlovAppV2.Views  5   	   =#clr-namespace:KozlovAppV2.ViewModelKozlovAppV2.ViewModel  5	   R   #    KozlovAppV2.Views.ProductList   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:KozlovAppV2.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   3	viewmodel#clr-namespace:KozlovAppV2.ViewModel  6R     ? Title$  ProductList??5   	   $	??800??6   $	??400??6*   $	??800??67   $	??400??6F      MaterialDesignBody#???   5
   	   $??Regular"?5   
   $??13(?5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   
      TextRenderingMode$
 Auto=?5   
     MaterialDesignPaper#???  5   
     MaterialDesignFont#???  5   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??0.2* ?6   ?? 5      ?? 5      $
??0.2* ?6    ? RowDefinitions 5   
   ?? 5      $
??0.3* ?6   ?? 5      ?? 5      $
??0.2* ?6   .+?5   
   ?? $??2??6   $??Center=?6%   .+?5      ?? -   5         ??Name$ FioBox??5   &   $??16(?6   $??Center=?66   $??WrapWithOverflow=?6S   5      ?? 5!   
   $??1??6   $??1??6$   .??5#      ?? $??1??6   $??1??6#   ??63   ?? *
Products+??5$      ?? 5%      .R?5&      ? .+?5'      ?? ._?5(   "   ?  5)   &   ?? 5*   *   $
??0.4* ?6;   ?? 5+   *   ?? 5,   *   $
??0.4* ?6;   .+?5.   &   ?? $??5 5 5 5q?61   .+?5/   *   ?? $<??6Сюда с фото разобраться позже??64   $??WrapWithOverflow=?6Y   50   '   ?? 51   &   $??1??61   $??5 5 5 5q?6A   .+?52   *   ??  ?? Orientation$ 
Horizontal=?65   .+?53   .   ?? $ ??Наименование: ??68   $??Black"?6N   ?? 54   .   ??68   ?? *ProductName+55   +   ? 56   *   .+?57   .   ?? $??WrapWithOverflow=?6\   ??68   ?? *ProductDescription+6\   58   +   ?? 59   *   $ 
Horizontal=?65   .+?5:   .   ?? $??Black"?68   $"??Производитель: ??6K   ?? 5;   .   ??68   ?? *ProductManufacturer+5<   +   ?? 5=   *   $ 
Horizontal=?65   .+?5>   .   ?? $??Black"?68   $??
Цена: ??6K   ?? 5?   .   ??68   ?? *ProductCost+?? 5@   .   $	??₽??68   5A   +   5B   '   ?? 5C   &   $??2??6-   ._?5D   *   ?? $??Center=?65   $ 
Horizontal=?6P   $??Right=?6i   .+?5E   .   ?? $??Кол-во: ??68   $??Black"?6H   $??18(?6[   ?? 5F   .   $??18(?6`   ??68   ?? *ProductQuantityInStock+6`   5G   +   5H   '   5I   #   5J      5K      5L      5N      5O      ? 5Q   
   $??1??6    5R      ?? 5S      ?? 5T      $
??0.4* ?6#   .+?5V      ?? $??1??6   $??Center=?6)   .+?5W      ?? )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Сортировка??5X       & "MaterialDesignFloatingHintComboBox#??[ 5Y       ?? SelectedValue 5W      ?? *SelectedSortByAscDesc+.@?5Z      ?? .??6#   Все5\      ?? 5]      .??6#   По возрастанию5_      ?? 5`      .??6#   По убыванию5b      ?? 5c      .??6#   По стоимости5e      5f      ?? 5g      $  Производители??5h      #??[ 5i       5g      ?? *SelectedManufacture+??5i   S   ?? *ProductManufacture+5k      5l      ?? 5n      $??Center=?6   .+?5o      ?? ??6   ?? *
FindUnit+	 ?? UpdateSourceTrigger$	 PropertyChanged=?5p      5q      5r      5s      