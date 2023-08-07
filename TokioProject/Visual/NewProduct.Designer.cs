namespace GUIs.Visual
{
    partial class NewProduct
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
            lblTitulo = new Label();
            panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            tbStock = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            cbColor = new ComboBox();
            cbTalla = new ComboBox();
            tbDescrip = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbCateg = new ComboBox();
            label4 = new Label();
            tbPrecio = new CustomControls.RJControls.RJTextBox();
            tbNombreProd = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Individual.Visual.ComponentesMod.RJButton();
            btnCancelar = new Individual.Visual.ComponentesMod.RJButton();
            panelMod2 = new Individual.Visual.ComponentesMod.PanelMod();
            btnQuitar = new Individual.Visual.ComponentesMod.RJButton();
            cbInsumos = new ComboBox();
            cbCantidad = new NumericUpDown();
            btnAgregar = new Individual.Visual.ComponentesMod.RJButton();
            dgvInsumos = new DataGridView();
            IdInsumo = new DataGridViewTextBoxColumn();
            Insumo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            panelMod1.SuspendLayout();
            panelMod2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Britanica-Heavy", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(128, 27, 141);
            lblTitulo.Location = new Point(23, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Producto";
            // 
            // panelMod1
            // 
            panelMod1.BackColor = Color.White;
            panelMod1.BorderRadius = 40;
            panelMod1.Controls.Add(tbStock);
            panelMod1.Controls.Add(label1);
            panelMod1.Controls.Add(cbColor);
            panelMod1.Controls.Add(cbTalla);
            panelMod1.Controls.Add(tbDescrip);
            panelMod1.Controls.Add(label7);
            panelMod1.Controls.Add(label6);
            panelMod1.Controls.Add(label5);
            panelMod1.Controls.Add(cbCateg);
            panelMod1.Controls.Add(label4);
            panelMod1.Controls.Add(tbPrecio);
            panelMod1.Controls.Add(tbNombreProd);
            panelMod1.Controls.Add(label3);
            panelMod1.Controls.Add(label2);
            panelMod1.ForeColor = Color.Black;
            panelMod1.GradientAngle = 90F;
            panelMod1.GradientBottomColor = Color.White;
            panelMod1.GradientTopColor = Color.White;
            panelMod1.Location = new Point(23, 73);
            panelMod1.Name = "panelMod1";
            panelMod1.Size = new Size(500, 280);
            panelMod1.TabIndex = 1;
            // 
            // tbStock
            // 
            tbStock.BackColor = Color.White;
            tbStock.BorderColor = SystemColors.ActiveBorder;
            tbStock.BorderFocusColor = SystemColors.ActiveCaption;
            tbStock.BorderRadius = 10;
            tbStock.BorderSize = 1;
            tbStock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbStock.ForeColor = Color.FromArgb(64, 64, 64);
            tbStock.Location = new Point(404, 27);
            tbStock.Margin = new Padding(4);
            tbStock.Modified = false;
            tbStock.Multiline = false;
            tbStock.Name = "tbStock";
            tbStock.Padding = new Padding(10, 7, 10, 7);
            tbStock.PasswordChar = false;
            tbStock.PlaceholderColor = Color.DarkGray;
            tbStock.PlaceholderText = "";
            tbStock.Size = new Size(59, 31);
            tbStock.TabIndex = 13;
            tbStock.Texts = "";
            tbStock.UnderlinedStyle = false;
            tbStock.KeyPress += tbStock_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(354, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 12;
            label1.Text = "Stock:";
            // 
            // cbColor
            // 
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.FlatStyle = FlatStyle.System;
            cbColor.FormattingEnabled = true;
            cbColor.Items.AddRange(new object[] { "Negro", "Blanco", "Azul", "Amarillo", "Rojo", "Verde", "Morado", "Lila", "Marron", "Turquesa", "Fucsia" });
            cbColor.Location = new Point(367, 80);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(96, 23);
            cbColor.TabIndex = 11;
            // 
            // cbTalla
            // 
            cbTalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTalla.FlatStyle = FlatStyle.System;
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            cbTalla.Location = new Point(240, 80);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(67, 23);
            cbTalla.TabIndex = 10;
            // 
            // tbDescrip
            // 
            tbDescrip.BackColor = Color.White;
            tbDescrip.BorderColor = SystemColors.ActiveBorder;
            tbDescrip.BorderFocusColor = SystemColors.ActiveCaption;
            tbDescrip.BorderRadius = 10;
            tbDescrip.BorderSize = 1;
            tbDescrip.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescrip.ForeColor = Color.FromArgb(64, 64, 64);
            tbDescrip.Location = new Point(118, 128);
            tbDescrip.Margin = new Padding(4);
            tbDescrip.Modified = false;
            tbDescrip.Multiline = true;
            tbDescrip.Name = "tbDescrip";
            tbDescrip.Padding = new Padding(10, 7, 10, 7);
            tbDescrip.PasswordChar = false;
            tbDescrip.PlaceholderColor = Color.DarkGray;
            tbDescrip.PlaceholderText = "";
            tbDescrip.Size = new Size(345, 125);
            tbDescrip.TabIndex = 9;
            tbDescrip.Texts = "";
            tbDescrip.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(21, 128);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 8;
            label7.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(318, 82);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 7;
            label6.Text = "Color:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(198, 82);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 6;
            label5.Text = "Talla:";
            // 
            // cbCateg
            // 
            cbCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCateg.FlatStyle = FlatStyle.System;
            cbCateg.FormattingEnabled = true;
            cbCateg.Items.AddRange(new object[] { "Hombre", "Mujer", "Niño", "Niña" });
            cbCateg.Location = new Point(100, 80);
            cbCateg.Name = "cbCateg";
            cbCateg.Size = new Size(88, 23);
            cbCateg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(21, 82);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 4;
            label4.Text = "Categoría:";
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.White;
            tbPrecio.BorderColor = SystemColors.ActiveBorder;
            tbPrecio.BorderFocusColor = SystemColors.ActiveCaption;
            tbPrecio.BorderRadius = 10;
            tbPrecio.BorderSize = 1;
            tbPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            tbPrecio.Location = new Point(291, 27);
            tbPrecio.Margin = new Padding(4);
            tbPrecio.Modified = false;
            tbPrecio.Multiline = false;
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Padding = new Padding(10, 7, 10, 7);
            tbPrecio.PasswordChar = false;
            tbPrecio.PlaceholderColor = Color.DarkGray;
            tbPrecio.PlaceholderText = "";
            tbPrecio.Size = new Size(59, 31);
            tbPrecio.TabIndex = 3;
            tbPrecio.Texts = "";
            tbPrecio.UnderlinedStyle = false;
            tbPrecio.KeyPress += tbPrecio_KeyPress;
            // 
            // tbNombreProd
            // 
            tbNombreProd.BackColor = Color.White;
            tbNombreProd.BorderColor = SystemColors.ActiveBorder;
            tbNombreProd.BorderFocusColor = SystemColors.ActiveCaption;
            tbNombreProd.BorderRadius = 10;
            tbNombreProd.BorderSize = 1;
            tbNombreProd.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombreProd.ForeColor = Color.FromArgb(64, 64, 64);
            tbNombreProd.Location = new Point(86, 27);
            tbNombreProd.Margin = new Padding(4);
            tbNombreProd.Modified = false;
            tbNombreProd.Multiline = false;
            tbNombreProd.Name = "tbNombreProd";
            tbNombreProd.Padding = new Padding(10, 7, 10, 7);
            tbNombreProd.PasswordChar = false;
            tbNombreProd.PlaceholderColor = Color.DarkGray;
            tbNombreProd.PlaceholderText = "";
            tbNombreProd.Size = new Size(146, 31);
            tbNombreProd.TabIndex = 2;
            tbNombreProd.Texts = "";
            tbNombreProd.UnderlinedStyle = false;
            tbNombreProd.KeyPress += tbNombreProd_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(239, 33);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 15;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Britanica-Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(388, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BackgroundColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(128, 27, 141);
            btnCancelar.BorderRadius = 15;
            btnCancelar.BorderSize = 2;
            btnCancelar.DialogResult = DialogResult.Abort;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Britanica-Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(128, 27, 141);
            btnCancelar.Location = new Point(247, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.FromArgb(128, 27, 141);
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panelMod2
            // 
            panelMod2.BackColor = Color.White;
            panelMod2.BorderRadius = 40;
            panelMod2.Controls.Add(btnQuitar);
            panelMod2.Controls.Add(cbInsumos);
            panelMod2.Controls.Add(cbCantidad);
            panelMod2.Controls.Add(btnAgregar);
            panelMod2.Controls.Add(dgvInsumos);
            panelMod2.ForeColor = Color.Black;
            panelMod2.GradientAngle = 90F;
            panelMod2.GradientBottomColor = Color.White;
            panelMod2.GradientTopColor = Color.White;
            panelMod2.Location = new Point(552, 73);
            panelMod2.Name = "panelMod2";
            panelMod2.Size = new Size(244, 280);
            panelMod2.TabIndex = 14;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.MediumSlateBlue;
            btnQuitar.BackgroundColor = Color.MediumSlateBlue;
            btnQuitar.BorderColor = Color.PaleVioletRed;
            btnQuitar.BorderRadius = 0;
            btnQuitar.BorderSize = 0;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Location = new Point(136, 238);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(90, 28);
            btnQuitar.TabIndex = 34;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextColor = Color.White;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click_1;
            // 
            // cbInsumos
            // 
            cbInsumos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbInsumos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbInsumos.FormattingEnabled = true;
            cbInsumos.Location = new Point(24, 176);
            cbInsumos.Name = "cbInsumos";
            cbInsumos.Size = new Size(202, 23);
            cbInsumos.TabIndex = 33;
            cbInsumos.SelectedValueChanged += cbInsumos_SelectedValueChanged;
            cbInsumos.Enter += cbInsumos_Enter;
            // 
            // cbCantidad
            // 
            cbCantidad.Location = new Point(108, 205);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(45, 23);
            cbCantidad.TabIndex = 30;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 27, 141);
            btnAgregar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnAgregar.BorderColor = Color.PaleVioletRed;
            btnAgregar.BorderRadius = 15;
            btnAgregar.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Britanica-Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(24, 234);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 35);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToResizeColumns = false;
            dgvInsumos.AllowUserToResizeRows = false;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { IdInsumo, Insumo, Cantidad });
            dgvInsumos.Location = new Point(24, 25);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.RowHeadersVisible = false;
            dgvInsumos.RowTemplate.Height = 25;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(202, 136);
            dgvInsumos.TabIndex = 0;
            // 
            // IdInsumo
            // 
            IdInsumo.Frozen = true;
            IdInsumo.HeaderText = "ID";
            IdInsumo.Name = "IdInsumo";
            IdInsumo.ReadOnly = true;
            IdInsumo.Width = 26;
            // 
            // Insumo
            // 
            Insumo.Frozen = true;
            Insumo.HeaderText = "Insumo";
            Insumo.Name = "Insumo";
            Insumo.ReadOnly = true;
            Insumo.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.Frozen = true;
            Cantidad.HeaderText = "º";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 26;
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 430);
            Controls.Add(panelMod2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panelMod1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewProduct";
            MouseMove += NewProduct_MouseMove;
            panelMod1.ResumeLayout(false);
            panelMod1.PerformLayout();
            panelMod2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private Label label3;
        private Label label2;
        private Individual.Visual.ComponentesMod.RJButton btnGuardar;
        private Individual.Visual.ComponentesMod.RJButton btnCancelar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        public CustomControls.RJControls.RJTextBox tbPrecio;
        public CustomControls.RJControls.RJTextBox tbNombreProd;
        public CustomControls.RJControls.RJTextBox tbDescrip;
        public ComboBox cbCateg;
        public ComboBox cbColor;
        public ComboBox cbTalla;
        public CustomControls.RJControls.RJTextBox tbStock;
        public Label lblTitulo;
        private Individual.Visual.ComponentesMod.PanelMod panelMod2;
        private Individual.Visual.ComponentesMod.RJButton btnAgregar;
        private DataGridView dgvInsumos;
        private NumericUpDown cbCantidad;
        private ComboBox cbInsumos;
        private Individual.Visual.ComponentesMod.RJButton btnQuitar;
        private DataGridViewTextBoxColumn IdInsumo;
        private DataGridViewTextBoxColumn Insumo;
        private DataGridViewTextBoxColumn Cantidad;
    }
}