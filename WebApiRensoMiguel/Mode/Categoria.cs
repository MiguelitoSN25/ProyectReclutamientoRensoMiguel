using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Categoria
    {
        public Categoria()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
