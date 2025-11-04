using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome;

        public double Nota;

        public Aluno(string nm, double nt)
        {
            Nome = nm;
            Nota = nt;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"-------Aluno------
                                        Nome:{Nome}
                                        Nota:{Nota}
                                       ");
        }
    }
}
