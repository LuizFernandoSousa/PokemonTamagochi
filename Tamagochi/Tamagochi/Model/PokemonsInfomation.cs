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

        //public void UpdateInformations(DetailsResultPokemons details)
        //{
        //    Name = details.Name;
        //    Weight = details.Weight;
        //    Height = details.Height;
        //    abilities = details.Abilities.Select(a => new Abilities { Name = a.Ability.Name}).ToList();
        //}

        public void ToPlay()
        {
            var rand = new Random();
            Humor = Math.Min(Humor + rand.Next(3),10);
            Energy = Math.Max(Energy - rand.Next(2), 0);
            Feed = Math.Max(Feed - rand.Next(2), 0);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pokemon is Happy!");
        }

        public void ToFeed()
        {
            var rand = new Random();
            Feed = Math.Min(Feed + rand.Next(2), 10);
            Energy = Math.Max(Energy - rand.Next(2), 0);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pokemon fed!");

        }

        public void ToRest()
        {
            var rand = new Random();
            Energy = Math.Min(Energy + rand.Next(4), 10);
            Humor = Math.Max(Humor - rand.Next(2), 0);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pokemon sleep!");
        }

        public void ToGiveAffection()
        {
            var rand = new Random();
            Humor = Math.Min(Humor + rand.Next(4), 10);
            Health = Math.Min(Health + rand.Next(2), 10);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pokemon lovely!");

        }

        public void ShowStatusAboutYourPokemon()
        {
            Console.WriteLine("-----------------------------------");
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
