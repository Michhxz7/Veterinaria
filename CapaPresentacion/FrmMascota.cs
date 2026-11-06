using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmMascota : Form
    {
        private MascotaNegocio mascotaNegocio = new MascotaNegocio();
        private DuenoNegocio duenoNegocio = new DuenoNegocio();

        // Guarda el Id de la mascota que se hizo clic en la tabla (0 = ninguna)
        private int idSeleccionado = 0;

        public FrmMascota()
        {
            InitializeComponent();
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDuenos();
                MostrarMascotas(mascotaNegocio.Listar());
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
                mascotaNegocio.Guardar(LeerFormulario());
                MessageBox.Show("Mascota guardada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMascotas(mascotaNegocio.Listar());
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
                mascotaNegocio.Modificar(LeerFormulario());
                MessageBox.Show("Mascota modificada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMascotas(mascotaNegocio.Listar());
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
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar esta mascota?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    mascotaNegocio.Eliminar(idSeleccionado);
                    MessageBox.Show("Mascota eliminada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMascotas(mascotaNegocio.Listar());
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

        // Lista solo las mascotas del dueño elegido en cboFiltroDueno
        private void btnFiltrarDueno_Click(object sender, EventArgs e)
        {
            try
            {
                int idDueno = Convert.ToInt32(cboFiltroDueno.SelectedValue);
                MostrarMascotas(mascotaNegocio.ListarPorDueno(idDueno));
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarMascotas(mascotaNegocio.BuscarPorNombre(txtBuscar.Text));
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarMascotas(mascotaNegocio.Listar());
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // Abre el formulario de dueños y al cerrarlo recarga los combos por si hubo cambios
        private void btnDuenos_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmDueno frmDueno = new FrmDueno())
                {
                    frmDueno.ShowDialog();
                }

                CargarDuenos();
                MostrarMascotas(mascotaNegocio.Listar());
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // Al hacer clic en una fila, sus datos pasan a los controles de arriba
        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMascotas.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdMascota"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtEspecie.Text = fila.Cells["Especie"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                cboDueno.SelectedValue = Convert.ToInt32(fila.Cells["IdDueno"].Value);
            }
        }

        // Cada combo pide su propia tabla; si compartieran la misma, al elegir en uno se movería el otro
        private void CargarDuenos()
        {
            cboDueno.DisplayMember = "Nombre";
            cboDueno.ValueMember = "IdDueno";
            cboDueno.DataSource = duenoNegocio.Listar();

            cboFiltroDueno.DisplayMember = "Nombre";
            cboFiltroDueno.ValueMember = "IdDueno";
            cboFiltroDueno.DataSource = duenoNegocio.Listar();
        }

        private void MostrarMascotas(DataTable tabla)
        {
            dgvMascotas.DataSource = tabla;
            dgvMascotas.Columns["IdMascota"].Visible = false;
            dgvMascotas.Columns["IdDueno"].Visible = false;
            dgvMascotas.Columns["FechaNacimiento"].HeaderText = "Fecha de nacimiento";
            dgvMascotas.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvMascotas.Columns["Edad"].HeaderText = "Edad (años)";
        }

        private Mascota LeerFormulario()
        {
            Mascota mascota = new Mascota();
            mascota.IdMascota = idSeleccionado;
            mascota.Nombre = txtNombre.Text;
            mascota.Especie = txtEspecie.Text;
            mascota.FechaNacimiento = dtpFechaNacimiento.Value;

            if (cboDueno.SelectedValue != null)
            {
                mascota.IdDueno = Convert.ToInt32(cboDueno.SelectedValue);
            }

            return mascota;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtBuscar.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;

            if (cboDueno.Items.Count > 0)
            {
                cboDueno.SelectedIndex = 0;
            }

            idSeleccionado = 0;
            txtNombre.Focus();
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}