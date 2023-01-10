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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productoDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.separador = new System.Windows.Forms.Panel();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            this.btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.productoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productoDGV
            // 
            this.productoDGV.AllowUserToAddRows = false;
            this.productoDGV.AllowUserToDeleteRows = false;
            this.productoDGV.AllowUserToResizeColumns = false;
            this.productoDGV.AllowUserToResizeRows = false;
            this.productoDGV.BackgroundColor = System.Drawing.Color.White;
            this.productoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productoDGV.CausesValidation = false;
            this.productoDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productoDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britanica-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Categoria,
            this.Talla,
            this.Color,
            this.Stock,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productoDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productoDGV.EnableHeadersVisualStyles = false;
            this.productoDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productoDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productoDGV.Location = new System.Drawing.Point(11, 125);
            this.productoDGV.MultiSelect = false;
            this.productoDGV.Name = "productoDGV";
            this.productoDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productoDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.productoDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productoDGV.RowTemplate.Height = 25;
            this.productoDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productoDGV.Size = new System.Drawing.Size(540, 295);
            this.productoDGV.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 190;
            // 
            // Categoria
            // 
            this.Categoria.Frozen = true;
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 70;
            // 
            // Talla
            // 
            this.Talla.Frozen = true;
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            this.Talla.Width = 40;
            // 
            // Color
            // 
            this.Color.Frozen = true;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 75;
            // 
            // Stock
            // 
            this.Stock.Frozen = true;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 45;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.BackColor = System.Drawing.Color.White;
            this.tbBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProducto.Location = new System.Drawing.Point(12, 97);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.PlaceholderText = " 🔎 Buscar...";
            this.tbBuscarProducto.Size = new System.Drawing.Size(350, 16);
            this.tbBuscarProducto.TabIndex = 12;
            this.tbBuscarProducto.TextChanged += new System.EventHandler(this.buscarProducto_TextChanged);
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.separador.Location = new System.Drawing.Point(12, 76);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(537, 2);
            this.separador.TabIndex = 17;
            // 
            // cbTalla
            // 
            this.cbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.Items.AddRange(new object[] {
            "Todas",
            "S",
            "M",
            "L",
            "XL"});
            this.cbTalla.Location = new System.Drawing.Point(416, 92);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(132, 23);
            this.cbTalla.TabIndex = 19;
            this.cbTalla.SelectedIndexChanged += new System.EventHandler(this.cbTalla_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(372, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tallas:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Britanica-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.Location = new System.Drawing.Point(182, 19);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(99, 43);
            this.btnRefrescar.TabIndex = 25;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Britanica-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnEliminar.Location = new System.Drawing.Point(287, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 43);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Britanica-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCrear.Location = new System.Drawing.Point(14, 19);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(76, 43);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Britanica-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnEditar.Location = new System.Drawing.Point(94, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 43);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbCantidad
            // 
            this.cbCantidad.Location = new System.Drawing.Point(428, 6);
            this.cbCantidad.Name = "cbCantidad";
            this.cbCantidad.Size = new System.Drawing.Size(45, 23);
            this.cbCantidad.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.btnMenos);
            this.panel1.Controls.Add(this.btnSuma);
            this.panel1.Controls.Add(this.cbCantidad);
            this.panel1.Location = new System.Drawing.Point(12, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 37);
            this.panel1.TabIndex = 27;
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenos.AutoSize = true;
            this.btnMenos.BackColor = System.Drawing.Color.Transparent;
            this.btnMenos.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMenos.BorderColor = System.Drawing.Color.White;
            this.btnMenos.BorderRadius = 0;
            this.btnMenos.BorderSize = 0;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.ForeColor = System.Drawing.Color.White;
            this.btnMenos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenos.Location = new System.Drawing.Point(381, 2);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMenos.Size = new System.Drawing.Size(43, 31);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "➖";
            this.btnMenos.TextColor = System.Drawing.Color.White;
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuma.BackColor = System.Drawing.Color.Transparent;
            this.btnSuma.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSuma.BorderColor = System.Drawing.Color.White;
            this.btnSuma.BorderRadius = 0;
            this.btnSuma.BorderSize = 0;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuma.Location = new System.Drawing.Point(483, 2);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSuma.Size = new System.Drawing.Size(32, 31);
            this.btnSuma.TabIndex = 28;
            this.btnSuma.Text = "➕";
            this.btnSuma.TextColor = System.Drawing.Color.White;
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(560, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTalla);
            this.Controls.Add(this.productoDGV);
            this.Controls.Add(this.tbBuscarProducto);
            this.Controls.Add(this.separador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MantenimientoProducto";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MantenimientoProducto_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.productoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DataGridView productoDGV;
        private TextBox tbBuscarProducto;
        private Panel separador;
        private ComboBox cbTalla;
        private Label label1;
        private Button btnRefrescar;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private NumericUpDown cbCantidad;
        private Panel panel1;
        private Individual.Visual.ComponentesMod.RJButton btnMenos;
        private Individual.Visual.ComponentesMod.RJButton btnSuma;
    }
}