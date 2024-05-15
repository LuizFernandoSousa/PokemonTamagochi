namespace Tamagochi.Model
{
    public class PokemonsInfomation
    {

        public int Feed { get; private set; }
        public int Humor { get; private set; }
        public int Energy { get; private set; }
        public int Health { get; private set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public List<Abilities> abilities { get; set; }


        public PokemonsInfomation()
        {
            var rand = new Random();
            Feed = rand.Next(11);
            Humor = rand.Next(11);
            Energy = rand.Next(11);
            Health = rand.Next(11);

        }

        public void UpdateInformations(DetailsResultPokemons details)
        {
            Name = details.Name;
            Weight = details.Weight;
            Height = details.Height;
            abilities = details.Abilities.Select(a => new Abilities { Name = a.Ability.Name}).ToList();
        }

        public void ToPlay()
        {
            Humor = Math.Min(Humor + 3,10);
            Energy = Math.Max(Energy - 2, 0);
            Feed = Math.Max(Feed -1,0);
        }

        public void ToFeed()
        {
            Feed = Math.Min(Feed + 2, 10);
            Energy = Math.Max(Energy - 1, 0);

            Console.WriteLine("Pokemon fed!");
        }

        public void ToRest()
        {
            Energy = Math.Min(Energy + 4, 10);
            Humor = Math.Max(Humor -1,0);
            Console.WriteLine("Pokemon sleep!");
        }

        public void ToGiveAffection()
        {
            Humor = Math.Min(Humor + 2, 10);
            Health = Math.Min(Health + 1, 10);

            Console.WriteLine("Pokemon lovely!");

        }

        public void ShowStatusAboutYourPokemon()
        {
            Console.WriteLine("Status of your Pokemon:");
            Console.WriteLine($"Feed: {Feed}");
            Console.WriteLine($"Humor: {Humor}");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Health: {Health}");
        }

    }





    public class Abilities
    {
        public string Name { get; set; }
    }
}
