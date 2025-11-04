

namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public string titular = "";
        public double saldo;

        public void Depositar()
        {
            System.Console.WriteLine("Valor de Depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());

            saldo += valorDeposito;
            Console.WriteLine($"Depósito de R${valorDeposito:F2} realizado");
        }
        public void Sacar()
        {
            System.Console.Write("Valor de Saque:");
            double valorSaldo = double.Parse(Console.ReadLine());

            saldo -= valorSaldo;
            System.Console.WriteLine($"Saque de R${valorSaldo:F2} realizado.");
        }
    }
}