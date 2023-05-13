namespace GUIs.Visual
{
    partial class MantenimientoProducto
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            productoDGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            tbBuscarProducto = new TextBox();
            separador = new Panel();
            cbTalla = new ComboBox();
            label1 = new Label();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            cbCantidad = new NumericUpDown();
            panel1 = new Panel();
            lblDesc = new Label();
            lblDescripcion = new Label();
            btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            label2 = new Label();
            cbInactivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)productoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productoDGV
            // 
            productoDGV.AllowUserToAddRows = false;
            productoDGV.AllowUserToDeleteRows = false;
            productoDGV.AllowUserToResizeColumns = false;
            productoDGV.AllowUserToResizeRows = false;
            productoDGV.BackgroundColor = System.Drawing.Color.White;
            productoDGV.BorderStyle = BorderStyle.None;
            productoDGV.CausesValidation = false;
            productoDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productoDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productoDGV.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, Talla, Color, Stock, Precio, Activo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productoDGV.DefaultCellStyle = dataGridViewCellStyle2;
            productoDGV.EnableHeadersVisualStyles = false;
            productoDGV.GridColor = System.Drawing.Color.FromArgb(64, 64, 64);
            productoDGV.ImeMode = ImeMode.NoControl;
            productoDGV.Location = new Point(77, 191);
            productoDGV.MultiSelect = false;
            productoDGV.Name = "productoDGV";
            productoDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productoDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(51, 51, 102);
            productoDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            productoDGV.RowTemplate.Height = 25;
            productoDGV.ScrollBars = ScrollBars.Vertical;
            productoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productoDGV.Size = new Size(540, 286);
            productoDGV.TabIndex = 11;
            productoDGV.SelectionChanged += productoDGV_SelectionChanged;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 190;
            // 
            // Categoria
            // 
            Categoria.Frozen = true;
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 70;
            // 
            // Talla
            // 
            Talla.Frozen = true;
            Talla.HeaderText = "Talla";
            Talla.Name = "Talla";
            Talla.ReadOnly = true;
            Talla.Width = 40;
            // 
            // Color
            // 
            Color.Frozen = true;
            Color.HeaderText = "Color";
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.Width = 75;
            // 
            // Stock
            // 
            Stock.Frozen = true;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 45;
            // 
            // Precio
            // 
            Precio.Frozen = true;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 80;
            // 
            // Activo
            // 
            Activo.HeaderText = "";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            Activo.Resizable = DataGridViewTriState.False;
            Activo.Visible = false;
            // 
            // tbBuscarProducto
            // 
            tbBuscarProducto.BackColor = System.Drawing.Color.White;
            tbBuscarProducto.BorderStyle = BorderStyle.None;
            tbBuscarProducto.Location = new Point(78, 159);
            tbBuscarProducto.Name = "tbBuscarProducto";
            tbBuscarProducto.PlaceholderText = " 🔎 Buscar...";
            tbBuscarProducto.Size = new Size(272, 16);
            tbBuscarProducto.TabIndex = 12;
            tbBuscarProducto.TextChanged += buscarProducto_TextChanged;
            // 
            // separador
            // 
            separador.BackColor = System.Drawing.Color.FromArgb(70, 15, 75);
            separador.Location = new Point(78, 140);
            separador.Name = "separador";
            separador.Size = new Size(537, 2);
            separador.TabIndex = 17;
            // 
            // cbTalla
            // 
            cbTalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "Todas", "S", "M", "L", "XL" });
            cbTalla.Location = new Point(526, 156);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(91, 23);
            cbTalla.TabIndex = 19;
            cbTalla.SelectedIndexChanged += cbTalla_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(482, 159);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 20;
            label1.Text = "Tallas:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.AutoSize = true;
            btnRefrescar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 15, 75);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Arial", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(70, 15, 75);
            btnRefrescar.Location = new Point(572, 87);
            btnRefrescar.Margin = new Padding(0);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(60, 48);
            btnRefrescar.TabIndex = 25;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AllowDrop = true;
            btnEliminar.BackColor = System.Drawing.Color.Transparent;
            btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 15, 75);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = System.Drawing.Color.FromArgb(118, 27, 141);
            btnEliminar.Location = new Point(221, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 43);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Inhabilitar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.AllowDrop = true;
            btnCrear.BackColor = System.Drawing.Color.Transparent;
            btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 15, 75);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = System.Drawing.Color.FromArgb(118, 27, 141);
            btnCrear.Location = new Point(75, 90);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(67, 43);
            btnCrear.TabIndex = 22;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.AllowDrop = true;
            btnEditar.BackColor = System.Drawing.Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 15, 75);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = System.Drawing.Color.FromArgb(118, 27, 141);
            btnEditar.Location = new Point(146, 90);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 43);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cbCantidad
            // 
            cbCantidad.Location = new Point(428, 21);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(45, 23);
            cbCantidad.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(128, 27, 141);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(btnMenos);
            panel1.Controls.Add(btnSuma);
            panel1.Controls.Add(cbCantidad);
            panel1.Location = new Point(78, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 61);
            panel1.TabIndex = 27;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = SystemColors.Window;
            lblDesc.Location = new Point(6, 5);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(92, 20);
            lblDesc.TabIndex = 31;
            lblDesc.Text = "Descripción";
            lblDesc.Visible = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = SystemColors.Window;
            lblDescripcion.Location = new Point(7, 24);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(372, 37);
            lblDescripcion.TabIndex = 30;
            // 
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.None;
            btnMenos.AutoSize = true;
            btnMenos.BackColor = System.Drawing.Color.Transparent;
            btnMenos.BackgroundColor = System.Drawing.Color.Transparent;
            btnMenos.BorderColor = System.Drawing.Color.White;
            btnMenos.BorderRadius = 0;
            btnMenos.BorderSize = 0;
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = System.Drawing.Color.White;
            btnMenos.ImageAlign = ContentAlignment.TopCenter;
            btnMenos.Location = new Point(381, 17);
            btnMenos.Margin = new Padding(0);
            btnMenos.Name = "btnMenos";
            btnMenos.RightToLeft = RightToLeft.Yes;
            btnMenos.Size = new Size(43, 31);
            btnMenos.TabIndex = 29;
            btnMenos.Text = "➖";
            btnMenos.TextColor = System.Drawing.Color.White;
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnSuma
            // 
            btnSuma.Anchor = AnchorStyles.None;
            btnSuma.BackColor = System.Drawing.Color.Transparent;
            btnSuma.BackgroundColor = System.Drawing.Color.Transparent;
            btnSuma.BorderColor = System.Drawing.Color.White;
            btnSuma.BorderRadius = 0;
            btnSuma.BorderSize = 0;
            btnSuma.FlatAppearance.BorderSize = 0;
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.ForeColor = System.Drawing.Color.White;
            btnSuma.ImageAlign = ContentAlignment.TopCenter;
            btnSuma.Location = new Point(483, 17);
            btnSuma.Margin = new Padding(0);
            btnSuma.Name = "btnSuma";
            btnSuma.RightToLeft = RightToLeft.Yes;
            btnSuma.Size = new Size(32, 31);
            btnSuma.TabIndex = 28;
            btnSuma.Text = "➕";
            btnSuma.TextColor = System.Drawing.Color.White;
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(506, 168);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 28;
            // 
            // cbInactivo
            // 
            cbInactivo.CheckAlign = ContentAlignment.MiddleRight;
            cbInactivo.Cursor = Cursors.IBeam;
            cbInactivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            cbInactivo.FlatStyle = FlatStyle.Flat;
            cbInactivo.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cbInactivo.ForeColor = SystemColors.ControlDarkDark;
            cbInactivo.Location = new Point(377, 156);
            cbInactivo.Name = "cbInactivo";
            cbInactivo.Size = new Size(98, 23);
            cbInactivo.TabIndex = 29;
            cbInactivo.Text = "Inactivos";
            cbInactivo.TextAlign = ContentAlignment.MiddleRight;
            cbInactivo.UseVisualStyleBackColor = true;
            cbInactivo.CheckedChanged += cbInactivo_CheckedChanged;
            // 
            // MantenimientoProducto
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            ClientSize = new Size(744, 650);
            Controls.Add(cbInactivo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnRefrescar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(cbTalla);
            Controls.Add(productoDGV);
            Controls.Add(tbBuscarProducto);
            Controls.Add(separador);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoProducto";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MantenimientoProducto";
            MouseMove += MantenimientoProducto_MouseMove;
            ((System.ComponentModel.ISupportInitialize)productoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView productoDGV;
        private TextBox tbBuscarProducto;
        private Panel separador;
        private ComboBox cbTalla;
        private Label label1;
        private Button btnRefrescar;
        private Button btnEliminar;
        private Button btnEditar;
        private NumericUpDown cbCantidad;
        private Panel panel1;
        private Individual.Visual.ComponentesMod.RJButton btnMenos;
        private Individual.Visual.ComponentesMod.RJButton btnSuma;
        private Label lblDescripcion;
        private Label lblDesc;
        private Label label2;
        public CheckBox cbInactivo;
        public Button btnCrear;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Activo;
    }
}