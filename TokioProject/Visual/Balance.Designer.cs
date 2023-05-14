namespace GUIs.Visual
{
    partial class Balance
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.productoDGV = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.separador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            this.btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.productoDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.AutoSize = true;
            this.btnRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.Location = new System.Drawing.Point(688, -1);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(60, 48);
            this.btnRefrescar.TabIndex = 34;
            this.btnRefrescar.Text = "🔄";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(443, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Periodo:";
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
            this.cbTalla.Location = new System.Drawing.Point(513, 65);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(220, 23);
            this.cbTalla.TabIndex = 29;
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
            this.Producto,
            this.Fecha,
            this.Valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britanica-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productoDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productoDGV.EnableHeadersVisualStyles = false;
            this.productoDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productoDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productoDGV.Location = new System.Drawing.Point(10, 98);
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
            this.productoDGV.Size = new System.Drawing.Size(722, 429);
            this.productoDGV.TabIndex = 26;
            // 
            // Producto
            // 
            this.Producto.Frozen = true;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 350;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 200;
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.BackColor = System.Drawing.Color.White;
            this.tbBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProducto.Location = new System.Drawing.Point(11, 67);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.PlaceholderText = " 🔎 Buscar...";
            this.tbBuscarProducto.Size = new System.Drawing.Size(404, 16);
            this.tbBuscarProducto.TabIndex = 27;
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.separador.Location = new System.Drawing.Point(11, 47);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(721, 2);
            this.separador.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblDetalle);
            this.panel1.Controls.Add(this.btnMenos);
            this.panel1.Controls.Add(this.btnSuma);
            this.panel1.Location = new System.Drawing.Point(12, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 105);
            this.panel1.TabIndex = 35;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Britanica-Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDesc.Location = new System.Drawing.Point(12, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 19);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Detalle";
            this.lblDesc.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.Font = new System.Drawing.Font("Britanica-Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDetalle.Location = new System.Drawing.Point(12, 28);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(699, 68);
            this.lblDetalle.TabIndex = 30;
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
            this.btnMenos.Location = new System.Drawing.Point(641, 19);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMenos.Size = new System.Drawing.Size(43, 31);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "➖";
            this.btnMenos.TextColor = System.Drawing.Color.White;
            this.btnMenos.UseVisualStyleBackColor = false;
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
            this.btnSuma.Location = new System.Drawing.Point(743, 19);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSuma.Size = new System.Drawing.Size(32, 31);
            this.btnSuma.TabIndex = 28;
            this.btnSuma.Text = "➕";
            this.btnSuma.TextColor = System.Drawing.Color.White;
            this.btnSuma.UseVisualStyleBackColor = false;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTalla);
            this.Controls.Add(this.productoDGV);
            this.Controls.Add(this.tbBuscarProducto);
            this.Controls.Add(this.separador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)(this.productoDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRefrescar;
        private Label label1;
        private ComboBox cbTalla;
        public DataGridView productoDGV;
        private TextBox tbBuscarProducto;
        private Panel separador;
        private Panel panel1;
        private Label lblDesc;
        private Label lblDetalle;
        private Individual.Visual.ComponentesMod.RJButton btnMenos;
        private Individual.Visual.ComponentesMod.RJButton btnSuma;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Valor;
    } 
}