

namespace Classes
{
    public class PessoaFisica : Pessoa
    {
        // public PessoaFisica(string? nome, string? dataNasc, string? cpf, float rendimentos) : base(nome, rendimentos)
        // {
        //     this.nome = nome;
        //     this.dataNasc = dataNasc;
        //     this.cpf = cpf;
        //     this.rendimentos = rendimentos;
        // }

        public DateTime dataNasc { get; set; }
        public string? cpf { get; set; }


        public override float pagarImposto(float rendimentos)
        {    

            float imposto;
            if (rendimentos <= 1500)
            {
               
                return imposto = 0;
            }
            else if (rendimentos >= 1500 && rendimentos <= 3000)
            {
               
                imposto = rendimentos * (2 / 100);
                return imposto;
            }
            else if (rendimentos >= 3500 && rendimentos <= 6000)
            {
                
                imposto = rendimentos * (35 / 1000);
                return imposto;
            }
            else if (rendimentos > 10000)
            {
                
                imposto = rendimentos * (5 / 100);
                return imposto;
            }
            else
            {
                return imposto = 0;
            }




        }

        public bool ValidarData(string dataNasc)
        {
            DateTime dataValor;
            if (DateTime.TryParse(dataNasc, out dataValor))
            {
                System.Console.WriteLine("Data válida");
                return true;
            }
            else
            {
                System.Console.WriteLine("Data inválida");
                return false;
            }


        }

        public bool ValidarData(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                System.Console.WriteLine("Data válida");
                return true;
            }
            System.Console.WriteLine("Data inválida");
            return false;
        }

    }

}
