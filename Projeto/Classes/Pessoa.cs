using Interface;

namespace Classes {
    public abstract class Pessoa : IPessoa{ 
        // public Pessoa(string? nome, float rendimentos)
        // {
        //     this.nome = nome;
        //     this.rendimentos = rendimentos;
        // }
        public string? nome {get;set;}
        public Endereco? endereco {get;set;}

        public float rendimentos {get;set;}
        

     

        public abstract float pagarImposto(float rendimentos);
    }
}