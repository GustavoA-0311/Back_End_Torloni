using System;

public class Carro
{
    //--- Atributos privados ---
    private string marca;
    private string modelo;
    private int velocidadeAtual;

    //--- Métodos para Marca ---
    public void DefinirMarca(string valor)
    {
        marca = valor;
    }

    public string ObterMarca()
    {
        return marca;
    }

    //--- Métodos para Modelo ---
    public void DefinirModelo(string valor)
    {
        modelo = valor;
    }

    public string ObterModelo()
    {
        return modelo;
    }

    //--- Método para obter velocidade ---
    public int ObterVelocidade()
    {
        return velocidadeAtual;
    }

    //--- Métodos para alterar velocidade ---
    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual += valor;
            Console.WriteLine($"O carro acelerou +{valor} km");
        }
    }

    public void Frear(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual -= valor;
            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
            Console.WriteLine($"O carro freou -{valor} km");
        }
    }
}
