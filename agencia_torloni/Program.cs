string[] nomes = new string[3];
double[] saldos = new double[3];
int opcao = -1, totalClientes = 0;



do
{
    Console.Clear();
    Console.WriteLine($"--- SISTEMA BANCARIO SIMPLES ---");
    Console.WriteLine();
    Console.WriteLine($"1 - Cadastrar clientes");
    Console.WriteLine($"2 - Depositar");
    Console.WriteLine($"3 - Sacar");
    Console.WriteLine($"4 - Transferir");
    Console.WriteLine($"5 - Listar clientes");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine($"Digite a opcao:");

    opcao = int.Parse(Console.ReadLine());


    Console.Clear();

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando a sessao...");
            Console.WriteLine($"Pressione <Enter> para encerrar.");
            Console.Clear();
            break;
        case 1:
            CadastrarClientes();
            break;
        case 2:
            Depositar();
            Console.WriteLine();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;


    }
} while (opcao != 0);



void CadastrarClientes()
{
    if (totalClientes >= 3)
    {
        Console.WriteLine($"Limite de ocupacao atingido");
        Console.WriteLine($"Pressione <Enter> para encerrar.");
        return;
    }

    Console.WriteLine($"Nome do cliente:");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Pressione <Enter> para encerrar.");
    Console.ReadLine();
    Console.Clear();

}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Valor para deposito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Deposito de R$ {valorDeposito} realizado!");
    Console.WriteLine($"Funcao em andamento");

    Console.WriteLine($"Pressione <Enter> para encerrar.");
    Console.ReadLine();
}

void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    if (saldos[idCliente] >= valorSolicitado)
    {
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine($"Saldo insuficiente.");
    }
    
    Console.WriteLine($"Pressione <Enter> para encerrar.");
    Console.ReadLine();
}

int BuscarCliente()
{
    ListarClientes();
    Console.Write($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente nao encontrado");
        return -1;
    }
    return idCliente;
}

void Transferir()
{
    /* Console.WriteLine($"Funcao em andamento");

     Console.WriteLine($"Pressione <Enter> para encerrar.");
      Console.ReadLine();*/

    Console.WriteLine($" == Transferencia == ");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    int idClienteDestino = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }
    Console.Write($"Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine($"Transferencia concluida!");
    }
}

void ListarClientes()
{
    Console.WriteLine($"--CLIENTES--"); 

    for (int i = 0; i < totalClientes; i++ )
    {
        
        Console.WriteLine($"`{i} - {nomes[i]} | Saldo: R$ {saldos[i]}");

    }
    Console.WriteLine($"Pressione <Enter> para encerrar.");
    Console.ReadLine();
}
