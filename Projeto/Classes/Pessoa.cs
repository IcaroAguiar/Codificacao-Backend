using Interface;

namespace Classes {
    public class Pessoa : IPessoa{ 
        public string? nome {get;set;}
        public string? endereco {get;set;}

        public bool pagarImposto(bool imposto)
        {
            return imposto = true;
        }
    }
}