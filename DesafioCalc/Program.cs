using System.Runtime.InteropServices;

int n1, n2;

Console.WriteLine("Digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
n2 = int.Parse(Console.ReadLine());



if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero e o maior: {n1}");
    /* Console.WriteLine("O primeiro numero e o maior: " + n1); */

}
 if (n2 > n1)
{
     Console.WriteLine($"O segundo numero e o maior: {n2}");
}

else
{
    Console.WriteLine($"Os dois numeros são iguais!");
}
;

