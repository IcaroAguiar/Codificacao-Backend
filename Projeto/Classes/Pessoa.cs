using Interface;

namespace Classes {
    public abstract class Pessoa : IPessoa{ 
        public string? nome {get;set;}
        public Endereco? endereco {get;set;}

        public int rendimentos {get;set;}
        
        public Pessoa(string? nome, Endereco? endereco, int rendimentos)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.rendimentos = rendimentos;
        }

     

        public abstract bool pagarImposto(bool imposto);
    }
}