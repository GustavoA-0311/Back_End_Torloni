
using Exercicio02;
using Microsoft.VisualBasic;
List<IImprimivel> documentos = new List<IImprimivel>();
// Fatura fatEdu = new Fatura("Eduardo","Izabel Dark Lab", 50, 1);

// fatEdu.Imprimir();

int opcao;

do
{
    Console.WriteLine($"Menu de Opcoes");
    Console.WriteLine(@$"
1) Cadastrar Faturas
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatorios
6) Listar Contatos
0) Sair
Escolha a opcao:
");

    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();


    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatorio");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            break;
        case 5:
            Console.WriteLine($"Listar Relatorios");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opcao Invalida");
            break;

    }

} while (opcao != 0);



// Funcoes Auxiliares
void CadastrarFatura()
{
    Console.Write($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();

    Console.Write($"Digite o nome do credor: ");
    string cred = Console.ReadLine();

    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());

    Console.Write($"Quantos dias a fatura esta em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());


    // cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    // cadastra a futura na lista
    documentos.Add(f);
}



void CadastrarContrato()
{
    System.Console.WriteLine($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome da contratada: ");
    string contratada = Console.ReadLine();
    System.Console.WriteLine($"Digite as clausulas do relatorio: ");
    string txtClausulas = Console.ReadLine();
    Contrato c = new Contrato(contratante, contratada, txtClausulas);

    documentos.Add(c);
    System.Console.WriteLine($"Contrato cadastrado com sucesso.");
}

void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
            {
                item.Imprimir();
    }
    }
}


void ListasContratos()
{
    Console.WriteLine($"Listando as Contratos: ");
}

void ListarRelatorios()
{
    Console.WriteLine($"Listando os relatorios: ");

}

