namespace Individual.Visual
{
    partial class MantenimientoUsuario
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
            buscarUser = new TextBox();
            usersDGV = new DataGridView();
            btnEditar = new Button();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnCerrar = new ComponentesMod.RJButton();
            separador = new Panel();
            btnRefrescar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)usersDGV).BeginInit();
            SuspendLayout();
            // 
            // buscarUser
            // 
            buscarUser.BackColor = Color.White;
            buscarUser.BorderStyle = BorderStyle.None;
            buscarUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buscarUser.Location = new Point(12, 66);
            buscarUser.Name = "buscarUser";
            buscarUser.PlaceholderText = " 🔎 Buscar...";
            buscarUser.Size = new Size(721, 22);
            buscarUser.TabIndex = 1;
            buscarUser.TextChanged += buscarUser_TextChanged;
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
            usersDGV.Location = new Point(12, 99);
            usersDGV.MultiSelect = false;
            usersDGV.Name = "usersDGV";
            usersDGV.ReadOnly = true;
            usersDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 51, 102);
            usersDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            usersDGV.RowTemplate.Height = 25;
            usersDGV.ScrollBars = ScrollBars.Vertical;
            usersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDGV.Size = new Size(721, 539);
            usersDGV.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEditar.Location = new Point(75, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 43);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += editar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.FromArgb(118, 27, 141);
            btnCrear.Location = new Point(9, 9);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(76, 43);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += crear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEliminar.Location = new Point(150, 9);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 43);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += eliminar_Click;
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
            btnCerrar.Location = new Point(635, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 33);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(12, 51);
            separador.Name = "separador";
            separador.Size = new Size(721, 2);
            separador.TabIndex = 9;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Transparent;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.ForeColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.Location = new Point(585, 0);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(50, 56);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
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
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Correo
            // 
            Correo.Frozen = true;
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 200;
            // 
            // Edad
            // 
            Edad.Frozen = true;
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 60;
            // 
            // Imagen
            // 
            Imagen.Frozen = true;
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Width = 60;
            // 
            // MantenimientoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(744, 650);
            Controls.Add(usersDGV);
            Controls.Add(buscarUser);
            Controls.Add(separador);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            Controls.Add(btnRefrescar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoUsuario";
            MouseMove += MantenimientoUsuario_MouseMove;
            ((System.ComponentModel.ISupportInitialize)usersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox buscarUser;
        private Button btnEditar;
        private Button btnCrear;
        private Button btnEliminar;
        public DataGridView usersDGV;
        private ComponentesMod.RJButton btnCerrar;
        private Panel separador;
        private Button btnRefrescar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewImageColumn Imagen;
    }
}