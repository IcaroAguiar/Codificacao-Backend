

namespace Classes
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string? nome, Endereco? endereco, string? dataNasc, string? cpf, int rendimentos) : base(nome, endereco, rendimentos)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.rendimentos = rendimentos;
        }

        public string? dataNasc { get; set; }
        public string? cpf { get; set; }


        public override bool pagarImposto(bool imposto)
        {
            if (rendimentos <= 1500)
            {
                System.Console.WriteLine("Isento de Imposto");
                return imposto = true;
            }
            else if (rendimentos >= 1500 && rendimentos <= 3000)
            {
                System.Console.WriteLine("Imposto de 2%");
                rendimentos = rendimentos * (2 / 100);
                return imposto = true;
            }
            else if (rendimentos >= 3500 && rendimentos <= 6000)
            {
                System.Console.WriteLine("Imposto de 3,5%");
                rendimentos = rendimentos * (35 / 1000);
                return imposto = true;
            }
            else if (rendimentos > 10000)
            {
                System.Console.WriteLine("Imposto de 5%");
                rendimentos = rendimentos * (5 / 100);
                return imposto = true;
            }
            else
            {
                return imposto = false;
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
