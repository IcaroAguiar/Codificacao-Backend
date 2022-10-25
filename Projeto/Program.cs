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

            string opcao;
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

                switch(opcao){
                    case "1":
                        Console.WriteLine($"Pessoa Fisica");

                        Endereco EndIcaro;
                        PessoaFisica Icaro = new PessoaFisica("Icaro Aguiar", EndIcaro = new Endereco("Salvador", "Bahia", "XXXXXXX", "Loteamento Eng Maravilha", 00), "04/08/2003", "00000000000", 1100);
                        

                        Console.WriteLine(@$"
                                Nome: {Icaro.nome}, 
                                Rendimento: {Icaro.rendimentos} 
                                Cpf: {Icaro.cpf} 
                                Logradouro: {Icaro.endereco.rua}
                                Numero: {Icaro.endereco.numero}
                                ");

                        Thread.Sleep(5000);
                        break;
                    
                    
                    case "2":
                        Console.WriteLine($"Pessoa Juridica");
                        
                        Endereco EndOi;

                        PessoaJuridica Oi = new PessoaJuridica("Oi", EndOi = new Endereco("Salvador", "Bahia", "ACM", "XXXXXXXXXXXXX", 00), "Oi LTDA", "76.535.764/0001-43", 1000000);
                        
                        Console.WriteLine(@$"
                        Nome: {Oi.nome}
                        Razão Social: {Oi.razaoSocial}
                        CNPJ: {Oi.cnpj} - Valido: {Oi.ValidarCnpj(Oi.cnpj)}
                        ");
                        
                        Console.WriteLine($"Tecle Enter para sair");
                        Console.ReadLine();
                        break;
                    case "0":
                        Thread.Sleep(1000);
                        Utils.BarraCarregamento("Finalizando");        
                        break;

                    default:
                        Console.WriteLine($"Opção Inválida");
                        Thread.Sleep(5000);
                        break;
                }
            } while (opcao != "0");


            


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
            // System.Console.WriteLine(Oi.rendimentos);
           


        }


    }
}