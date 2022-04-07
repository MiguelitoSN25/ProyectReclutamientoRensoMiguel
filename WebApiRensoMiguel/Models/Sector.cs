using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Sector
    {
        public Sector()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Key]
        public int IdSector { get; set; }
        public string NombreSector { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
