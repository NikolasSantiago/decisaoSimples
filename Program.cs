string senhaDigitada;
string senhaEsperada = "110209";
string idConta;
string idEsperado = "_.santizx";

Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("digite seu id___");
idConta = Console.ReadLine()!;

if(idConta == idEsperado)
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("digite sua senha___");
senhaDigitada = Console.ReadLine()!;
Console.ResetColor();

if(senhaDigitada == senhaEsperada)

{ Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("olá usuário, login com sucesso");
}
else

{  Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("senha incorreta"); }

Console.ResetColor();

