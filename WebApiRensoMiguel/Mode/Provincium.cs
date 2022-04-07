using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Provincium
    {
        public Provincium()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdProvincia { get; set; }
        public string NombreProvincia { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
