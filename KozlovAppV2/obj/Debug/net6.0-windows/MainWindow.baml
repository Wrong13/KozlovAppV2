   M S B A M L   `   `   `  ????F  BKozlovAppV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KozlovAppV2KozlovAppV2  5   	       KozlovAppV2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KozlovAppV2     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     ? Title$  
MainWindow??5   	   $	??350??6   $	??500??6)      MaterialDesignBody#???   5
   
   $??Regular"?5   
   $??13(?5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   
      TextRenderingMode$
 Auto=?5   
     MaterialDesignPaper#???  5   
     MaterialDesignFont#???  5   
    ? 
ResizeMode$ NoResize=?5   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??0.4* ?6   ?? 5      ?? 5      $
??0.4* ?6    ? RowDefinitions 5   
   ?? 5      $
??0.6* ?6   ?? 5      ?? 5      $
??0.6* ?6   .+?5       ? $??1??6   $??1??6#    5!      ?? 5"      ?? 5#      $
??0.4* ?6    .+?5%      ?? .+?5&      ?? -   5         ??Name$ LogBox??5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин??5(       % !MaterialDesignFloatingHintTextBox#??[ 5)      G? 5*      -   5         G?Name$ PassBox??5+      $! Введите пароль??5,       ) %MaterialDesignFloatingHintPasswordBox#??[ 5-      5.      ?? 5/      $??1??6   $??Bottom=?6&   .+?50      ?? -   5        	 ??Name$	 DangerBlock??50   *   $??16(?6   $??Center=?6?   51      52      ?? 55   
   $??1??6   $??2??6%   .+?56      ?? -   5        
 ??Name$
 AuthBtn??56   %   $??
Войти??6   66   57      58      59      