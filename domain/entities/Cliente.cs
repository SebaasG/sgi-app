using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Cliente
    {
        public Cliente(string id, DateTime fechaNac)
        {
            this.Id = id;
            this.FechaNac = fechaNac;

        }
        public string Id { get; set; }
        public string TerceroId { get; set; }
        public DateTime FechaNac { get; set; }
        public DateTime FechaUCompra { get; set; }
    }
}