
namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";

        public string PrestadorServico = "";

        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($@"
            Partes:
            Contratantes: {Contratante}
            Contratada: {PrestadorServico}
            Clausulas do Contrato:

            {TextoClausulas}
            
            
            ");
        }
    }
}