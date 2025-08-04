using System; // Biblioteca do Sistema

namespace MyApp // Separa o bloco de código em blocos lógicos separados
{
    internal class Program // Declara a classe Program como interna, o que significa que só pode ser acessada dentro do mesmo assembly
    {
        static void Main(string[] args) // Método principal que é o ponto de entrada do programa, void não retorna nenhum valor, Static significa que pode ser chamado sem criar uma instância da classe Programe
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Define a cor de fundo do console
            Console.ForegroundColor = ConsoleColor.White; // Define a cor do texto do console
            Console.Clear(); // Limpa o console para aplicar as novas cores

            Console.WriteLine("Hello World!"); // Escreve no console

            Console.WriteLine("Teste teste teste");
            Console.Write("teste é um teste de escrita de texto no console."); //Escreve no console sem pular linha

            Console.Beep(); // Emite um som de beep no console
        }
    }
}