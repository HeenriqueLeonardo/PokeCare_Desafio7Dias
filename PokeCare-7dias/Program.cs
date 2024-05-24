using System.Threading.Channels;
using PokeCare_7dias.Modelos;

using PokeCare_7dias.Menus;
using PokeCare_7dias.Modelos;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        MenuIniciar.TituloMenuIniciar();
        MenuIniciar.CadastrarJogador();
        MenuDeSelecao.ExibirMenuPrincipal(jogador);
    }
}

