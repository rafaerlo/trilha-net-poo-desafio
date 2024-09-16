using DesafioPOO.Models;

string aplicativo = "Editor de video";
Nokia nokia = new Nokia("81 999999999", "1100", "ABS456ERF12", 128);
nokia.InstalarAplicativo(aplicativo);

aplicativo = "Calculadora";
Iphone iphone = new Iphone("11 98887888", "7", "CMN558998IUO", 2048);
iphone.InstalarAplicativo(aplicativo);

Console.WriteLine("__________________________");
Console.WriteLine("Dados de aparelhos");
Console.WriteLine("__________________________");
Console.WriteLine(iphone.ToString());
Console.WriteLine("__________________________");
Console.WriteLine(nokia.ToString());