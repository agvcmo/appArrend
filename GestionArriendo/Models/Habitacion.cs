using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Armario { get; set; }

        public bool baño { get; set; }
    }
}