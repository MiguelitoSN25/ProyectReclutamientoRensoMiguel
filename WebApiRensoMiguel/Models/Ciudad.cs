using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApiRensoMiguel.Models
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Clientes = new HashSet<Cliente>();
        }
        [Key]
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
