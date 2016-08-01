using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Estado { get; set; }
        public virtual ObservableCollection<Archivo> Archivos { get; set; }
    }
}