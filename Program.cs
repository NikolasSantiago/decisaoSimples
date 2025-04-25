using System.Collections.ObjectModel;

string senhaDigitada;
string senhaEsperada = "110209";

Console.Clear();

Console.WriteLine("digite sua senha");
senhaDigitada = Console.ReadLine()!;

if(senhaDigitada == senhaEsperada)
{ Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("olá usuário login com sucesso");
}
else

{  Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("senha incorreta"); }

Console.ResetColor();