using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiRensoMiguel.Mode
{
    public partial class Sector
    {
        public Sector()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdSector { get; set; }
        public string NombreSector { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
