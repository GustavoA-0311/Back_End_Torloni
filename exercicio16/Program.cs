using System.Data.Common;

string cargo;
double salario, salario2 = 0;

Console.WriteLine("escolha um dos cargos");
Console.WriteLine("producao");
Console.WriteLine("administrativo");
Console.WriteLine("diretoria");

cargo = Console.ReadLine();

Console.WriteLine("digite seu salario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salario2 = salario * 1.065;
}
else if (cargo == "administrativo")

{
    salario2 = salario * 1.075;
}
else if (cargo == "diretoria")
{
    salario2 = salario * 1.12;
}



Console.WriteLine($"seu novo salario é: {salario2}");
