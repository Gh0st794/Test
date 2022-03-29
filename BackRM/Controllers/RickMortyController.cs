using BackRM.Models;
using Newtonsoft.Json;
using Json.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace BackRM.Controllers
{
    public class RickMortyController : ApiController
    {
        

        public async Task<Respuesta> Get()
        {
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");
            var charList = JsonConvert.DeserializeObject<RickMortyModel>(Json).results;
            List <Result> vivos = charList.Where(w => w.status == "Alive" && w.species == "Human").ToList();
            List<Result> muertos = charList.Where(w => w.status == "Dead").ToList();
            
            Respuesta res = new Respuesta {
                listaVivos = vivos,
                listaMuertos = muertos,
                cantidadV = vivos.Count,
                cantidadM = muertos.Count
            };
            
            
            return res;
        }
    }
}