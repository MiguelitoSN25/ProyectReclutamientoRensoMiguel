using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public int IdFacturas { get; set; }
        public int? Servicios { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }

        public virtual Factura IdFacturasNavigation { get; set; }
    }
}
