using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Archivo
    {
        public int Id { get; set; }
        public string Ruta { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}