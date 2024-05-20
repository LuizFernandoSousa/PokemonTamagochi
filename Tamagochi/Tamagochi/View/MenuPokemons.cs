using Tamagochi.Model;

namespace Tamagochi.View
{
    public class MenuPokemons
    {
        string nameofPlayer;
        //Menu that show the first thing when start the program
        public void MenuWelcome()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" WELCOME TO TAMAGOCHI WITH POKEMON ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("What is you name?");
            nameofPlayer = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nice! "+nameofPlayer+" Let's start!!");
            
        }


        //Menu that show the main options
        public void MainMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("============ Main Menu ============");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("What do you whant to do?");
            Console.WriteLine("1 - Adopt a Pokemon");
            Console.WriteLine("2 - Interact with your Pokemons");
            Console.WriteLine("3 - See your Pokemons adotp");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("What is your choose?");
        }


        //Get the choose from user
        public int PlayerChoose(int maxOpt)
        {
            int playChoose;
            Console.WriteLine("-----------------------------------");
            while (!Int32.TryParse(Console.ReadLine(), out playChoose) || playChoose < 1 || playChoose > maxOpt)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Invalid data! Write between numbers 1 and {maxOpt}!");
                return playChoose - 1;
                


            }
            Console.WriteLine("-----------------------------------");
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
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Choose you option: ");
        }

        //Can see the pokemons available to adopt
        public void ShowPokemonsAvailable(List<ResultsPokemon> pokemonsAvailable)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("See the options of pokemons");
            for (int i = 0; i < pokemonsAvailable.Count; i++) 
            {
                Console.WriteLine((i+1)+ ": "+ pokemonsAvailable[i].Name);

            }
           
        }


        //Show the information about the pokemon
        public void ShowDetailsOfPokomens(DetailsResultPokemons details)
        {

            Console.WriteLine("-----------------------------------");
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
            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Do you want adopt this Pokemon? (Y/N)");
                string choose = Console.ReadLine();
                
                if (String.Equals("Y",choose.ToUpper()))
                {
                    return true;
                    break;
                }
                if(string.Equals("N", choose.ToUpper()))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Incorrect data! Choose between Yes or Not (Y/N)");
                }                

            } while (true);             
            
        }


        public void ShowYourPokemonsAdopting(List<PokemonsInfomation> pokemonAdopting)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Yours Pokemons: ");

            if (pokemonAdopting.Count == 0)
            {
                Console.WriteLine("-----------------------------------");
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
            Console.WriteLine("-----------------------------------");
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

        public int GetChooseOfPokemonAdoption(List<DetailsResultPokemons> pokemonAdopting)
        {
            Console.WriteLine("-----------------------------------");
            int choose;

            while (true)
            {
                Console.Write("Choose one of this Pokemons each number (1 -" + pokemonAdopting.Count + "): ");
                if (int.TryParse(Console.ReadLine(), out choose) && choose >= 1 && choose <= pokemonAdopting.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid choose!");

            }
            return choose - 1;

        }

        public void MenuWhatToDoWithYourPokemon(PokemonsInfomation adoptPokemons)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Menu of the interation");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(nameofPlayer+" What you whant to do?");
            Console.WriteLine($"1 - How is {adoptPokemons.Name} are?");
            Console.WriteLine($"2 - Feed the {adoptPokemons.Name}!");
            Console.WriteLine($"3 - Play with {adoptPokemons.Name}!");
            Console.WriteLine($"4 - Do {adoptPokemons.Name} rest!");
            Console.WriteLine($"5 - Give affect to {adoptPokemons.Name}!");
            Console.WriteLine("6 - Come back");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Which option you want");
        }

       

        







    }
}
