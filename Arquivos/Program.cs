
namespace Arquivos{

    class Program{

        static void Main(string[] args){
            
            string caminhoArquivo = "C:\\Users\\ic_ag\\BackEnd\\arquivo.txt";

            var stream =  new StreamWriter(caminhoArquivo);
            stream.Write("Texto salvo com sucesso");
            stream.Close();


            using (var reader = new StreamReader(caminhoArquivo))
            {
                Console.WriteLine(reader.ReadLine());
            }
             
    

        }
    }

}