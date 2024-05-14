using RestSharp;
using System.Text.Json;
using Tamagochi.Controllers;
using Tamagochi.Data;
using Tamagochi.View;

class Program
{

    static void Main(string[] args)
    {
        PokemonController controller = new PokemonController();
        controller.Start();

    }

}
