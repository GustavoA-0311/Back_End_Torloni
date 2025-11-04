using System;

namespace ClassesEObjetos
{
    public class Garrafa
    {
        // Propriedades da garrafa
        public string marca;
        public string material;
        public int capacidade;// em litros

        // Método para encher a garrafa
        public void encher()
        {
            Console.WriteLine(" A garrafa esta cheia");
        }

        // Método para beber da garrafa
        public void Beber()
        {
            Console.WriteLine("Você tomou agua da garrafa");
        }

        // Método opcional (só pra deixar mais completo)
        public void MostrarInformacoes()
        {
            Console.WriteLine("\n--- Detalhes da Garrafa ---");
            Console.WriteLine($"Cor: {marca}");
            Console.WriteLine($"Material: {material}");
            Console.WriteLine($"Capacidade: {capacidade}");
        }
    }
}
