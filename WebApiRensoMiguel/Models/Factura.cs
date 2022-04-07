using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Factura
    {
        [Key]
        public int IdFacturas { get; set; }
        public int? Idcliente { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; }
    }
}
