using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DuenoDatos
    {
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdDueno, Nombre, Telefono FROM Dueno ORDER BY Nombre", cn);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public void Insertar(string nombre, string telefono)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Dueno (Nombre, Telefono) VALUES (@nombre, @telefono)", cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idDueno, string nombre, string telefono)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Dueno SET Nombre = @nombre, Telefono = @telefono WHERE IdDueno = @idDueno", cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idDueno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Dueno WHERE IdDueno = @idDueno", cn);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public int ContarMascotas(int idDueno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Mascota WHERE IdDueno = @idDueno", cn);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);

                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
