using AutoMapper;
using Tamagochi.Model;

namespace Tamagochi.Connections
{
    public class AutoMapperPokemons : Profile
    {
        public AutoMapperPokemons()
        {
            CreateMap<DetailsResultPokemons, PokemonsInfomation>()
                .ForMember(point => point.Name, option => option.MapFrom(source => source.Name))
                .ForMember(point => point.Height, option => option.MapFrom(source => source.Height))
                .ForMember(point => point.Weight, option => option.MapFrom(source => source.Weight))
                .ForMember(point => point.abilities, option => option.MapFrom(source => source.Abilities.Select(a => new Abilities { Name = a.Ability.Name })));

            
        }
    }

    public class PokomenService
    {
        private readonly IMapper _mapper;
        public PokomenService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PokemonsInfomation CreatePokemon(DetailsResultPokemons pokemon)
        {
            return _mapper.Map<PokemonsInfomation>(pokemon);
        }
    }



}
