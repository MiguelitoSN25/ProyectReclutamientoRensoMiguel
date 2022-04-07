using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        [Key]
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Rnc { get; set; }
        public string Direccion { get; set; }
        public int? Sector { get; set; }
        public int? Ciudad { get; set; }
        public int? Provincia { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Fotografia { get; set; }

        public virtual Ciudad CiudadNavigation { get; set; }
        public virtual Provincium ProvinciaNavigation { get; set; }
        public virtual Sector SectorNavigation { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
