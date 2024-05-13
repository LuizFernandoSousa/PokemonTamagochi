//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


using RestSharp;
using System.Text.Json;
using Tamagochi.Data;
using Tamagochi.View;

class Program
{

    static void Main(string[] args)
    {
        //var pokemons = new PokemonContext();

        //var imprimir = pokemons.AllPokemonGet();

        //foreach (var pokemon in imprimir) 
        //{
        //    Console.WriteLine(pokemon.Name);
        //}


        var Menu = new MenuPokemons();

        //Menu.MenuWelcome();
        //Menu.MainMenu();
        Menu.ComfirmationOfAdopt();
        Console.WriteLine(Menu.ComfirmationOfAdopt());
        



    }

}
