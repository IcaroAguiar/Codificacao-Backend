using System.Text.RegularExpressions;
namespace Classes
{
    public class PessoaJuridica : Pessoa
    {

        public PessoaJuridica(string? nome, string? endereco, string? razaoSocial, string? cnpj, int rendimentos) : base(nome, endereco, rendimentos)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.rendimentos = rendimentos;
        }
        public string? razaoSocial { get; set; }
        public string? cnpj { get; set; }

        public override bool pagarImposto(bool imposto)
        {
            if (rendimentos <= 3000)
            {
                System.Console.WriteLine("Imposto de 3%");
                rendimentos = rendimentos * (3 / 100);
                return imposto = true;
            }
            else if (rendimentos >= 3000 && rendimentos <= 6000)
            {
                System.Console.WriteLine("Imposto de 5%");
                rendimentos = rendimentos * (5 / 100);
                return imposto = true;
            }
            else if (rendimentos >= 6000 && rendimentos <= 10000)
            {
                System.Console.WriteLine("Imposto de 7%");
                rendimentos = rendimentos * (7 / 100);
                return imposto = true;
            }
            else if (rendimentos > 10000)
            {
                System.Console.WriteLine("Imposto de 9%");
                rendimentos = rendimentos * (9 / 100);
                return imposto = true;
            }
            else
            {
                return imposto = false;
            }



        }
        public bool ValidarCnpj(string cnpj)
        {

            bool validaCnpj = Regex.IsMatch(cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)");

            if (validaCnpj)
            {
                string cnpjSubstring = cnpj.Substring(8, 4) ;
                string cnpjSubstring2 = cnpj.Substring(11, 4) ;
                
                if (cnpjSubstring == "0001")
                {
                    return true;
                }

                else if(cnpjSubstring2 == "0001"){
                    return true;
                }
            }

            return false;


            }
    }
}