namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public int Estoque;

        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"
                                       ----Produto----
                                       Nome:{Nome}
                                       Preco:{Preco}
                                       Estoque:{Estoque}");
        }
    }
}
