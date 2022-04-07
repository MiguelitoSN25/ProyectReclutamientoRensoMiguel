using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Provincium
    {
        public Provincium()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Key]
        public int IdProvincia { get; set; }
        public string NombreProvincia { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
