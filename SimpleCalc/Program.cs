/*
    Pedir o nome de usuario, dois numeros e mostrar a soma dos numeros no final
*/
string nome;
int numero1;
int numero2;

/* Pedir o nome pro usuario */
Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();


Console.WriteLine(nome);

Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());


int soma = numero1 + numero2;


Console.WriteLine(nome);
Console.WriteLine(soma);