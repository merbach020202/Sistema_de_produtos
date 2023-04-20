// MOSTRAR 3 OPÇÕES:     
// 1- CADASTRAR UM PRODUTO
// 2- LISTAR OS PRODUTOS CADASTRADOS
// 0- SAIR
// PARA CADA OPÇÃO, MOSTRAR O MENU APÓS REALIZÁ-LA

// PARA CADA PRODUTO DIGITADO, A PESSOA TERA QUE DIGITAR O PRECO POR UNIDADE
// DEPOIS O CLIENTE COLOCARÁ QUANTAS UNIDADES DAQUELE PRODUTO FORAM COMPRADAS

// DEVE APARECER A OPCAO DE CADASTRAR UM PRODUTO (APARECENDO AS PERGUNTAS DO PRECO E DA UNIDADE ADQUIRIDA), AO FINAL DE CADA PERGUNTA, APARECERA A OPCAO DE CADASTRAR UM NOVO PRODUTO OU NAO, SE SIM, CADASTRAR UM NOVO, SE NAO, RETORNAR AO MENU
// A 2 OPCAO VAI MOSTRAR TODOS OS PRODUTOS LISTADOS
// A 3 OPCAO VAI ENCERRAR O PROGRAMA





string[] nomeProduto = new string[3];
int[] quantidadeProduto = new int[3];
float[] precoProduto = new float[3];

string senhaValidacao = "123";
string opcao;

Console.WriteLine(@$"
                                    ------------------------------------------------------
                                    |                                                    | 
                                    |                                                    | 
                                    |                                                    | 
                                    |              Bem vindo ao Market Place!            | 
                                    |       (Digite a senha para entrar no site:123)     | 
                                    |                                                    | 
                                    |                                                    |
                                    ------------------------------------------------------                
");

string senhaDigitada = Console.ReadLine();

do
{
    Console.WriteLine($"Senha invalida, Digite novamente: ");
    senhaDigitada = Console.ReadLine();

} while (senhaDigitada != senhaValidacao);




do
{
    Console.WriteLine(@$"
                                    ------------------------------------------------------
                                    |           O que voçê gostaria de fazer?            | 
                                    |   (Digite o número referente a opção desejada)     | 
                                    |                                                    | 
                                    |   1- Cadastrar um produto                          | 
                                    |   2- Listar os produtos                            | 
                                    |   0- Sair                                          | 
                                    |                                                    |
                                    ------------------------------------------------------                
");

    opcao = Console.ReadLine();



    switch (opcao)
    {

        case "1":

            string resposta;

            do
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine($"Digite o nome do produto: ");
                    nomeProduto[i] = Console.ReadLine();

                    Console.WriteLine($"Digite a quantidade a ser adquirida do produto: ");
                    quantidadeProduto[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o preço do produto: ");
                    precoProduto[i] = float.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Gostaria de cadastrar um novo produto? (s/n)");
                resposta = Console.ReadLine().ToLower();

            } while (resposta == "s");
            break;

        case "2":
            for (int i = 0; i < 1; i++)
            {
            Console.WriteLine(@$"
            Nome do produto: {nomeProduto[i]}
            Quantidade individual do produto: {quantidadeProduto[i]}
            Preço total a ser pago: {precoProduto[i] * quantidadeProduto[i]}
            ");
            }
            break;

        case "0":
            Console.WriteLine($"Programa encerrado!");
            break;

        default:
        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opcao invalida");
            Console.ResetColor();
            break;
    }
} while (opcao != "2" && opcao != "0");























