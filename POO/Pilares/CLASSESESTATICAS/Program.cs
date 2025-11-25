// See https://aka.ms/new-console-template for more information
using CLASSESESTATICAS;

Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();

System.Console.Write($"Digite o primeiro numero: ");
float a = float.Parse(Console.ReadLine());
System.Console.Write($"Digite o segundo numero: ");
float b = float.Parse(Console.ReadLine());


System.Console.WriteLine($"Qual o maior número entre {a} e {b}?");

if (a == b)
{
    System.Console.WriteLine($"Os dois são iguais");
}
else

{
    System.Console.WriteLine($"Maior: {Math.Max(a, b)}");
    System.Console.WriteLine($"Menor: {Math.Min(a, b)}");
}

// float r = CalculosMatematicos.Somar(a, b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// Console.WriteLine($"Subtração: {r}");
//  r = CalculosMatematicos.multiplicar(a, b);
// Console.WriteLine($"Multiplicacao: {r}");
//  r = CalculosMatematicos.Dividir(a, b);
// Console.WriteLine($"divisao: {r}");
