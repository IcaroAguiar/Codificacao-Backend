using Interface;

namespace Classes {
    public abstract class Pessoa : IPessoa{ 
        public string? nome {get;set;}
        public string? endereco {get;set;}
    }
}