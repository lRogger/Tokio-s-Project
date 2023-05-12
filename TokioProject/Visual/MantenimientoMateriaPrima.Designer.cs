﻿namespace GUIs.Visual
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
            tbBuscarProducto = new TextBox();
            separador = new Panel();
            cbProveedor = new ComboBox();
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
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            UltimaCompra = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            materiaPrimaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            materiaPrimaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiaPrimaDGV.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Proveedor, Stock, PrecioUnitario, UltimaCompra, Activo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            materiaPrimaDGV.DefaultCellStyle = dataGridViewCellStyle2;
            materiaPrimaDGV.EnableHeadersVisualStyles = false;
            materiaPrimaDGV.GridColor = Color.FromArgb(64, 64, 64);
            materiaPrimaDGV.ImeMode = ImeMode.NoControl;
            materiaPrimaDGV.Location = new Point(8, 116);
            materiaPrimaDGV.MultiSelect = false;
            materiaPrimaDGV.Name = "materiaPrimaDGV";
            materiaPrimaDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            materiaPrimaDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            materiaPrimaDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 51, 102);
            materiaPrimaDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            materiaPrimaDGV.RowTemplate.Height = 25;
            materiaPrimaDGV.ScrollBars = ScrollBars.Vertical;
            materiaPrimaDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiaPrimaDGV.Size = new Size(540, 286);
            materiaPrimaDGV.TabIndex = 11;
            materiaPrimaDGV.CellContentClick += materiaPrimaDGV_CellContentClick;
            materiaPrimaDGV.SelectionChanged += materiaPrimaDGV_SelectionChanged;
            // 
            // tbBuscarProducto
            // 
            tbBuscarProducto.BackColor = Color.White;
            tbBuscarProducto.BorderStyle = BorderStyle.None;
            tbBuscarProducto.Location = new Point(12, 83);
            tbBuscarProducto.Name = "tbBuscarProducto";
            tbBuscarProducto.PlaceholderText = " 🔎 Buscar...";
            tbBuscarProducto.Size = new Size(272, 16);
            tbBuscarProducto.TabIndex = 12;
            tbBuscarProducto.TextChanged += buscarProducto_TextChanged;
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(12, 64);
            separador.Name = "separador";
            separador.Size = new Size(537, 2);
            separador.TabIndex = 17;
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Items.AddRange(new object[] { "Todas", "S", "M", "L", "XL" });
            cbProveedor.Location = new Point(446, 80);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(105, 23);
            cbProveedor.TabIndex = 19;
            cbProveedor.SelectedIndexChanged += cbTalla_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(370, 83);
            label1.Name = "label1";
            label1.Size = new Size(74, 16);
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
            btnRefrescar.Location = new Point(506, 11);
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
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEliminar.Location = new Point(155, 14);
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
            btnCrear.BackColor = Color.Transparent;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.FromArgb(118, 27, 141);
            btnCrear.Location = new Point(9, 14);
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
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.FromArgb(118, 27, 141);
            btnEditar.Location = new Point(80, 14);
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
            panel1.BackColor = Color.FromArgb(128, 27, 141);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(btnMenos);
            panel1.Controls.Add(btnSuma);
            panel1.Controls.Add(cbCantidad);
            panel1.Location = new Point(12, 400);
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
            btnMenos.Location = new Point(381, 17);
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
            btnSuma.Location = new Point(483, 17);
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
            label2.Location = new Point(440, 92);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 28;
            // 
            // cbInactivo
            // 
            cbInactivo.CheckAlign = ContentAlignment.MiddleRight;
            cbInactivo.Cursor = Cursors.IBeam;
            cbInactivo.FlatAppearance.CheckedBackColor = Color.Indigo;
            cbInactivo.FlatStyle = FlatStyle.Flat;
            cbInactivo.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cbInactivo.ForeColor = SystemColors.ControlDarkDark;
            cbInactivo.Location = new Point(281, 80);
            cbInactivo.Name = "cbInactivo";
            cbInactivo.Size = new Size(83, 23);
            cbInactivo.TabIndex = 29;
            cbInactivo.Text = "Inactivos";
            cbInactivo.TextAlign = ContentAlignment.MiddleRight;
            cbInactivo.UseVisualStyleBackColor = true;
            cbInactivo.CheckedChanged += cbInactivo_CheckedChanged;
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
            Nombre.Width = 140;
            // 
            // Proveedor
            // 
            Proveedor.Frozen = true;
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Width = 140;
            // 
            // Stock
            // 
            Stock.Frozen = true;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 45;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.Frozen = true;
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Width = 80;
            // 
            // UltimaCompra
            // 
            UltimaCompra.Frozen = true;
            UltimaCompra.HeaderText = "Última Compra";
            UltimaCompra.Name = "UltimaCompra";
            UltimaCompra.ReadOnly = true;
            UltimaCompra.Width = 80;
            // 
            // Activo
            // 
            Activo.HeaderText = "";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            Activo.Resizable = DataGridViewTriState.False;
            Activo.Visible = false;
            // 
            // MantenimientoMateriaPrima
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(560, 470);
            Controls.Add(cbInactivo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnRefrescar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(cbProveedor);
            Controls.Add(materiaPrimaDGV);
            Controls.Add(tbBuscarProducto);
            Controls.Add(separador);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoMateriaPrima";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MantenimientoProducto";
            MouseMove += MantenimientoProducto_MouseMove;
            ((System.ComponentModel.ISupportInitialize)materiaPrimaDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView materiaPrimaDGV;
        private TextBox tbBuscarProducto;
        private Panel separador;
        private ComboBox cbProveedor;
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
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn UltimaCompra;
        private DataGridViewTextBoxColumn Activo;
    }
}