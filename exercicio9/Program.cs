
  int opcao;
        do
        {
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("1 - Opção 1");
            Console.WriteLine("2 - Opção 2");
            Console.WriteLine("3 - Opção 3");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine()); // vai lançar exceção se digitar algo inválido

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu a Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a Opção 2");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a Opção 3");
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa... Obrigado pela preferência");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    break;
            }
        } while (opcao != 0);
    
