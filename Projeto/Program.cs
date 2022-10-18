using Classes;


namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PessoaFisica Icaro = new PessoaFisica("Icaro Aguiar", "Cruz das almas, Bahia", "04/08/2003", "00000000000", 1100);
            System.Console.WriteLine(Icaro.nome);
            System.Console.WriteLine(Icaro.endereco);
            System.Console.WriteLine(Icaro.cpf);
            System.Console.WriteLine(Icaro.dataNasc);
            System.Console.WriteLine(Icaro.ValidarData(Icaro.dataNasc!));
            System.Console.WriteLine(Icaro.rendimentos);


            System.Console.WriteLine("-------------------------------------------------");

            PessoaJuridica Oi = new PessoaJuridica("Oi", "Salvador, Bahia", "Oi LTDA", "76.535.764/0001-43", 1000000);
            System.Console.WriteLine(Oi.nome);
            System.Console.WriteLine(Oi.endereco);
            System.Console.WriteLine(Oi.razaoSocial);
            System.Console.WriteLine(Oi.cnpj);
            System.Console.WriteLine( Oi.ValidarCnpj(Oi.cnpj!));
            System.Console.WriteLine(Oi.rendimentos);
           


        }


    }
}