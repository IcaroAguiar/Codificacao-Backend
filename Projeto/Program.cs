using Classes;


namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco EndIcaro;
            PessoaFisica Icaro = new PessoaFisica("Icaro Aguiar", EndIcaro = new Endereco("Salvador", "Bahia", "XXXXXXX", "Loteamento Eng Maravilha", 00), "04/08/2003", "00000000000", 1100);
            System.Console.WriteLine(Icaro.nome);
            System.Console.WriteLine($"{EndIcaro.estado}, {EndIcaro.cidade} ,{EndIcaro.bairro}" );
            System.Console.WriteLine(Icaro.cpf);
            System.Console.WriteLine(Icaro.dataNasc);
            System.Console.WriteLine(Icaro.ValidarData(Icaro.dataNasc!));
            System.Console.WriteLine(Icaro.rendimentos);


            System.Console.WriteLine("-------------------------------------------------");

            Endereco EndOi;
            PessoaJuridica Oi = new PessoaJuridica("Oi", EndOi = new Endereco("Salvador", "Bahia", "ACM", "XXXXXXXXXXXXX", 00), "Oi LTDA", "76.535.764/0001-43", 1000000);
            System.Console.WriteLine(Oi.nome);
            System.Console.WriteLine($"{EndOi.estado}, {EndOi.cidade} ,{EndOi.bairro}" );
            System.Console.WriteLine(Oi.razaoSocial);
            System.Console.WriteLine(Oi.cnpj);
            System.Console.WriteLine( Oi.ValidarCnpj(Oi.cnpj!));
            System.Console.WriteLine(Oi.rendimentos);
           


        }


    }
}