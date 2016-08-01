using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace GestionArriendo.Models
{
    public class Arrendatario : Usuario
    {
        public string TipoArrendatario { get; set; }
        public virtual ObservableCollection<Archivo>  fk_Archivo { get; set; }

    }
}