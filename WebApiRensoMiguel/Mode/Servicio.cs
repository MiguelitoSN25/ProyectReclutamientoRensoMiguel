using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Servicio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public decimal? Precio { get; set; }
        public int? Categoria { get; set; }

        public virtual Categoria CategoriaNavigation { get; set; }
    }
}
