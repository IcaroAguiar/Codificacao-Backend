using Interface;
namespace Classes
{
    public abstract class PessoaJuridica: Pessoa
    {
        public string? razaoSocial {get;set;}
        public string? cnpj {get;set;}
    }
}