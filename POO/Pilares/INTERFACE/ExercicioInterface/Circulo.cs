namespace ExercicioInterface;

public class Circulo : IForma
{
    // Propriedade do Círculo
    public double Raio { get; set; }

    // Construtor da classe Circulo
    // Recebe o raio como parâmetro
    public Circulo(double raio)
    {
        Raio = raio;
    }

    // Implementação do método da interface IForma
    // Fórmula: área = PI * raio * raio
    // Usando Math.PI (constante de PI da classe Math)
    public double CalcularArea()
    {
        double area = Math.PI * Raio * Raio;
        return area;
    }
}