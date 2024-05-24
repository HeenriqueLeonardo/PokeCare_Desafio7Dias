using PokeCare_7dias.Modelos;
using System.Runtime.CompilerServices;

namespace PokeCare_7dias.Menus;

internal class MenuIniciar
{
    public void TituloMenuIniciar()
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

    public void CadastrarJogador(string nomeJogador)
    {
        Jogador jogador = new Jogador();
        Console.Write("Qual o seu nome? :");
        string nome = Console.ReadLine();
        jogador.Nome = nome;
    }
}
