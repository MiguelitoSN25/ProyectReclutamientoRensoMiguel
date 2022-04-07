using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Servicios = new HashSet<Servicio>();
        }

        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
