using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            {
                if (saldoInicial >= 0)
                {
                    Saldo = saldoInicial;
                }


            }
        }

        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }

            else System.Console.WriteLine($"Valor para o deposito invalido");

        }

        public float GetSaldo()
        {
            return Saldo;
        }

                 public void Saque (float valor)
        {
            if (valor >= 0 && valor<= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"saque retornado com sucesso");
                return;
            }

            else System.Console.WriteLine($"Valor para o saque invalido");

        }


    }
}

