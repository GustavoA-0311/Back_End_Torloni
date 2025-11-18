 class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // Cálculo da área do Retângulo
            // ================================
            Console.WriteLine("=== Cálculo da área do Retângulo ===");

            // Ler a largura
            Console.Write("Informe a largura do retângulo: ");
            // Console.ReadLine() lê uma string digitada pelo usuário
            // double.Parse converte essa string para double
            double largura = double.Parse(Console.ReadLine() ?? "0");

            // Ler a altura
            Console.Write("Informe a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine() ?? "0");

            // Criar um objeto do tipo Retangulo
            // Note que a variável é do tipo IForma (polimorfismo)
            IForma retangulo = new Retangulo(largura, altura);

            // Chamar o método CalcularArea() do retângulo
            double areaRetangulo = retangulo.CalcularArea();

            // Exibir o resultado com 2 casas decimais (F2)
            Console.WriteLine($"Área do retângulo: {areaRetangulo:F2}");
            Console.WriteLine(); // Linha em branco

            // ================================
            // Cálculo da área do Círculo
            // ================================
            Console.WriteLine("=== Cálculo da área do Círculo ===");

            // Ler o raio
            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine() ?? "0");

            // Criar um objeto do tipo Circulo
            // Também usando o tipo IForma (polimorfismo)
            IForma circulo = new Circulo(raio);

            // Chamar o método CalcularArea() do círculo
            double areaCirculo = circulo.CalcularArea();

            // Exibir o resultado com 2 casas decimais
            Console.WriteLine($"Área do círculo: {areaCirculo:F2}");
            Console.WriteLine();

            // Mensagem final
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}