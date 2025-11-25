
using Encapsulamento;
// float dinheiro = 200;

// ContaBancaria contaedu = new ContaBancaria();
// ContaBancaria contamaria = new ContaBancaria(dinheiro);

// contaedu.Depositar(dinheiro);
// Console.WriteLine($"saldo da conta do Eduardo R$:{contaedu.GetSaldo()}");

// Console.WriteLine($"saldo da conta da Maria R$:{contamaria.GetSaldo()}");


// contaedu.Saque(100);
// Console.WriteLine($"Novo saldo da conta depois do saque do Edu R$:{contaedu.GetSaldo()}");

// Console.WriteLine($"Novo saldo da conta depois do saque da Maria R$:{contamaria.GetSaldo()}");


Carro fusca = new Carro();

fusca.DefinirMarca("VolksWagem");
fusca.DefinirModelo("fusca 89");

fusca.Acelerar(100);
fusca.Acelerar(50);

fusca.Frear(10);

System.Console.WriteLine($"Marca: {fusca.ObterMarca()}");
System.Console.WriteLine($"modelo: {fusca.ObterModelo()}");
System.Console.WriteLine($"Velocidade atual: {fusca.ObterVelocidade()}");