using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public static class PokemonService
    {
        public static Pokemon BuscarCaracteristicasPorEspecie(string especie)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
                     
            return JsonSerializer.Deserialize<Pokemon>(response.Content);
        }


    }
}
