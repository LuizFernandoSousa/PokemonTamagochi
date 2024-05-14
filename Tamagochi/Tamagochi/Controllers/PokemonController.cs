using Tamagochi.Data;
using Tamagochi.Model;
using Tamagochi.View;

namespace Tamagochi.Controllers
{
    public class PokemonController
    {
        private MenuPokemons menu { get; set; }
        private PokemonContext pokemonConnection { get; set; }
        private List<ResultsPokemon> pokemonsAvailable { get; set; }

        private List<DetailsResultPokemons> pokemonsAdoption { get; set; }

        public PokemonController()
        {
            menu = new MenuPokemons();
            pokemonConnection = new PokemonContext();
            pokemonsAvailable = pokemonConnection.AllPokemonGet();
            pokemonsAdoption = new List<DetailsResultPokemons>();

        }



        public void Start()
        {
            menu.MenuWelcome();

            while (true)
            {
                menu.MainMenu();
                int choose = menu.PlayerChoose();

                switch(choose)
                {
                    case 1:
                        while (true)
                        {
                            menu.ShowMenuAdopt();
                            choose = menu.PlayerChoose();

                            switch (choose)
                            { 
                                case 1:
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    break;
                                case 2:
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    int pokemonSelected = menu.GetChooseOfPokemon(pokemonsAvailable);
                                    DetailsResultPokemons details = pokemonConnection.GetDetailsOfPokemons(pokemonsAvailable[pokemonSelected]);
                                    menu.ShowDetailsOfPokomens(details);
                                    break;
                                case 3:
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    pokemonSelected = menu.GetChooseOfPokemon(pokemonsAvailable);
                                    details = pokemonConnection.GetDetailsOfPokemons(pokemonsAvailable[pokemonSelected]);
                                    menu.ShowDetailsOfPokomens(details);
                                    if (menu.ConfirmationOfAdopt())
                                    {
                                        pokemonsAdoption.Add(details);
                                        Console.WriteLine("ALL RIGHT! YOU ADOPT A POKEMON!!!");
                                    }
                                    break;
                                case 4:
                                    break;
                            }
                            if (choose == 4)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        menu.ShowYourPokemonsAdopting(pokemonsAdoption);
                        break;
                    case 3:
                        Console.WriteLine("Thanks to play this game!!");
                        return;

                    
                }      
            }
        }
    }
}
