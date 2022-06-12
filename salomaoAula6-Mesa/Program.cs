// See https://aka.ms/new-console-template for more information




string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int anoDeNascimento;



Console.WriteLine("digite o seu nome:");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine("digite sua idade:");
idadeDoUsuario = int.Parse(Console.ReadLine());


Console.WriteLine("digite o ano atual:");
//anoAtual = int.Parse(Console.ReadLine());
anoAtual = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Ola {nomeDoUsuario}, voce nasceu em {anoAtual - idadeDoUsuario}.");

