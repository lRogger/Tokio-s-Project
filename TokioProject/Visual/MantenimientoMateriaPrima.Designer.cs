namespace GUIs.Visual
{
    partial class MantenimientoMateriaPrima
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
            materiaPrimaDGV = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre_categoria = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            fecha_compra = new DataGridViewTextBoxColumn();
            buscarMateriaPrima = new TextBox();
            separador = new Panel();
            cbProveedor = new ComboBox();
            label1 = new Label();
            btnRefrescar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            cbCantidad = new NumericUpDown();
            panel1 = new Panel();
            lblMedida = new Label();
            lblDesc = new Label();
            lblDescripcion = new Label();
            btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            label2 = new Label();
            label3 = new Label();
            cbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)materiaPrimaDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materiaPrimaDGV
            // 
            materiaPrimaDGV.AllowUserToAddRows = false;
            materiaPrimaDGV.AllowUserToDeleteRows = false;
            materiaPrimaDGV.AllowUserToResizeColumns = false;
            materiaPrimaDGV.AllowUserToResizeRows = false;
            materiaPrimaDGV.BackgroundColor = Color.White;
            materiaPrimaDGV.BorderStyle = BorderStyle.None;
            materiaPrimaDGV.CausesValidation = false;
            materiaPrimaDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            materiaPrimaDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            materiaPrimaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            materiaPrimaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiaPrimaDGV.Columns.AddRange(new DataGridViewColumn[] { id, nombre_categoria, color, stock, proveedor, precio, fecha_compra });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            materiaPrimaDGV.DefaultCellStyle = dataGridViewCellStyle2;
            materiaPrimaDGV.EnableHeadersVisualStyles = false;
            materiaPrimaDGV.GridColor = Color.FromArgb(64, 64, 64);
            materiaPrimaDGV.ImeMode = ImeMode.NoControl;
            materiaPrimaDGV.Location = new Point(12, 99);
            materiaPrimaDGV.MultiSelect = false;
            materiaPrimaDGV.Name = "materiaPrimaDGV";
            materiaPrimaDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Britanica-Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            materiaPrimaDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            materiaPrimaDGV.RowHeadersVisible = false;
            materiaPrimaDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 51, 102);
            materiaPrimaDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            materiaPrimaDGV.RowTemplate.Height = 25;
            materiaPrimaDGV.ScrollBars = ScrollBars.Vertical;
            materiaPrimaDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiaPrimaDGV.Size = new Size(720, 472);
            materiaPrimaDGV.TabIndex = 11;
            materiaPrimaDGV.CellClick += materiaPrimaDGV_CellClick;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 30;
            // 
            // nombre_categoria
            // 
            nombre_categoria.Frozen = true;
            nombre_categoria.HeaderText = "Categoria";
            nombre_categoria.Name = "nombre_categoria";
            nombre_categoria.ReadOnly = true;
            nombre_categoria.Resizable = DataGridViewTriState.False;
            nombre_categoria.Width = 150;
            // 
            // color
            // 
            color.Frozen = true;
            color.HeaderText = "Color";
            color.Name = "color";
            color.ReadOnly = true;
            color.Resizable = DataGridViewTriState.False;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Resizable = DataGridViewTriState.False;
            stock.Width = 50;
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            proveedor.ReadOnly = true;
            proveedor.Resizable = DataGridViewTriState.False;
            proveedor.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Total";
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Resizable = DataGridViewTriState.False;
            // 
            // fecha_compra
            // 
            fecha_compra.HeaderText = "Ultima Compra";
            fecha_compra.Name = "fecha_compra";
            fecha_compra.ReadOnly = true;
            fecha_compra.Resizable = DataGridViewTriState.False;
            fecha_compra.Width = 150;
            // 
            // buscarMateriaPrima
            // 
            buscarMateriaPrima.BackColor = Color.White;
            buscarMateriaPrima.BorderStyle = BorderStyle.None;
            buscarMateriaPrima.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buscarMateriaPrima.Location = new Point(12, 66);
            buscarMateriaPrima.Name = "buscarMateriaPrima";
            buscarMateriaPrima.PlaceholderText = " 🔎 Buscar...";
            buscarMateriaPrima.Size = new Size(294, 20);
            buscarMateriaPrima.TabIndex = 12;
            buscarMateriaPrima.TextChanged += buscarMateriaPrima_TextChanged_1;
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(12, 51);
            separador.Name = "separador";
            separador.Size = new Size(720, 2);
            separador.TabIndex = 17;
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.Font = new Font("Britanica-Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(592, 64);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(140, 23);
            cbProveedor.TabIndex = 19;
            cbProveedor.SelectedIndexChanged += cbProveedor_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(507, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 20;
            label1.Text = "Proveedor:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.AutoSize = true;
            btnRefrescar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefrescar.BackColor = Color.Transparent;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Arial", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.ForeColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.Location = new Point(681, 1);
            btnRefrescar.Margin = new Padding(0);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(60, 48);
            btnRefrescar.TabIndex = 25;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnCrear
            // 
            btnCrear.AllowDrop = true;
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.FromArgb(118, 27, 141);
            btnCrear.Location = new Point(9, 7);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(89, 43);
            btnCrear.TabIndex = 22;
            btnCrear.Text = "Agregar";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.AllowDrop = true;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEditar.Location = new Point(102, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 43);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cbCantidad
            // 
            cbCantidad.Location = new Point(614, 21);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(45, 23);
            cbCantidad.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 27, 141);
            panel1.Controls.Add(lblMedida);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(btnMenos);
            panel1.Controls.Add(btnSuma);
            panel1.Controls.Add(cbCantidad);
            panel1.Location = new Point(12, 577);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 69);
            panel1.TabIndex = 27;
            // 
            // lblMedida
            // 
            lblMedida.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedida.ForeColor = SystemColors.Window;
            lblMedida.Location = new Point(3, 47);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(122, 22);
            lblMedida.TabIndex = 33;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Britanica-Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = SystemColors.Window;
            lblDesc.Location = new Point(3, 2);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(92, 19);
            lblDesc.TabIndex = 32;
            lblDesc.Text = "Descripción";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = SystemColors.Window;
            lblDescripcion.Location = new Point(3, 21);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(122, 23);
            lblDescripcion.TabIndex = 31;
            // 
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.None;
            btnMenos.AutoSize = true;
            btnMenos.BackColor = Color.Transparent;
            btnMenos.BackgroundColor = Color.Transparent;
            btnMenos.BorderColor = Color.White;
            btnMenos.BorderRadius = 0;
            btnMenos.BorderSize = 0;
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = Color.White;
            btnMenos.ImageAlign = ContentAlignment.TopCenter;
            btnMenos.Location = new Point(565, 17);
            btnMenos.Margin = new Padding(0);
            btnMenos.Name = "btnMenos";
            btnMenos.RightToLeft = RightToLeft.Yes;
            btnMenos.Size = new Size(43, 31);
            btnMenos.TabIndex = 29;
            btnMenos.Text = "➖";
            btnMenos.TextColor = Color.White;
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnSuma
            // 
            btnSuma.Anchor = AnchorStyles.None;
            btnSuma.BackColor = Color.Transparent;
            btnSuma.BackgroundColor = Color.Transparent;
            btnSuma.BorderColor = Color.White;
            btnSuma.BorderRadius = 0;
            btnSuma.BorderSize = 0;
            btnSuma.FlatAppearance.BorderSize = 0;
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.ForeColor = Color.White;
            btnSuma.ImageAlign = ContentAlignment.TopCenter;
            btnSuma.Location = new Point(667, 16);
            btnSuma.Margin = new Padding(0);
            btnSuma.Name = "btnSuma";
            btnSuma.RightToLeft = RightToLeft.Yes;
            btnSuma.Size = new Size(32, 31);
            btnSuma.TabIndex = 28;
            btnSuma.Text = "➕";
            btnSuma.TextColor = Color.White;
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(526, 163);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(312, 67);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 30;
            label3.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Britanica-Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(393, 64);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(112, 23);
            cbCategoria.TabIndex = 29;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // MantenimientoMateriaPrima
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(744, 650);
            Controls.Add(label3);
            Controls.Add(cbCategoria);
            Controls.Add(materiaPrimaDGV);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnRefrescar);
            Controls.Add(label1);
            Controls.Add(cbProveedor);
            Controls.Add(buscarMateriaPrima);
            Controls.Add(separador);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoMateriaPrima";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MantenimientoProducto";
            ((System.ComponentModel.ISupportInitialize)materiaPrimaDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView materiaPrimaDGV;
        private TextBox buscarMateriaPrima;
        private Panel separador;
        private ComboBox cbProveedor;
        private Label label1;
        private Button btnRefrescar;
        private Button btnEditar;
        private NumericUpDown cbCantidad;
        private Panel panel1;
        private Individual.Visual.ComponentesMod.RJButton btnMenos;
        private Individual.Visual.ComponentesMod.RJButton btnSuma;
        private Label label2;
        public Button btnCrear;
        private Label lblDescripcion;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre_categoria;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn fecha_compra;
        private Label lblDesc;
        private Label label3;
        private ComboBox cbCategoria;
        private Label lblMedida;
    }
}