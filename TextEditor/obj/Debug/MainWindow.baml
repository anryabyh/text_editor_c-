   M S B A M L   `   `   `  ????E  ATextEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TextEditor
TextEditor  5   	       TextEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TextEditor     5   	   -   5          ?Name$  winMain??5   )    ? Title$8 2Простой текстовый редактор??5   	   $	??450??6,   $	??800??69    ? WindowStartupLocation$ CenterScreen=?6E   .??5
      ]? .+?5   
   ?? $	??Top=?6   .+?5      o? $	??Top=?6   .@?5      m? -   5        $
??File??5      $??23??6)   $??30??65   $??Center=?6@   $??Center=?6]   .@?5      m? -   5         m?Name$ FileOpen??5      $
??Open??61   6?   m? 5      -   5        $ 	MenuClose??5      $
??_New??62   6@   m? 5      -   5        $ FileSave??5      $
??Save??61   6?   5      m? 5      $??Sample??6   $??23??6+   $??50??67   $??Center=?6B   $??Center=?6_   .@?5      m? -   5        $ Create??5      $??Create??6/   m? 5      -   5        $ Reload??5      $??Reload??6/   5      m? 5      $??About??6   $??30??6*   $??40??66   $??Center=?6A   $??Center=?6^   .@?5      m? -   5        $ 	AboutProg??5      $??About programs??62   m? 5      -	   5        $ AboutAut??5      $??About autors??61   5      5      ? 5      .+?5!      d? -
   5        $??btnBold??5!      .??5"      ?? $3??-Icons/bold_format_editor_tool_icon_146015.png??6   $??20??6S   $??20??6^   5#      d? 5%      -   5        $??	btnItalic??5%      .??5&      ?? $A??;Icons/italic_em_emphasis_format_editor_tool_icon_145968.png??6   $??20??6a   $??20??6l   5'      d? 5)      -   5        $??btnUnderline??5)      .??5*      ?? $8??2Icons/underline_format_editor_tool_icon_145920.png??6   $??20??6X   $??20??6c   5+      5-      5/      ?? 51   
   
???????$??Bottom=?6+   $??5??6C   $??20??52      .@?53      ?? .??54      ?  ? RowDefinitions 55      ?? 56      6*   ?? 57      $
??auto ?6(   68   .+?59      ?? $??1??6    ??5:      ?? 5;      .R?5<   "   ?  ? ColumnDefinitions 5=   &   ?? 5>   *   $??* ?6;   6G   ?? 5?   *   $
??auto ?6;   6J   5A   #   5B      .@?5D      ?? -   5         ??Name$ cursorPosition??5D   $   Текст слева6I   ?? 5E      $??1??6(   .??5F      ?? Текст справа66   5G      5H      5I      5J      5K      ?? 5M   
   -   5         ??Name$ listBox??5M      
???"?"?$	??150??6<   $
??Left=?6K   6a   ?? 5O   
   -   5         ??Name$ txtMain??5O      
???????$
??Left=?66   	 ?? TextWrapping$
	 Wrap=?6L   "
 ?? VerticalScrollBarVisibility$
 Visible=?6`    ?? AcceptsReturn . 6?   5Q      5S      