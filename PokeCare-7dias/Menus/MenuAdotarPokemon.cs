using PokeCare_7dias.Modelos;
using PokeCare_7dias.PokecareUtil;

namespace PokeCare_7dias.Menus;

internal class MenuAdotarPokemon
{
    private Jogador jogador;

    public MenuAdotarPokemon(Jogador jogador)
    {
        this.jogador = jogador;
    }

    public static async Task ExibirMenuAdotarPokemon(Jogador jogador)
    {
        bool adotando = true;
        while (adotando)
        {
            Console.WriteLine("Selecione um Pokémon para adotar:");
            await Pokemon.ExibirTodosPokemons();
            Console.Write("Digite o nome do Pokémon: ");
            string nomePokemon = Console.ReadLine().ToLower();

            Pokemon pokemon = await PokemonService.GetPokemonAsync(nomePokemon);

            if (pokemon != null)
            {
                Console.WriteLine("Informações do Pokémon selecionado:");
                pokemon.ExibirFichaPokemon();

                Console.WriteLine("1. Adotar este Pokémon");
                Console.WriteLine("2. Saber mais sobre este Pokémon");
                Console.WriteLine("3. Voltar ao menu principal");
                Console.Write("Selecione uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        jogador.adotarPokemon(pokemon);
                        Console.WriteLine($"Você adotou o {pokemon.Nome}!");
                        adotando = false;
                        break;
                    case "2":
                        pokemon.ExibirFichaPokemon();
                        break;
                    case "3":
                        adotando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Pokémon não encontrado! Tente novamente.");
            }
        }
    }
}