 int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE OPÇÕES ===");
            Console.WriteLine("1 - Calcular orçamento");
            Console.WriteLine("2 - resultado do jogo");
            Console.WriteLine("3 - Outra função");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Informe o salário recebido: ");
                    double salario = double.Parse(Console.ReadLine());
                    Console.Write("Informe o total gasto: ");
                    double gasto = double.Parse(Console.ReadLine());

                    if (gasto <= salario)
                        Console.WriteLine("Gastos dentro do orçamento!");
                    else
                        Console.WriteLine("Orçamento estourado!");
                    break;

                case 2:
                    Console.Write("Gols do time 1");
                    int golsA = int.Parse(Console.ReadLine());
                    Console.Write("Gols do time 2: ");
                    int golsB = int.Parse(Console.ReadLine());

                    if (golsA > golsB)
                        Console.WriteLine("Time 1 venceu!");
                    else if (golsB > golsA)
                        Console.WriteLine("Time 2 venceu!");
                    else
                        Console.WriteLine("Empate");
                    break;

                case 3:
                    Console.WriteLine("Executando outra função");
                    break;

                case 0:
                    Console.WriteLine("Saindo do programa");
                    break;

                default:
                    Console.WriteLine("Opção inválida Tente novamente");
                    break;
            }

            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadKey();

        } while (opcao != 0);
