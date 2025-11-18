using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Thebasics
{
    public class Professor : pessoa
    {
        public float Salario;

        public Professor(Endereco endereco) : base(endereco)
        {
            
        }

    }
}