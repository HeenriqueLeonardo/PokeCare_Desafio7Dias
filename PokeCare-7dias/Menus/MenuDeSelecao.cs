using PokeCare_7dias.Modelos;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace PokeCare_7dias.Menus;

public class MenuDeSelecao : Jogador
{
    public Jogador jogador;

    public MenuDeSelecao(Jogador jogador)
    {
        this.jogador = jogador;
    }

    public static async Task ExibirMenuPrincipal(Jogador jogador)
    {
        bool executando = true;
        while (executando)
        {
            Console.WriteLine("Bem-vindo ao PokeCare!");
            Console.WriteLine("1. Adotar um Pokémon");
            Console.WriteLine("2. Ver seus mascotes");
            Console.WriteLine("3. Sair");
            Console.Write("Selecione uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MenuAdotarPokemon.ExibirMenuAdotarPokemon(jogador);
                    break;
                case "2":
                    jogador.exibirPokemonsAdotados();
                    break;
                case "3":
                    executando = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}


