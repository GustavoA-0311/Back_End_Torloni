//Faça um prgrama que recebe 3 numero inteiros e imprima na tela a somatoria total dos numeros


/*for (int i = 0, i--)

{
    Console.WriteLine($"Rodada com i valendo {i}");
}
*/



       int numero1, numero2, numero3, total;
        Console.WriteLine("Digite o primeiro numero: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        numero2= int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro numero: ");
        numero3 = int.Parse(Console.ReadLine());


        total = (numero1 + numero2 + numero3);

        Console.WriteLine("Total" + total);


