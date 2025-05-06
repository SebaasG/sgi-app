using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Terceros
    {
        public Terceros(string id, string apellidos, int tipoDoc, int ciudadId)
        {
            this.Id = id;
            this.Apellidos = apellidos;
            this.TipoDoc = tipoDoc;
            this.CiudadId = ciudadId;

        }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public int TipoDoc { get; set; }
        public int TipoTercero { get; set; }
        public int CiudadId { get; set; }

    }
}