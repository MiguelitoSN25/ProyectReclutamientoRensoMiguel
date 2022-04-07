using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
