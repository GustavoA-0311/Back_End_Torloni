
  
        double nota1, nota2, nota3, nota4, media;
        Console.WriteLine("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quarta nota: ");
        nota4 = double.Parse(Console.ReadLine());

        // Cálculo da média
        media = (nota1 + nota2 + nota3 + nota4) / 4;

        // Exibição da média
        Console.WriteLine("Média" + media );

        // Verificação da situação do aluno
        if (media >= 7.0)
        {
            Console.WriteLine("Situação: APROVADO");
        }
        else if (media >= 5.0)
        {
            Console.WriteLine("Situação: RECUPERAÇÃO");
        }
        else
        {
            Console.WriteLine("Situação: REPROVADO");
        }
