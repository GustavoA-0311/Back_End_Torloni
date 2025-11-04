namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;


        public Carro(string ma, string mo, int a)
        {
            Marca = ma;
            Modelo = mo;
            Ano = a;
        }

        

        public void ExibirDados()
        {
            System.Console.WriteLine(@$"-------Carro------
                                        Marca:{Marca}
                                        Modelo:{Modelo}
                                        Ano:{Ano}");
        }
    }
}