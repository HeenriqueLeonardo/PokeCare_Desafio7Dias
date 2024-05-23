namespace PokeCare_7dias.Modelos;

public class Jogador
{
    public string Nome { get; set; }

    public List<Pokemon> pokemonsAdotados { get; set; }
    public void adotarPokemon(Pokemon pokemon)
    {
        pokemonsAdotados.Add(pokemon);
    }
    public void exibirPokemonsAdotados()
    {
        if(pokemonsAdotados.Count <= 0) 
        {
            Console.WriteLine("Você ainda não adotou nenhum Pokemon.");
        }
        else
        {
            foreach (var pokemon in pokemonsAdotados)
            {
                pokemon.ExibirFichaPokemon();
            }
        }
    }
}
