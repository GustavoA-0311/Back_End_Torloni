

using ClassesEObjetos;

Console.Clear();

// Garrafa g1 = new Garrafa();

// System.Console.WriteLine($"Olá usuário, digite seu nome.");
// g1.nome = Console.ReadLine();

// System.Console.WriteLine($"Olá {g1.nome}, iremos personalizar uma garrafa agora!");


// System.Console.WriteLine($"Qual a capacidade dessa garrafa?");
// g1.capacidade = double.Parse(Console.ReadLine());

// System.Console.WriteLine();
// System.Console.WriteLine("Qual o tipo dessa garrafa?");
// g1.tipo = Console.ReadLine();

// System.Console.WriteLine();
// System.Console.WriteLine("Qual a cor dessa garrafa?");
// g1.cor = Console.ReadLine();

// System.Console.WriteLine();
// System.Console.WriteLine($"---------- Usuário ----------");
// System.Console.WriteLine(g1.nome);
// System.Console.WriteLine($"");
// System.Console.WriteLine("---------- Garrafa ----------");
// System.Console.WriteLine($"Capacidade: {g1.capacidade} L");
// System.Console.WriteLine($"Tipo: {g1.tipo}");
// System.Console.WriteLine($"Cor: {g1.cor}");
// System.Console.WriteLine();



ContaBancaria cb1 = new ContaBancaria();
System.Console.WriteLine("cadastre o titular da conta");
cb1.titular = Console.ReadLine();

System.Console.WriteLine("Diga o saldo do titular");
cb1.saldo = double.Parse(Console.ReadLine());

System.Console.WriteLine("Agora escolha uma das opções:");
System.Console.WriteLine("  1. Depositar");
System.Console.WriteLine("  2. Sacar");

int opcao = int.Parse(Console.ReadLine());

System.Console.WriteLine();

switch (opcao)
{
    case 1: cb1.Depositar();
        break;

    case 2: cb1.Sacar();
        break;

    default: System.Console.WriteLine("Opção Inválida!");
        break;
}

System.Console.WriteLine($"o saldo atualizado é: {cb1.saldo:F2}");


// Pessoa p1 = new Pessoa();

// p1.Nome = "João Silva";
// System.Console.WriteLine($"{p1.Nome} tem {p1.Idade} anos");

// int novaIdade = p1.Envelhecer(17);
// System.Console.WriteLine($"{p1.Nome} tem {novaIdade} anos");

// novaIdade = p1.Envelhecer(-50);
// System.Console.WriteLine($"{p1.Nome} tem {p1.I