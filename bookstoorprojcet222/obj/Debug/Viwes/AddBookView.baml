   M S B A M L   `   `   `  ????N  Jbookstoorprojcet222, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:bookstoorprojcet222.Viwesbookstoorprojcet222.Viwes  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      +    %bookstoorprojcet222.Viwes.AddBookView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:bookstoorprojcet222.Viwes     5      9System&clr-namespace:System;assembly=mscorlib     5        ? DataContext  5
      ??    Locator ?? Source# [   ?? Path$ AddBook?.??5      ? 
????İ?.+?5   
   ?? .+?5      ?? $??
Enter name??6   ?? 5      $
??Left=?6,   $	??120??6G   ??6   ?? *Name+6G   ?? 5      $??Enter publisher??6   ?? 5      $
??Left=?63   $	??120??6N   ??6   ?? *AuthorNames+6N   ?? 5      $??Enter price??6   ?? 5      $
??Left=?6=   $	??120??6X   ??6   ?? *price+ ?? StringFormat$ c??6X   ?? 5      $??Enter summery??6   ?? 5      $
??Left=?6/   $	??120??6J   ??6   ?? *	Summery+6J   ?? 5      $??Enter number of copies??6   ?? 5      $
??Left=?66   $	??120??6Q   ??6   ?? *AmountOfCopies+6Q   ?? 5      $??Enter category??6   ?? 5      $
??Left=?6[   $	??120??6v   ??6   ?? *	ItemTypes+ ?? SelectedItem 69   ?? *
ItemType+6v   ?? 5      $??Amount On Stok??6   ?? 5      $
??Left=?61   $	??120??6L   ??6   ?? *	EddAmount+6L   ?? 5      $??Enter publish date??6   (  "System.Windows.Controls.DatePicker  5      $
??Left=?6<   $	??120??6W      SelectedDate 6   ?? *	PrintDate+6W   ?? 5      $??Add book??6   $
??Left=?6K   ??6(   ?? *AddBookCommand+6K   5      5      5       