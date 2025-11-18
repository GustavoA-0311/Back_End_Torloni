using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class Retangulo : IForma
  
    {
        // Propriedades do Retângulo
        public double Largura { get; set; }
        public double Altura  { get; set; }

        // Construtor da classe Retangulo
        // Recebe a largura e a altura como parâmetros
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        // Implementação do método da interface IForma
        // Fórmula: área = largura * altura
        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }
    }
    
}