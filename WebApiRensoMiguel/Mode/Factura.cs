using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Factura
    {
        public Factura()
        {
            Detalles = new HashSet<Detalle>();
        }

        public int IdFacturas { get; set; }
        public int? Idcliente { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
