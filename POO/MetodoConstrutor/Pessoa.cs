
namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;


        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }
    }
}