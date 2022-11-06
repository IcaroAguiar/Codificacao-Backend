using Classes;


namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Clear();

            Console.WriteLine(@$"
            =============================================
            |    Bem vindo ao sistema de cadastro de    |
            |        Pessoas Físicas e Juridícas        |
            =============================================
            ");

            Utils.BarraCarregamento("Iniciando", 100, 40);

            List<PessoaFisica> listaPf = new List<PessoaFisica>();

            string? opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"



                ================================================
                |        Bem Vindo ao Sistema de Cadastro      |
                |            Pessoa Física & Jurídica          |
                ================================================
                |                                              |
                |             1 - Pessoa Física                |
                |                                              |
                |             2 - Pessoa Jurídica              |
                |                                              |
                |             0 - Sair                         |
                ================================================
                
                
                ");


                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":

                        string? opcaoPf;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                            =============================================
                            |        Escolha uma das opções abaixo      |
                            |-------------------------------------------|
                            |           1 - Cadastrar Pessoa Física     |
                            |           2 - Listar Pessoas Física       |
                            |                                           |
                            |           0 - Voltar ao menu anterior     |
                            =============================================
                            ");
                            opcaoPf = Console.ReadLine();
                            PessoaFisica metodosPf = new PessoaFisica();

                            switch (opcaoPf)
                            {
                                case "1":

                                    Console.Clear();
                                    PessoaFisica novaPf = new PessoaFisica();
                                    Endereco novoEndPf = new Endereco();

                                    Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                                    novaPf.nome = Console.ReadLine();

                                    using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                                    {
                                        sw.WriteLine(novaPf.nome);
                                    }



                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Cadastro gravado");
                                    Console.ResetColor();
                                    Thread.Sleep(2000);

                                    // bool dataValida;
                                    // do
                                    // {

                                    //     Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                                    //     string? dataNascimento = Console.ReadLine();

                                    //     dataValida = metodosPf.ValidarData(dataNascimento!);

                                    //     if (dataValida)
                                    //     {
                                    //         DateTime DataConvertida;
                                    //         DateTime.TryParse(dataNascimento, out DataConvertida);

                                    //         novaPf.dataNasc = DataConvertida;

                                    //     }
                                    //     else
                                    //     {
                                    //         Console.ForegroundColor = ConsoleColor.DarkRed;
                                    //         Console.WriteLine($"Data digitada invalida, por favor digite uma data valida");
                                    //         Console.ResetColor();
                                    //         Thread.Sleep(3000);
                                    //     }

                                    // } while (dataValida == false);
                                    // Console.WriteLine($"Digite o numero do CPF");
                                    // novaPf.cpf = Console.ReadLine();

                                    // Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NUMEROS)");
                                    // novaPf.rendimentos = float.Parse(Console.ReadLine());

                                    // Console.WriteLine($"Digite a rua");
                                    // novoEndPf.rua = Console.ReadLine();

                                    // Console.WriteLine($"Digite o numero");
                                    // novoEndPf.numero = int.Parse(Console.ReadLine());

                                    // Console.WriteLine($"Este endereço é comercial? S/N");
                                    // string endCom = Console.ReadLine().ToUpper();

                                    // if (endCom == "S")
                                    // {
                                    //     novoEndPf.endComercial = true;
                                    // }
                                    // else
                                    // {
                                    //     novoEndPf.endComercial = false;
                                    // }

                                    // novaPf.endereco = novoEndPf;

                                    // listaPf.Add(novaPf);

                                    // Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    // Console.WriteLine($"Cadastro realizado com sucesso");
                                    // Console.ResetColor();
                                    // Thread.Sleep(3000);

                                    break;

                                case "2":

                                    // Console.Clear();

                                    // if (listaPf.Count > 0)
                                    // {
                                    //     foreach (PessoaFisica cadaPessoa in listaPf)
                                    //     {
                                    //         Console.Clear();
                                    //         Console.WriteLine(@$"
                                    //         Nome: {cadaPessoa.nome}
                                    //         Endereço: {cadaPessoa.endereco.rua}, {cadaPessoa.endereco.numero}
                                    //         Imposto a ser pago: {metodosPf.pagarImposto(cadaPessoa.rendimentos).ToString("C")}
                                    //         ");

                                    //         Console.WriteLine("Aperte 'ENTER' para continuar");
                                    //         Console.ReadLine();

                                    //     }
                                    // }
                                    // else
                                    // {
                                    //     Console.WriteLine($"Lista vazia");
                                    //     Thread.Sleep(3000);
                                    // }

                                    


                                    using (StreamReader sr = new StreamReader("Icaro.txt"))
                                    {
                                        string linha;

                                        while ((linha = sr.ReadLine()) != null)
                                        {
                                            Console.WriteLine(linha);
                                        }
                                        Console.WriteLine($"Tecle Enter para continuar");
                                        Console.ReadLine();
                                    }

                                    break;




                                case "0":
                                    Console.Clear();
                                    System.Console.WriteLine("Voltando ao menu anterior");
                                    Thread.Sleep(3000);
                                    break;

                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                                    Console.ResetColor();
                                    Thread.Sleep(3000);
                                    break;
                            }

                        } while (opcaoPf != "0");
                        break;


                    case "2":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();
                        PessoaJuridica metodosPj = new PessoaJuridica();

                        novaPj.nome = "Oi";
                        novaPj.razaoSocial = "OI S.A";
                        novaPj.cnpj = "76.535.764/0001-43";
                        novaPj.rendimentos = 10000.5f;

                        novoEndPj.rua = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.endComercial = true;

                        novaPj.endereco = novoEndPj;

                        metodosPj.Inserir(novaPj);


                        // Console.Clear();

                        // Console.WriteLine(@$"
                        // Nome: {novaPj.nome}
                        // Razão Social: {novaPj.razaoSocial}
                        // CNPJ: {novaPj.cnpj}
                        // -Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
                        // ");


                        // Console.WriteLine($"Aperte ENTER para continuar");
                        // Console.ReadLine();

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                        Thread.Sleep(3000);

                        Utils.BarraCarregamento("Finalizando", 500, 6);

                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }




            } while (opcao != "0");


        }
    }
}
















