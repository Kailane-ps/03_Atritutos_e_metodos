using System;

namespace Atritutos_e_metodos_03
{
    class Program
    {
        private const string V = "O personagem esta";

        static void Main(string[] args)
        {
            Personagem Itachi = new Personagem();
            Itachi.Ocupacao = "Akatsuki";
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Itachi.Nome);
            Console.WriteLine($"Clã: {Itachi.Cla}");
            Console.WriteLine($"Ocupação: {Itachi.Ocupacao}");
            Console.WriteLine(Itachi.estadoo());
            Console.ResetColor();

            Console.WriteLine(Itachi.Atacar());
           
        }
    }
}
