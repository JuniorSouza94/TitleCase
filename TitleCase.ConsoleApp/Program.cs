namespace TitleCase.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            // Converte todas as palavras para o formato "Title Case"
            string[] palavras = frase.ToLower().Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = char.ToUpper(palavras[i][0]) + palavras[i].Substring(1);
            }

            // Imprime a frase convertida
            string fraseConvertida = string.Join(" ", palavras);
            Console.WriteLine("Frase convertida: " + fraseConvertida);
        }
    }
}