// System.Console.WriteLine("-------------------------------------------------");
// System.Console.WriteLine(Icaro.nome);
// System.Console.WriteLine($"{EndIcaro.estado}, {EndIcaro.cidade} ,{EndIcaro.bairro}" );
// System.Console.WriteLine(Icaro.cpf);
// System.Console.WriteLine(Icaro.dataNasc);
// System.Console.WriteLine(Icaro.ValidarData(Icaro.dataNasc!));
// System.Console.WriteLine(Icaro.rendimentos);

// System.Console.WriteLine(Oi.nome);
// System.Console.WriteLine($"{EndOi.estado}, {EndOi.cidade} ,{EndOi.bairro}" );
// System.Console.WriteLine(Oi.razaoSocial);
// System.Console.WriteLine(Oi.cnpj);
// System.Console.WriteLine( Oi.ValidarCnpj(Oi.cnpj!));
//     Console.WriteLine($"Pessoa Fisica");

//     Endereco EndIcaro;
//     PessoaFisica Icaro = new PessoaFisica();


//     Console.WriteLine(@$"
//                     Nome: {Icaro.nome}, 
//                     Rendimento: {Icaro.rendimentos} 
//                     Cpf: {Icaro.cpf} 
//                     Logradouro: {Icaro.endereco.rua}
//                     Numero: {Icaro.endereco.numero}
//                     ");

//     Thread.Sleep(5000);
//     break;



//         case "2":
//             Console.WriteLine($"Pessoa Juridica");

//     Endereco EndOi;


// }
// } while (opcao != "0");
// System.Console.WriteLine(Oi.rendimentos);
