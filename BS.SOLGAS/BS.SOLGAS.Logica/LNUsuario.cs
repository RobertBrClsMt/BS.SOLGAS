using BS.SOLGAS.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.SOLGAS.Logica
{
    public class LNUsuario
    {
        ADUsuario adUsuario = new ADUsuario();
        public List<Modelo.Usuario> Usuarios_Listar(string Dni) //buscar usuario
{
            return adUsuario.Usuarios_Listar(Dni);
        }
    }
}
