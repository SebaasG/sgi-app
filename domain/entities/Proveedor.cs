using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Proveedor
    {
   
        public int Id { get; set; }
        public int TerceroId { get; set; }
        public double Dcto { get; set; }
        public int DiaPago { get; set; }
    }
}