   M S B A M L   `   `   `  ????L  HFarmaciaNetCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FarmaciaNetCSharpFarmaciaNetCSharp  5   	       FarmaciaNetCSharp.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FarmaciaNetCSharp     5   	   -   5          ?Name$  Pedido??5   	    ? Title$ Resumen del pedido??5	   	   $	??300??6$   $	??600??61   .??5
      ? $??10q?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ pedidoResumenTexto??5      $??0??6,   $??0??69   $??2??6I   $?? ??6]   $??Center=?6h   $??Center=?6?   ?? 5   
   -   5        $ pedidoResumenDireccion??5      $??1??60   $??0??6=   $??2??6M   $?? ??6a   $??Center=?6l   $??Center=?6?   ?? 5   
   -   5         ??Name$ pedidoEnviar??5      $??2??6'   $??0??64   $??Center=?6D   $??Center=?6a   $??5q?6|   ???	#FF05521F???	#FFFDFDFD$??5q?6?   .??6?   Enviar6?   ?? 5   
   -   5        $ pedidoCancelar??5      $??2??6)   $??1??66   $??Center=?6F   $??Center=?6c   $??5q?6~   ???	#FFAF1414???	#FFF9F9F9$??5q?6?   .??6?   
Cancelar6?   5      5      