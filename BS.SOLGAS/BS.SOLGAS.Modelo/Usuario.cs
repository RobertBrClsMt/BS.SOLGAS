using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.SOLGAS.Modelo
{
    public class Usuario
    {
        public string DNI { get; set; }
        public string IdPlaca { get; set; }
        public string Password { get; set; }
        public string Imei { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdPerfil { get; set; }
    }
}
