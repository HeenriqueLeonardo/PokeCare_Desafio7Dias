using System.Net.Http;
using System.Threading.Tasks;
namespace PokeCare_7dias;

internal class PokemonService
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task<string> ObterDadosPokemonAsync(string url)
    {
        HttpResponseMessage response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string data = await response.Content.ReadAsStringAsync();
            return data;
        }
        else
        {
            throw new Exception("Erro ao obter os dados do Pokémon.");
        }
    }

    public static async Task<Pokemon> GetPokemonAsync(string NomePokemon)
    {
        string url = $"https://pokeapi.co/api/v2/pokemon/{NomePokemon}";
        string pokemonData = await ObterDadosPokemonAsync(url);
        return Pokemon.FromJson(pokemonData);
    }
}
