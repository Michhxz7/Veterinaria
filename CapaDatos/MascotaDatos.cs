using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class MascotaDatos
    {
        private string consultaBase = "SELECT m.IdMascota, m.Nombre, m.Especie, m.FechaNacimiento, m.IdDueno, d.Nombre AS Dueno " +
                                      "FROM Mascota m INNER JOIN Dueno d ON m.IdDueno = d.IdDueno";

        private DataTable LlenarTabla(SqlCommand cmd)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);
            return tabla;
        }

        public DataTable Listar()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(consultaBase + " ORDER BY m.Nombre", cn);
                return LlenarTabla(cmd);
            }
        }

        public DataTable ListarPorDueno(int idDueno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(consultaBase + " WHERE m.IdDueno = @idDueno ORDER BY m.Nombre", cn);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);
                return LlenarTabla(cmd);
            }
        }

        public DataTable BuscarPorNombre(string nombre)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(consultaBase + " WHERE m.Nombre LIKE @nombre ORDER BY m.Nombre", cn);
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                return LlenarTabla(cmd);
            }
        }

        public void Insertar(string nombre, string especie, DateTime fechaNacimiento, int idDueno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Mascota (Nombre, Especie, FechaNacimiento, IdDueno) VALUES (@nombre, @especie, @fechaNacimiento, @idDueno)", cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento.Date);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idMascota, string nombre, string especie, DateTime fechaNacimiento, int idDueno)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Mascota SET Nombre = @nombre, Especie = @especie, FechaNacimiento = @fechaNacimiento, IdDueno = @idDueno WHERE IdMascota = @idMascota", cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento.Date);
                cmd.Parameters.AddWithValue("@idDueno", idDueno);
                cmd.Parameters.AddWithValue("@idMascota", idMascota);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idMascota)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Mascota WHERE IdMascota = @idMascota", cn);
                cmd.Parameters.AddWithValue("@idMascota", idMascota);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
