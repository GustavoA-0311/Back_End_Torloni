using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        public void falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }



        public int envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva");
                return Idade;
            }

            Idade += _anos;

            return Idade;
        }


    }
}