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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRefrescar = new Button();
            label1 = new Label();
            cbTalla = new ComboBox();
            productoDGV = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            tbBuscarProducto = new TextBox();
            separador = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)productoDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnRefrescar.Location = new Point(686, 1);
            btnRefrescar.Margin = new Padding(0);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(60, 48);
            btnRefrescar.TabIndex = 34;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(443, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 30;
            label1.Text = "Periodo:";
            // 
            // cbTalla
            // 
            cbTalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "Todas", "S", "M", "L", "XL" });
            cbTalla.Location = new Point(513, 65);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(220, 23);
            cbTalla.TabIndex = 29;
            // 
            // productoDGV
            // 
            productoDGV.AllowUserToAddRows = false;
            productoDGV.AllowUserToDeleteRows = false;
            productoDGV.AllowUserToResizeColumns = false;
            productoDGV.AllowUserToResizeRows = false;
            productoDGV.BackgroundColor = Color.White;
            productoDGV.BorderStyle = BorderStyle.None;
            productoDGV.CausesValidation = false;
            productoDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productoDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productoDGV.Columns.AddRange(new DataGridViewColumn[] { Producto, Fecha, Valor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productoDGV.DefaultCellStyle = dataGridViewCellStyle2;
            productoDGV.EnableHeadersVisualStyles = false;
            productoDGV.GridColor = Color.FromArgb(64, 64, 64);
            productoDGV.ImeMode = ImeMode.NoControl;
            productoDGV.Location = new Point(10, 98);
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
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 51, 102);
            productoDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            productoDGV.RowTemplate.Height = 25;
            productoDGV.ScrollBars = ScrollBars.Vertical;
            productoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productoDGV.Size = new Size(722, 487);
            productoDGV.TabIndex = 26;
            // 
            // Producto
            // 
            Producto.Frozen = true;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 350;
            // 
            // Fecha
            // 
            Fecha.Frozen = true;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 200;
            // 
            // Valor
            // 
            Valor.Frozen = true;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 200;
            // 
            // tbBuscarProducto
            // 
            tbBuscarProducto.BackColor = Color.White;
            tbBuscarProducto.BorderStyle = BorderStyle.None;
            tbBuscarProducto.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarProducto.Location = new Point(11, 64);
            tbBuscarProducto.Name = "tbBuscarProducto";
            tbBuscarProducto.PlaceholderText = " 🔎 Buscar...";
            tbBuscarProducto.Size = new Size(426, 20);
            tbBuscarProducto.TabIndex = 27;
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(11, 47);
            separador.Name = "separador";
            separador.Size = new Size(721, 2);
            separador.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 27, 141);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 47);
            panel1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 0;
            label2.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Britanica-Bold", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(626, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 32);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "00.00";
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 650);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cbTalla);
            Controls.Add(productoDGV);
            Controls.Add(tbBuscarProducto);
            Controls.Add(separador);
            Controls.Add(btnRefrescar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)productoDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        private Label label1;
        private ComboBox cbTalla;
        public DataGridView productoDGV;
        private TextBox tbBuscarProducto;
        private Panel separador;
        private Panel panel1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Valor;
        private Label lblTotal;
        private Label label2;
    }
}