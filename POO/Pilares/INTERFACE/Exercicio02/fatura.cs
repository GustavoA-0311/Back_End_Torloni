namespace Exercicio02
{
    public class Fatura : IImprimivel
    {

        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string dev, string cre, float val, int dda)
        {
            Devedor = dev;
            Credor = cre;
            Valor = val;
            DiasDeAtraso = dda;

        }

        public void Imprimir()
        {

            System.Console.WriteLine($@"
    Credor: {Credor}
    Devedor: {Devedor}
    Dias de Atraso: {DiasDeAtraso} dia(s)
    Valor: R$ {Valor:F2}
    Juros: R$ {(Valor * DiasDeAtraso):F2}
    Total com Juros: R$ {Valor:F2}
            ");

            System.Console.WriteLine($"Credor: {Credor}...");
            System.Console.WriteLine($"Devedor: {Credor}...");
            System.Console.WriteLine($"Dias de atraso: {Devedor}...");
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            } else if (DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Divida encaminhada para o SERASA");
            } else {}
        }
    }
}
