   M S B A M L   `   `   `  ????G  CPanelProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PanelProjectPanelProject  5   	       PanelProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PanelProject     5   	     ? Title$+  %Элементы управления??5   	   $	??550??6%   $	??800??62   $	??300??5	   	   $	??300??6   $
??1400??6)   $
??1000??6:    ? WindowStartupLocation$ CenterScreen=?5
   	    ? Icon$ /Assets/Images/logo.png??5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      $	??300 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??2??6   $??0??6"   $??10q?62   .+?5      ?? -   5         ??Name$ 
InfoButton??5      $??Button??5      $??20(?6&   $
??0,10q?64   5   )   ?? 5      -   5        $ RadioInfoButton??5      $??RadioButton??5      $??20(?6+   $	??0,5q?69   5   .   ?? 5      -   5        $ CheckBoxButton??5      $??CheckBox??5      $??20(?6(   $	??0,5q?66   5   -   ?? 5      -   5        $ TextBlockButton??5      $??	TextBlock??5      $??20(?6)   $	??0,5q?67   5   .   ?? 5      -   5        $ TextBoxAndPasswordButton??5       $??TextBox и PasswordBox??5      $??20(?65   $	??0,5q?6C   5    7   ?? 5!      -   5        $ ComboBoxButton??5"      $??ComboBox??5!      $??20(?6(   $	??0,5q?66   5"   -   ?? 5#      -   5        $ ListBoxButton??5$      $??ListBox??5#      $??20(?6'   $	??0,5q?65   5$   ,   ?? 5%      -   5        $ SliderButton??5&      $??Slider??5%      $??20(?6&   $	??0,5q?64   5&   +   ?? 5'      -	   5        $! CalendarAndDatePickerButton??5(      $??Calendar и DatePicker??5'      $??20(?65   $	??0,5q?6C   5(   :   ?? 5)      -
   5        $ ImageButton??5*      $??Image??5)      $??20(?6%   $	??0,5q?63   5*   *   5+      ?? 5-   
   -   5         ??Name$ TitleTextBlock??5.      $??0??5-      $??0??6!   $??2??61   $
??0,10q?6E   $??20(?5.   ,   $??Center=?50      $??Center=?6/   ??5/      ??  ?? ElementName$ 	MainFrame?? ?? Path$ Content.Title?50   /   ?? 51   
   -   5        $ 
ExitButton??53      $??0??51      $??0??6   $??2??6.   $
??0,10q?6B   $?? Выход??52      $??Right=?6"   53   %    ? 55   
   -   5        	  ?Name$	 	MainFrame??55   -   $??1??6   $??1??6   
  ? NavigationUIVisibility$
 Hidden=?56      
??????57      58      5:      