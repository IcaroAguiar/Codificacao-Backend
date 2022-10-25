using System.Text.RegularExpressions;
namespace Classes
{
    public class PessoaJuridica : Pessoa
    {

        // public PessoaJuridica(string? nome, string? razaoSocial, string? cnpj, float rendimentos) : base(nome, rendimentos)
        // {
        //     this.nome = nome;
        //     this.endereco = endereco;
        //     this.razaoSocial = razaoSocial;
        //     this.cnpj = cnpj;
        //     this.rendimentos = rendimentos;
        // }
        public string? razaoSocial { get; set; }
        public string? cnpj { get; set; }

        public override float pagarImposto(float rendimentos)
        {   

            float imposto;
            if (rendimentos <= 3000)
            {
               
                imposto = rendimentos * (3 / 100);
                return imposto;
            }
            else if (rendimentos >= 3000 && rendimentos <= 6000)
            {
                
                imposto = rendimentos * (5 / 100);
                return imposto;
            }
            else if (rendimentos >= 6000 && rendimentos <= 10000)
            {
                
                imposto = rendimentos * (7 / 100);
                return imposto;
            }
            else if (rendimentos > 10000)
            {
               
                imposto = rendimentos * (9 / 100);
                return imposto;
            }
            else
            {
                return imposto = 0;
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