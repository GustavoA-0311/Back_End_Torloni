double salario = 0, gasto = 0;


Console.Clear();
Console.WriteLine("Informe o salário");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o custo");
gasto = double.Parse(Console.ReadLine());

if(salario > gasto)
{
    Console.WriteLine("custos dentro do orçamento");
} else
{
    Console.WriteLine("Orçamento estourado");
}