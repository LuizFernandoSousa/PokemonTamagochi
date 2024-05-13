namespace Tamagochi.Model
{
    public class AllPokemons
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<ResultsPokemon> Results { get; set; }
    }
}
