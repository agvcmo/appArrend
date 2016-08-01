using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public char Tipo { get; set; } 
    }
}