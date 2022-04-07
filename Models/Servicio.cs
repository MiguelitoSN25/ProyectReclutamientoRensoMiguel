using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Detalles = new HashSet<Detalle>();
        }
        [Key]
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public decimal? Precio { get; set; }
        public int? Categoria { get; set; }

        public virtual Categoria CategoriaNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
