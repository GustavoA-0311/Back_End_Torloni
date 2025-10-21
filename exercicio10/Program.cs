
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("     EXERCÍCIOS (1 a 6)   ");
            Console.WriteLine("1 - Verificar orçamento (Salário e gastos)");
            Console.WriteLine("2 - Placar de futebol");
            Console.WriteLine("3 - Tipo de triângulo");
            Console.WriteLine("4 - Verificação de senha");
            Console.WriteLine("5 - Valor da compra de maçãs");
            Console.WriteLine("6 - Situação do aluno (média e frequência)");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("====================================");
            Console.Write("Escolha uma opção: ");
            
            // Evita erro caso o usuário digite algo inválido
              opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }

    // Exercício 1
 void Exercicio1()
    {
        Console.Write("Informe o salário recebido: R$ ");
        double salario = double.Parse(Console.ReadLine());
        Console.Write("Informe o total gasto: R$ ");
        double gastos = double.Parse(Console.ReadLine());

        if (gastos <= salario)
            Console.WriteLine("Gastos dentro do orçamento.");
        else
            Console.WriteLine("Orçamento estourado!");
    }

    // Exercício 2
 void Exercicio2()
 {
  int time1, time2;

        Console.Write("Gols do time 1: ");
        time1 = int.Parse(Console.ReadLine());

        Console.Write("Gols do time 2: ");
        time2 = int.Parse(Console.ReadLine());

        if (time1 > time2)
            Console.WriteLine("Time 1 venceu!");
        else if (time2 > time1)
            Console.WriteLine("Time 2 venceu!");
        else
            Console.WriteLine("Empate!");
}
    // Exercício 3

 void Exercicio3()
    {
        Console.Write("Lado 1: ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.Write("Lado 2: ");
        double lado2 = double.Parse(Console.ReadLine());
        Console.Write("Lado 3: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
            Console.WriteLine("Triângulo Equilátero.");
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            Console.WriteLine("Triângulo Isósceles.");
        else
            Console.WriteLine("Triângulo Escaleno.");
    }


    // Exercício 4
 
 void Exercicio4()
    {
        const int senhaCorreta = 1234;

        Console.Write("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());

        if (senha == senhaCorreta)
            Console.WriteLine("ACESSO PERMITIDO");
        else
            Console.WriteLine("ACESSO NEGADO");
    }


    // Exercício 5
  
 void Exercicio5()
    {
        Console.Write("Informe o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco = (quantidade < 12) ? 0.30 : 0.25;
        double total = quantidade * preco;

        Console.WriteLine($"Valor total da compra: R$ {total:F2}");
    }

    // Exercício 6
 void Exercicio6()
    {
        Console.Write("Informe a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Informe a frequência (%): ");
        double frequencia = double.Parse(Console.ReadLine());

        if (frequencia < 75)
        {
            Console.WriteLine("Aluno reprovado por frequência.");
        }
        else
        {
            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado!");
            else if (media >= 3.0)
                Console.WriteLine("Aluno em recuperação.");
            else
                Console.WriteLine("Aluno reprovado por nota.");
        }
    }

