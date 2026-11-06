namespace CapaPresentacion
{
    partial class FrmDueno
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
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvDuenos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDuenos).BeginInit();
            SuspendLayout();

            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
          
            txtNombre.Location = new Point(110, 20);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
           
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 58);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            
            txtTelefono.Location = new Point(110, 55);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 3;
          
            btnGuardar.Location = new Point(340, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
      
            btnModificar.Location = new Point(440, 15);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 30);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += new EventHandler(btnModificar_Click);
            
            btnEliminar.Location = new Point(540, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
           
            btnLimpiar.Location = new Point(340, 52);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
           
            dgvDuenos.AllowUserToAddRows = false;
            dgvDuenos.AllowUserToDeleteRows = false;
            dgvDuenos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDuenos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuenos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuenos.Location = new Point(20, 100);
            dgvDuenos.MultiSelect = false;
            dgvDuenos.Name = "dgvDuenos";
            dgvDuenos.ReadOnly = true;
            dgvDuenos.RowHeadersVisible = false;
            dgvDuenos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuenos.Size = new Size(640, 330);
            dgvDuenos.TabIndex = 8;
            dgvDuenos.CellClick += new DataGridViewCellEventHandler(dgvDuenos_CellClick);
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(dgvDuenos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmDueno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dueños";
            Load += new EventHandler(FrmDueno_Load);
            ((System.ComponentModel.ISupportInitialize)dgvDuenos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvDuenos;
    }
}
