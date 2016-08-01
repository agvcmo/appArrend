using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public MedioPago MedioDePago { get; set; }
        public virtual ObservableCollection<Archivo> Archivos { get; set; }
        public virtual ObservableCollection<Inmueble> InmueblePago{ get; set; }
        public virtual ObservableCollection<Arrendatario> ArrendatarioPago{ get; set; }
    }
}