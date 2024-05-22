using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace PokeCare_7dias;

public class MenuDeSelecao
{
    //Conecta com a api
    public static async Task Main(string[] args)
    {
        try
        {
            string nomePokemon = "pikachu";
            string url = $"https://pokeapi.co/api/v2/pokemon/{nomePokemon}";

            string DadosDoPokemon = await ObterDadosPokemonAsync(url);
            Console.WriteLine(DadosDoPokemon);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    //Conecta com a api
    public static async Task<string> ObterDadosPokemonAsync(string url)
    {
        using (HttpClient client = new HttpClient())
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
    }
}