using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;
using Tamagochi.Model;

namespace Tamagochi.Data
{
    public class PokemonContext
    {        
        public List<ResultsPokemon> AllPokemonGet()
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Get(request);

            AllPokemons pokemonsavailable = JsonConvert.DeserializeObject<AllPokemons>(response.Content);
            

           return  pokemonsavailable.Results;
        }



        public DetailsResultPokemons GetDetailsOfPokemons(ResultsPokemon pokemon)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon.Name}");
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);


            return JsonConvert.DeserializeObject<DetailsResultPokemons>(response.Content);

        }

    }
}
