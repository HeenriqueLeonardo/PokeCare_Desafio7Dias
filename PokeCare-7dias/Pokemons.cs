namespace PokeCare_7dias;
using Newtonsoft.Json.Linq;

internal class Pokemons
{
    List<string> listaDePokemons = new List<string> 
    {"charmander" , "squirtle" , "bulbasaur" , "pikachu"};

    public string Nome { get; set; }
    public int Altura { get; set; }
    public int Peso{ get; set; }
    public string[] Habilidades { get; set; }

    public static Pokemons FromJson(string jsonData)
    {

    }
}
