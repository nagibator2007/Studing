   M S B A M L   `   `   `  ????G  CPanelProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PanelProject.View.PagesPanelProject.View.Pages  5      (    "PanelProject.View.Pages.ButtonPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:PanelProject.View.Pages     5        N? Title$  Элемент Button??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??30 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??XAML-разметка??6   $??Center=?6)   $
??Wrap=?6D    ?? TextAlignment$ Center=?6X   $??0??6o   $??0??6|   ?? 5   
   $-??'Программное создание??6   $??Center=?61   $
??Wrap=?6L   $ Center=?6`   $??0??6w   $??1??6?   ?? 5   
   $??Вывод из БД??6   $??Center=?6(   $
??Wrap=?6C   $ Center=?6W   $??0??6n   $??2??6{   ?? 5   
   $??2q?6   
???????$??1??6=   $??0??6J   ._?5      ?? -   5         ??Name$ XamlStackPanel??5      .+?5      ?? $??Center=?6   $??Center=?67   *(Кнопка с изображением6k   ?? 5      .??5       ??  ?? Orientation$ 
Horizontal=?6!   .+?5"      ?? $??/Assets/Images/folder.png??6    $??20??6C   ?? 5$      Изменить6.   5&       ? ToolTip 5(      ?? 5*      .+?5,      ?? $
??Bold"?6(   $??14(?6:   $??0,0,0,5q?6H   Открытие файла6i   ?? 5.      Выберите файл?? 52      ?=Откройте файл для редактирования56      ?? 58      
???????$??0,1,0,0q?6:   $	??0,8q?6T   ? 5:      .+?5<   "   ?? $ ??/Assets/Images/unnamed.png??6(   $??20??6L   ?? 5>   "   $??Italic$?6,   <:Нажмите F1 для получения справки6b   5@      5B      5G      5H      5I      ?? 5J   
   $??2q?6   
???????$??1??6=   $??1??6J   ._?5K   
   ?? -   5        $ ProgrammStackPanel??5K      5L      ?? 5M   
   $??2q?6   
???????$??1??6=   $??2??6J   ._?5N   
   ?? -   5        $ DataBaseXamlStackPanel??5N      5O      5P      5Q      