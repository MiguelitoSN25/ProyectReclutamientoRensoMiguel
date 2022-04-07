using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Detalle
    {
        [Key]
        public int IdFacturas { get; set; }
        public int? Servicios { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }

        public virtual Servicio ServiciosNavigation { get; set; }
    }
}
