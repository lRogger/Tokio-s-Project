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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnRefrescar = new Button();
            usersDGV = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            buscarUser = new TextBox();
            separador = new Panel();
            btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDGV).BeginInit();
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
            // 
            // usersDGV
            // 
            usersDGV.AllowUserToAddRows = false;
            usersDGV.AllowUserToDeleteRows = false;
            usersDGV.AllowUserToResizeColumns = false;
            usersDGV.AllowUserToResizeRows = false;
            usersDGV.BackgroundColor = Color.White;
            usersDGV.BorderStyle = BorderStyle.None;
            usersDGV.CausesValidation = false;
            usersDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            usersDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            usersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            usersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Cedula, Nombre, Correo, Edad, Imagen });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            usersDGV.DefaultCellStyle = dataGridViewCellStyle2;
            usersDGV.EnableHeadersVisualStyles = false;
            usersDGV.GridColor = Color.FromArgb(64, 64, 64);
            usersDGV.ImeMode = ImeMode.NoControl;
            usersDGV.Location = new Point(100, 179);
            usersDGV.MultiSelect = false;
            usersDGV.Name = "usersDGV";
            usersDGV.ReadOnly = true;
            usersDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 51, 102);
            usersDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            usersDGV.RowTemplate.Height = 25;
            usersDGV.ScrollBars = ScrollBars.Vertical;
            usersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDGV.Size = new Size(537, 348);
            usersDGV.TabIndex = 11;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Cedula
            // 
            Cedula.Frozen = true;
            Cedula.HeaderText = "Cedula";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            Cedula.Width = 80;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 105;
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
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 50;
            // 
            // Imagen
            // 
            Imagen.Frozen = true;
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Width = 55;
            // 
            // buscarUser
            // 
            buscarUser.BackColor = Color.White;
            buscarUser.BorderStyle = BorderStyle.None;
            buscarUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buscarUser.Location = new Point(100, 147);
            buscarUser.Name = "buscarUser";
            buscarUser.PlaceholderText = " 🔎 Buscar...";
            buscarUser.Size = new Size(537, 22);
            buscarUser.TabIndex = 12;
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
            // 
            // MantenimientoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 650);
            Controls.Add(btnRefrescar);
            Controls.Add(usersDGV);
            Controls.Add(buscarUser);
            Controls.Add(separador);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoProveedor";
            Text = "MantenimientoProveedor";
            ((System.ComponentModel.ISupportInitialize)usersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        public DataGridView usersDGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewImageColumn Imagen;
        private TextBox buscarUser;
        private Panel separador;
        private Individual.Visual.ComponentesMod.RJButton btnCerrar;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
    }
}