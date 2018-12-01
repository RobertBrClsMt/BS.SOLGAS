using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS.SOLGAS.Modelo;

namespace BS.SOLGAS.Datos
{
    public class ADUsuario
    {
        ADConexion cnn = new ADConexion();

        public List<Usuario> Usuarios_Listar(string Dni) //buscar usuario
        {
            List<Usuario> Usuarios = new List<Usuario>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "bs_UsuariosListar";
                cmd.Connection = cnn.cn;
                cnn.Conectar();

                cmd.Parameters.AddWithValue("@dni", Dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);


                for (int n = 0; n < dt.Rows.Count; n++)
                {
                    Usuario usuario = new Usuario();
                    usuario.DNI = Funciones.ToString(dt.Rows[n]["dni"]);
                    usuario.IdPlaca = Funciones.ToString(dt.Rows[n]["id_placa"]);
                    //usuario.Password = Funciones.ToString(dt.Rows[n]["password"]);
                    usuario.Imei = Funciones.ToString(dt.Rows[n]["imei"]);
                    usuario.Nombre = Funciones.ToString(dt.Rows[n]["nombre"]);
                    usuario.FechaModificacion = Funciones.ToDateTime(dt.Rows[n]["fecha_modificaion"]);
                    usuario.IdPerfil = Funciones.ToInt(dt.Rows[n]["id_perfil"]);

                    Usuarios.Add(usuario);
                }
            }
            catch (SqlException ex) { }
            try
            {
                cnn.Desconectar();
            }
            catch (Exception ex) { }
            return Usuarios;
        }

    }
}