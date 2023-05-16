namespace GUIs.Visual
{
    partial class MantenimientoProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnRefrescar = new Button();
            proveedoresDGV = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            buscarProveedor = new TextBox();
            separador = new Panel();
            btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)proveedoresDGV).BeginInit();
            SuspendLayout();
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Transparent;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.ForeColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.Location = new Point(489, 76);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(50, 56);
            btnRefrescar.TabIndex = 18;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // proveedoresDGV
            // 
            proveedoresDGV.AllowUserToAddRows = false;
            proveedoresDGV.AllowUserToDeleteRows = false;
            proveedoresDGV.AllowUserToResizeColumns = false;
            proveedoresDGV.AllowUserToResizeRows = false;
            proveedoresDGV.BackgroundColor = Color.White;
            proveedoresDGV.BorderStyle = BorderStyle.None;
            proveedoresDGV.CausesValidation = false;
            proveedoresDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            proveedoresDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            proveedoresDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            proveedoresDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proveedoresDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cedula, Correo, Edad });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            proveedoresDGV.DefaultCellStyle = dataGridViewCellStyle5;
            proveedoresDGV.EnableHeadersVisualStyles = false;
            proveedoresDGV.GridColor = Color.FromArgb(64, 64, 64);
            proveedoresDGV.ImeMode = ImeMode.NoControl;
            proveedoresDGV.Location = new Point(100, 179);
            proveedoresDGV.MultiSelect = false;
            proveedoresDGV.Name = "proveedoresDGV";
            proveedoresDGV.ReadOnly = true;
            proveedoresDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(51, 51, 102);
            proveedoresDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            proveedoresDGV.RowTemplate.Height = 25;
            proveedoresDGV.ScrollBars = ScrollBars.Vertical;
            proveedoresDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            proveedoresDGV.Size = new Size(537, 348);
            proveedoresDGV.TabIndex = 11;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Cedula
            // 
            Cedula.Frozen = true;
            Cedula.HeaderText = "Cedula/RUC";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            Cedula.Width = 80;
            // 
            // Correo
            // 
            Correo.Frozen = true;
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 180;
            // 
            // Edad
            // 
            Edad.Frozen = true;
            Edad.HeaderText = "Telefono";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // buscarProveedor
            // 
            buscarProveedor.BackColor = Color.White;
            buscarProveedor.BorderStyle = BorderStyle.None;
            buscarProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buscarProveedor.Location = new Point(100, 147);
            buscarProveedor.Name = "buscarProveedor";
            buscarProveedor.PlaceholderText = " 🔎 Buscar...";
            buscarProveedor.Size = new Size(537, 22);
            buscarProveedor.TabIndex = 12;
            buscarProveedor.TextChanged += buscarProveedor_TextChanged;
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(100, 132);
            separador.Name = "separador";
            separador.Size = new Size(537, 2);
            separador.TabIndex = 17;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(70, 15, 75);
            btnCerrar.BackgroundColor = Color.FromArgb(70, 15, 75);
            btnCerrar.BorderColor = Color.Transparent;
            btnCerrar.BorderRadius = 10;
            btnCerrar.BorderSize = 0;
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(539, 88);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 33);
            btnCerrar.TabIndex = 16;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEliminar.Location = new Point(268, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 43);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.FromArgb(118, 27, 141);
            btnCrear.Location = new Point(101, 83);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(76, 43);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEditar.Location = new Point(180, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 43);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // MantenimientoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 650);
            Controls.Add(btnRefrescar);
            Controls.Add(proveedoresDGV);
            Controls.Add(buscarProveedor);
            Controls.Add(separador);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoProveedor";
            Text = "MantenimientoProveedor";
            Load += MantenimientoProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)proveedoresDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        public DataGridView proveedoresDGV;
        private TextBox buscarProveedor;
        private Panel separador;
        private Individual.Visual.ComponentesMod.RJButton btnCerrar;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Edad;
    }
}