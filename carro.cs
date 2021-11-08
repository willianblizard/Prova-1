using System;

namespace projeto_.net
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double resultado;

           Console.WriteLine("informe o tempo gasto e a velocidade media (insira dois valores separados por espaço): ");
           string[] teste = Console.ReadLine().Split(" ");
           double tempo = double.Parse(teste[0]); 
           double velocidadeMedia = double.Parse(teste[1]);

           resultado = velocidadeMedia*tempo/12;

           Console.WriteLine("O combustivel gasto é : ");
           Console.WriteLine(Math.Round(resultado, 3));
        }
    }
}