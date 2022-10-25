namespace Classes{
    public class Utils
    {
        public static void BarraCarregamento(string texto,int tempo, int quantidade){

        
        
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write($"{texto}");
        

        for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }

        Console.ResetColor();
        // Console.Clear();

        }
    }
}