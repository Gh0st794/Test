using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackRM.Models
{
    public class ResponseModel : RickMortyModel
    {
               

    }    

    public class Respuesta
    {
        public List<Result> listaVivos { get; set; }
        public List<Result> listaMuertos { get; set; }
        public int cantidadV { get; set; }
        public int cantidadM { get; set; }
    }
}