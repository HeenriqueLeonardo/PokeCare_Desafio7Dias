namespace PokeCare_7dias;
using Newtonsoft.Json.Linq;


public class Pokemon
{
    private static readonly List<string> listaDePokemons = new List<string>
        {"charmander" , "squirtle" , "bulbasaur" , "pikachu"};

    public string Nome { get; set; }
    public float Altura { get; set; }
    public int Peso{ get; set; }
    public string[] Habilidades { get; set; }

    public static Pokemon FromJson(string jsonData)
    {
        JObject pokemonJson = JObject.Parse(jsonData);

        // Extract the required fields
        Pokemon pokemon = new Pokemon
        {
            Nome = pokemonJson["name"].ToString(),
            Altura = (float)pokemonJson["height"],
            Peso = (int)pokemonJson["weight"],
            Habilidades = pokemonJson["abilities"].Select(a => (string)a["ability"]["name"]).ToArray()
        };

        return pokemon;
    }
    public void ExibirFichaPokemon()
    {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($"Nome: {Nome}\nAltura: {Altura /10}m\n" +
            $"Peso: {Peso/10}kg\nHabilidades: {Habilidades}");
    }
    public static async Task ExibirTodosPokemons()
    {
        foreach (var nomePokemon  in listaDePokemons)
        {
            Pokemon pokemon = await PokemonService.GetPokemonAsync(nomePokemon);
            pokemon.ExibirFichaPokemon();
            Console.WriteLine();
        }
        
    }

}
    

