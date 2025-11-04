


namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome;
        public int Idade;


        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public Pessoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa3Sobrecargas(string n, int i)
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