using AutoMapper;
using Tamagochi.Connections;
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

        private List<PokemonsInfomation> pokemonsAdoption { get; set; }

        IMapper mapper { get; set; }

        public PokemonController()
        {
            var config = new MapperConfiguration(
                cfg => { cfg.AddProfile<AutoMapperPokemons>();
            });

            mapper = config.CreateMapper();


            menu = new MenuPokemons();
            pokemonConnection = new PokemonContext();
            pokemonsAvailable = pokemonConnection.AllPokemonGet();
            pokemonsAdoption = new List<PokemonsInfomation>();

        }



        public void Start()
        {
            menu.MenuWelcome();

            do
            {
                menu.MainMenu();
                int choose = menu.PlayerChoose(4);

                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            menu.ShowMenuAdopt();
                            choose = menu.PlayerChoose(4);
                            if (choose == -1)
                            {                               
                                menu.ShowMenuAdopt();
                            }
                            switch (choose)
                            {
                                case 1:
                                    Console.Clear();
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    break;
                                case 2:
                                    Console.Clear();
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    var pokemonSelect = menu.GetChooseOfPokemon(pokemonsAvailable);
                                    Console.Clear();
                                    DetailsResultPokemons details = pokemonConnection.GetDetailsOfPokemons(pokemonsAvailable[pokemonSelect]);
                                    menu.ShowDetailsOfPokomens(details);
                                    break;
                                case 3:
                                    Console.Clear();
                                    menu.ShowPokemonsAvailable(pokemonsAvailable);
                                    pokemonSelect = menu.GetChooseOfPokemon(pokemonsAvailable);
                                    details = pokemonConnection.GetDetailsOfPokemons(pokemonsAvailable[pokemonSelect]);
                                    menu.ShowDetailsOfPokomens(details);
                                    if (menu.ConfirmationOfAdopt())
                                    {
                                        var pokemon = mapper.Map<PokemonsInfomation>(details);
                                        pokemonsAdoption.Add(pokemon);
                                        Console.Clear();
                                        Console.WriteLine($"ALL RIGHT! YOU ADOPT THE {details.Name} :D !!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----------------------------------");
                                        Console.WriteLine("All right, you can select another pokemon :(");
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
                        while (true);                        
                        break;
                    case 2:
                        Console.Clear();
                        if (pokemonsAdoption.Count == 0)
                        {

                            Console.WriteLine("You don't adopt any Pokemon");
                            break;

                        }
                        Console.WriteLine("Choose a Pokemon to interact");
                        for (int i = 0; i < pokemonsAdoption.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {pokemonsAdoption[i].Name}");
                        }
                        Console.WriteLine($"Which Pokemon you want interactive? (1 to {pokemonsAdoption.Count}");
                        int numberOfPokemon = menu.PlayerChoose(pokemonsAdoption.Count) - 1;
                        PokemonsInfomation pokemonSelected = pokemonsAdoption[numberOfPokemon];

                        int optInteract = 0;
                        do
                        {
                            Console.Clear();
                            menu.MenuWhatToDoWithYourPokemon(pokemonsAdoption[numberOfPokemon]);
                            optInteract = menu.PlayerChoose(6);

                            switch (optInteract)
                            {
                                case 1:
                                    pokemonSelected.ShowStatusAboutYourPokemon();
                                    break;
                                case 2:
                                    pokemonSelected.ToFeed();
                                    break;
                                case 3:
                                    pokemonSelected.ToPlay();
                                    break;
                                case 4:
                                    pokemonSelected.ToRest();
                                    break;
                                case 5:
                                    pokemonSelected.ToGiveAffection();
                                    break;
                                case 6:
                                    break;
                            }

                        }
                        while (optInteract != 6);                        
                        break;

                    case 3:
                        menu.ShowYourPokemonsAdopting(pokemonsAdoption);
                        break;



                    case 4:
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Thanks to play this game!!");
                        Console.WriteLine("-----------------------------------");
                        return;

                }
            }
            while (true);           
        }
    }
}
