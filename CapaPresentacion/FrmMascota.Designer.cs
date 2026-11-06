namespace CapaPresentacion
{
    partial class FrmMascota
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblDueno = new Label();
            cboDueno = new ComboBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblFiltroDueno = new Label();
            cboFiltroDueno = new ComboBox();
            btnFiltrarDueno = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnVerTodas = new Button();
            btnDuenos = new Button();
            dgvMascotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
           
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
           
            txtNombre.Location = new Point(150, 20);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
        
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(20, 58);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(52, 15);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie:";
            
            txtEspecie.Location = new Point(150, 55);
            txtEspecie.MaxLength = 50;
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(200, 23);
            txtEspecie.TabIndex = 3;
          
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(20, 93);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(116, 15);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
         
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(150, 90);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 5;
          
            lblDueno.AutoSize = true;
            lblDueno.Location = new Point(20, 128);
            lblDueno.Name = "lblDueno";
            lblDueno.Size = new Size(44, 15);
            lblDueno.TabIndex = 6;
            lblDueno.Text = "Dueño:";
          
            cboDueno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDueno.FormattingEnabled = true;
            cboDueno.Location = new Point(150, 125);
            cboDueno.Name = "cboDueno";
            cboDueno.Size = new Size(200, 23);
            cboDueno.TabIndex = 7;
            
            btnGuardar.Location = new Point(380, 20);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
         
            btnModificar.Location = new Point(380, 55);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += new EventHandler(btnModificar_Click);
           
            btnEliminar.Location = new Point(380, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
           
            btnLimpiar.Location = new Point(380, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
          
            lblFiltroDueno.AutoSize = true;
            lblFiltroDueno.Location = new Point(520, 20);
            lblFiltroDueno.Name = "lblFiltroDueno";
            lblFiltroDueno.Size = new Size(122, 15);
            lblFiltroDueno.TabIndex = 12;
            lblFiltroDueno.Text = "Mascotas de un dueño:";
           
            cboFiltroDueno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroDueno.FormattingEnabled = true;
            cboFiltroDueno.Location = new Point(520, 42);
            cboFiltroDueno.Name = "cboFiltroDueno";
            cboFiltroDueno.Size = new Size(200, 23);
            cboFiltroDueno.TabIndex = 13;
           
            btnFiltrarDueno.Location = new Point(730, 40);
            btnFiltrarDueno.Name = "btnFiltrarDueno";
            btnFiltrarDueno.Size = new Size(120, 27);
            btnFiltrarDueno.TabIndex = 14;
            btnFiltrarDueno.Text = "Ver mascotas";
            btnFiltrarDueno.UseVisualStyleBackColor = true;
            btnFiltrarDueno.Click += new EventHandler(btnFiltrarDueno_Click);
           
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(520, 80);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(158, 15);
            lblBuscar.TabIndex = 15;
            lblBuscar.Text = "Buscar mascota por nombre:";
          
            txtBuscar.Location = new Point(520, 102);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 16;
           
            btnBuscar.Location = new Point(730, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 27);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            
            btnVerTodas.Location = new Point(520, 140);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(200, 30);
            btnVerTodas.TabIndex = 18;
            btnVerTodas.Text = "Ver todas las mascotas";
            btnVerTodas.UseVisualStyleBackColor = true;
            btnVerTodas.Click += new EventHandler(btnVerTodas_Click);
           
            btnDuenos.Location = new Point(730, 140);
            btnDuenos.Name = "btnDuenos";
            btnDuenos.Size = new Size(120, 30);
            btnDuenos.TabIndex = 19;
            btnDuenos.Text = "Dueños";
            btnDuenos.UseVisualStyleBackColor = true;
            btnDuenos.Click += new EventHandler(btnDuenos_Click);
           
            dgvMascotas.AllowUserToAddRows = false;
            dgvMascotas.AllowUserToDeleteRows = false;
            dgvMascotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(20, 185);
            dgvMascotas.MultiSelect = false;
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.ReadOnly = true;
            dgvMascotas.RowHeadersVisible = false;
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.Size = new Size(830, 395);
            dgvMascotas.TabIndex = 20;
            dgvMascotas.CellClick += new DataGridViewCellEventHandler(dgvMascotas_CellClick);
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 600);
            Controls.Add(dgvMascotas);
            Controls.Add(btnDuenos);
            Controls.Add(btnVerTodas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnFiltrarDueno);
            Controls.Add(cboFiltroDueno);
            Controls.Add(lblFiltroDueno);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cboDueno);
            Controls.Add(lblDueno);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmMascota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinaria - Mascotas";
            Load += new EventHandler(FrmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblDueno;
        private ComboBox cboDueno;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblFiltroDueno;
        private ComboBox cboFiltroDueno;
        private Button btnFiltrarDueno;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnVerTodas;
        private Button btnDuenos;
        private DataGridView dgvMascotas;
    }
}
