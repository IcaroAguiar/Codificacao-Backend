using Interface;
namespace Classes
{
    public class PessoaJuridica: Pessoa
    {
        public string? razaoSocial {get;set;}
        public string? cnpj {get;set;}
    }
}