using PokeCare_7dias.Modelos;
using System.Runtime.CompilerServices;

namespace PokeCare_7dias.Menus;

internal static class MenuIniciar
{
    public static void TituloMenuIniciar()
    {
        Console.WriteLine("Bem vindo ao ");
        Console.WriteLine(@"
██████╗  ██████╗ ██╗  ██╗███████╗ ██████╗ █████╗ ██████╗ ███████╗
██╔══██╗██╔═══██╗██║ ██╔╝██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝
██████╔╝██║   ██║█████╔╝ █████╗  ██║     ███████║██████╔╝█████╗  
██╔═══╝ ██║   ██║██╔═██╗ ██╔══╝  ██║     ██╔══██║██╔══██╗██╔══╝  
██║     ╚██████╔╝██║  ██╗███████╗╚██████╗██║  ██║██║  ██║███████╗
╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝

");
        Console.WriteLine("\n\n\n");
    }

    public static void CadastrarJogador()
    {
        Jogador jogador = new Jogador();
        Console.Write("Qual o seu nome? :");
        jogador.Nome = Console.ReadLine();
    }
}
