using MetodoConstrutor;

Pessoa fontes = new Pessoa("Joao", 17);

// fontes.Nome = "Lorenzo";
// fontes.Idade = 17;*/
/*
System.Console.WriteLine(@$"O objeto pessoa que criei e o {fontes.Nome} com a idade {fontes.Idade}");
fontes.Nome = "Gustavo Oliveira";
fontes.Nome = "Henrique";*/
// fontes.ExibirDados();
/*System.Console.WriteLine($"{fontes.Nome}");*/

//primeiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();


System.Console.WriteLine(@$"Primeira pessoa cadastrada:
                             Nome: {PrimeiraPessoa.Nome}
                             Idade: {PrimeiraPessoa.Idade}

                             ");
//segundo
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");

System.Console.WriteLine(@$"Segunda pessoa cadastrada:
                             Nome: {SegundaPessoa.Nome}
                             Idade: {SegundaPessoa.Idade}

                             ");
//terceiro
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);

System.Console.WriteLine(@$"Voce foi selecionado como a terceira pessoa!");
System.Console.WriteLine($"Digite o seu nome:");  
 TerceiraPessoa.Nome = Console.ReadLine();                         
   System.Console.WriteLine($"Digite a sua idade:");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Terceira pessoa cadastrada
                            Nome:{TerceiraPessoa.Nome}
                            Idade:{TerceiraPessoa.Idade}
");
