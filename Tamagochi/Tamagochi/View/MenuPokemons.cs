using Tamagochi.Model;

namespace Tamagochi.View
{
    public class MenuPokemons
    {
        //Menu that show the first thing when start the program
        public void MenuWelcome()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("WELCOME TO TAMAGOCHI WITH POKEMON");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("What is you name?");
            string nameofPlayer = Console.ReadLine();
            Console.WriteLine("Nice!"+nameofPlayer+" Let's play!!");
        }


        //Menu that show the main options
        public void MainMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Main Menu - What do you whant to do?");
            Console.WriteLine("1 - Adopt a Pokemon");
            Console.WriteLine("2 - See your Pokemons");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("What is your choose?");
        }


        //Get the choose from user
        public int PlayerChoose()
        {
            int playChoose;

            while (!Int32.TryParse(Console.ReadLine(), out playChoose) || playChoose < 1 || playChoose > 4)
            {

                Console.WriteLine("Invalid data! Write between numbers 1 and 3!");  

            }
            return playChoose;
        }

        //Show the menu of adopt a pokemon
        public void ShowMenuAdopt()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Menu of the adopt of Pokemon:");
            Console.WriteLine("1 - See pokemons available");
            Console.WriteLine("2 - See details of pokemon");
            Console.WriteLine("3 - Adopt a Pokemon");
            Console.WriteLine("4 - Back to main menu");
            Console.Write("Choose you option: ");
        }

        //Can see the pokemons available to adopt
        public void ShowPokemonsAvailable(List<ResultsPokemon> pokemonsAvailable)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("See the options of pokemons");
            for (int i = 0; i < pokemonsAvailable.Count; i++) 
            {
                Console.WriteLine((i+1)+ ": "+ pokemonsAvailable[i].Name);

            }
        }


        //Show the information about the pokemon
        public void ShowDetailsOfPokomens(DetailsResultPokemons details)
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine("Details of Pokemon:");
            Console.WriteLine("Name: " + details.Name);
            Console.WriteLine("Height: " + details.Height);
            Console.WriteLine("Weight: " + details.Weight);
            Console.WriteLine("Abilities:");
            foreach (var ability in details.Abilities)
            {
                Console.WriteLine("- " + ability.Ability.Name);
            }

        }

        //You get the response of user about to adopt a pokemon
        public bool ConfirmationOfAdopt()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Do you want adopt this Pokemon? (s/n)");
            string choose = Console.ReadLine();

            return choose.ToLower() == "s";
        }


        public void ShowYourPokemonsAdopting(List<DetailsResultPokemons> pokemonAdopting)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Yours Pokemons: ");

            if (pokemonAdopting.Count == 0)
            {
                Console.WriteLine("You don't adopt any Pokemon");
            }
            else
            {
                for (int i = 0; i < pokemonAdopting.Count; i++)
                {

                    Console.WriteLine((i+1)+": " + pokemonAdopting[i].Name);

                }
            }

        }


        public int GetChooseOfPokemon(List<ResultsPokemon> pokemons)
        {
            Console.WriteLine("-------------------");
            int choose;

            while (true)
            {
                Console.Write("Choose one of this Pokemons each number (1 -"+pokemons.Count + "): ");
                if (int.TryParse(Console.ReadLine(),out choose)&& choose>=1 && choose<=pokemons.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid choose!");

            }
            return choose -1;

        }







    }
}
