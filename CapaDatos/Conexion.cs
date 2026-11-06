using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static string cadena = "Server=localhost;Database=Veterinaria;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
