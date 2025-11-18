

namespace Thebasics
{
    public class pessoa
    {
        public string Nome;
        public int Idade;

        public Endereco EnderecoCompleto;


        public pessoa( Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }


        public void falar()
        {
            Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }

    }
}