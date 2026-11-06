using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class DuenoNegocio
    {
        private DuenoDatos datos = new DuenoDatos();

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Guardar(Dueno dueno)
        {
            Validar(dueno);
            datos.Insertar(dueno.Nombre.Trim(), dueno.Telefono.Trim());
        }

        public void Modificar(Dueno dueno)
        {
            if (dueno.IdDueno <= 0)
            {
                throw new Exception("Seleccione un dueño de la tabla.");
            }

            Validar(dueno);
            datos.Actualizar(dueno.IdDueno, dueno.Nombre.Trim(), dueno.Telefono.Trim());
        }

        public void Eliminar(int idDueno)
        {
            if (idDueno <= 0)
            {
                throw new Exception("Seleccione un dueño de la tabla.");
            }

            if (datos.ContarMascotas(idDueno) > 0)
            {
                throw new Exception("No se puede eliminar un dueño que tiene mascotas.");
            }

            datos.Eliminar(idDueno);
        }

        private void Validar(Dueno dueno)
        {
            if (string.IsNullOrWhiteSpace(dueno.Nombre))
            {
                throw new Exception("El nombre del dueño es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(dueno.Telefono))
            {
                throw new Exception("El teléfono es obligatorio.");
            }

            // Regla 3: el teléfono debe tener 10 dígitos numéricos
            string telefono = dueno.Telefono.Trim();

            if (telefono.Length != 10)
            {
                throw new Exception("El teléfono debe tener 10 dígitos.");
            }

            foreach (char letra in telefono)
            {
                if (letra < '0' || letra > '9')
                {
                    throw new Exception("El teléfono solo debe tener números.");
                }
            }
        }
    }
}

