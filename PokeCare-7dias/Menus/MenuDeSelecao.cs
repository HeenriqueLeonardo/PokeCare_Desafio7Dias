using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace PokeCare_7dias.Menus;

public class MenuDeSelecao
{
    public async Task ExibirMenuAsync()
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
                    await AdotarPokemonAsync();
                    break;
                case "2":
                    Jogador.exibirPokemonsAdotados();
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