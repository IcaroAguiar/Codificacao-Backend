namespace Classes {
    public class Endereco
    {
        public Endereco(string? cidade, string? estado, string? bairro, string? rua, int numero)
        {
            this.cidade = cidade;
            this.estado = estado;
            this.bairro = bairro;
            this.rua = rua;
            this.numero = numero;
        }

        public string? cidade{get;set;}
        public string? estado{get;set;}
        public string? bairro{get;set;}
        public string? rua{get;set;}
        public int numero{get;set;}

      


    }
}