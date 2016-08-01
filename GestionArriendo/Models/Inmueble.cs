using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        public virtual Arrendatario Arrendatario { get; set; }
        public virtual Arrendatario Arrendador { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public int MyProperty { get; set; }
        public string Tipo { get; set; }
        public int BañosComunes  { get; set; }
        public double Area { get; set; }
        public virtual ObservableCollection<Archivo> Archivo { get; set; }
        public int Estrato { get; set; }
        public float Precio { get; set; }
        public Contrato ContratoInmueble { get; set; }
        public bool Patio { get; set; }
        public bool Parqueadero { get; set; }
        public int Lavadero { get; set; }
        public bool Comedor { get; set; }
        public bool SalaComedor { get; set; }
        public bool Sala { get; set; }
        public virtual ObservableCollection<Habitacion> habitaciones { get; set; }
    }
}