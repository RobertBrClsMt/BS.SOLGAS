using System.Data.SqlClient;
using System.Configuration;
using System;

namespace BS.SOLGAS.Datos
{
    class ADConexion
    {

        public SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BDFactMovil_Connector"].ConnectionString);

        public string Conexion()
        {
            return cn.ConnectionString;
        }
        public void Conectar()
        {
            try
            {
                cn.Open();

                Console.WriteLine("Conexion Abierta");
            }
            catch
            {
                Console.WriteLine("Error en la Conexion");
            }
        }

        public void Desconectar()
        {
            cn.Close();
            Console.WriteLine("Conexion Cerrada");
        }
    }
}