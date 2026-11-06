using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmDueno : Form
    {
        private DuenoNegocio duenoNegocio = new DuenoNegocio();

        private int idSeleccionado = 0;

        public FrmDueno()
        {
            InitializeComponent();
        }

        private void FrmDueno_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarDuenos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                duenoNegocio.Guardar(LeerFormulario());
                MessageBox.Show("Dueño guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDuenos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                duenoNegocio.Modificar(LeerFormulario());
                MessageBox.Show("Dueño modificado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDuenos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar este dueño?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    duenoNegocio.Eliminar(idSeleccionado);
                    MessageBox.Show("Dueño eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDuenos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvDuenos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDuenos.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdDueno"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }

        private void MostrarDuenos()
        {
            dgvDuenos.DataSource = duenoNegocio.Listar();
            dgvDuenos.Columns["IdDueno"].Visible = false;
        }

        private Dueno LeerFormulario()
        {
            Dueno dueno = new Dueno();
            dueno.IdDueno = idSeleccionado;
            dueno.Nombre = txtNombre.Text;
            dueno.Telefono = txtTelefono.Text;
            return dueno;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            idSeleccionado = 0;
            txtNombre.Focus();
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
