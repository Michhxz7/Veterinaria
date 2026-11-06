using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class MascotaNegocio
    {
        private MascotaDatos datos = new MascotaDatos();

        public DataTable Listar()
        {
            return AgregarEdad(datos.Listar());
        }

        public DataTable ListarPorDueno(int idDueno)
        {
            if (idDueno <= 0)
            {
                throw new Exception("Seleccione un dueño.");
            }

            return AgregarEdad(datos.ListarPorDueno(idDueno));
        }

        public DataTable BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Escriba el nombre de la mascota que quiere buscar.");
            }

            return AgregarEdad(datos.BuscarPorNombre(nombre.Trim()));
        }

        public void Guardar(Mascota mascota)
        {
            Validar(mascota);
            datos.Insertar(mascota.Nombre.Trim(), mascota.Especie.Trim(), mascota.FechaNacimiento, mascota.IdDueno);
        }

        public void Modificar(Mascota mascota)
        {
            if (mascota.IdMascota <= 0)
            {
                throw new Exception("Seleccione una mascota de la tabla.");
            }

            Validar(mascota);
            datos.Actualizar(mascota.IdMascota, mascota.Nombre.Trim(), mascota.Especie.Trim(), mascota.FechaNacimiento, mascota.IdDueno);
        }

        public void Eliminar(int idMascota)
        {
            if (idMascota <= 0)
            {
                throw new Exception("Seleccione una mascota de la tabla.");
            }

            datos.Eliminar(idMascota);
        }

        private void Validar(Mascota mascota)
        {
            if (string.IsNullOrWhiteSpace(mascota.Nombre))
            {
                throw new Exception("El nombre de la mascota es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(mascota.Especie))
            {
                throw new Exception("La especie es obligatoria.");
            }

            if (mascota.FechaNacimiento.Date > DateTime.Today)
            {
                throw new Exception("La fecha de nacimiento no puede ser futura.");
            }

            if (mascota.IdDueno <= 0)
            {
                throw new Exception("Debe seleccionar un dueño.");
            }
        }

        private DataTable AgregarEdad(DataTable tabla)
        {
            tabla.Columns.Add("Edad", typeof(int));

            foreach (DataRow fila in tabla.Rows)
            {
                DateTime nacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                fila["Edad"] = CalcularEdad(nacimiento);
            }

            return tabla;
        }

        private int CalcularEdad(DateTime nacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - nacimiento.Year;

            if (nacimiento.Date > hoy.AddYears(-edad))
            {
                edad = edad - 1;
            }

            return edad;
        }
    }
}
