
namespace Thebasics
{
    public class Aluno : pessoa
    {
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;
        public float NotaFinal;
        public string Curso;

    }
}