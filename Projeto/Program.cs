using Classes;
using System;
using System.IO;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica Icaro = new PessoaFisica();
            Icaro.nome = "Icaro Aguiar";
            Icaro.endereco = "Loteamento Engenho da Maravilha, 16, Vilarejo";
            Icaro.cpf = "00000000000";
            Icaro.dataNasc = "04/08/2003";

            PessoaJuridica Oi = new PessoaJuridica();
            Oi.nome = "Oi";
            Oi.endereco = "Av.Antonio Carlos Magalhaes, XXX, Itaigara";
            Oi.razaoSocial = "OI LTDA";
            Oi.cnpj = "XXXXXXXXXXXXXXXXX";


            string caminhoArquivo = @"C:\\Users\\ic_ag\\teste\\";

            Console.WriteLine("Escolha a opção para gravação do arquivo: 1- Pessoa Física ou 2- Pessoa Juridica");
            string? opcao = Console.ReadLine();
            if (opcao == "1"){
                Console.WriteLine("Digite o seu nome");

                var nome = Console.ReadLine();

                PessoaFisica novapf = new PessoaFisica();
                novapf.nome = nome;



                FileStream arquivo = File.Create(caminhoArquivo +novapf.nome);
                
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Digite o seu nome");

                var nome = Console.ReadLine();

                PessoaJuridica novapj = new PessoaJuridica();
                novapj.nome = nome;


                FileStream arquivo = File.Create(caminhoArquivo +novapj.nome);

            }






        }


    }
}