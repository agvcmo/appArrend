using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Novedad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public TipoDaño Tipo { get; set; }
    }
}