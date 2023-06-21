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
            balanceDGV = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            tbBuscar = new TextBox();
            separador = new Panel();
            panel1 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            dtpFechaFin = new DateTimePicker();
            chkInhabilitar = new CheckBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)balanceDGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(297, 65);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 30;
            label1.Text = "Desde:";
            // 
            // balanceDGV
            // 
            balanceDGV.AllowUserToAddRows = false;
            balanceDGV.AllowUserToDeleteRows = false;
            balanceDGV.AllowUserToResizeColumns = false;
            balanceDGV.AllowUserToResizeRows = false;
            balanceDGV.BackgroundColor = Color.White;
            balanceDGV.BorderStyle = BorderStyle.None;
            balanceDGV.CausesValidation = false;
            balanceDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            balanceDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            balanceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            balanceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            balanceDGV.Columns.AddRange(new DataGridViewColumn[] { Producto, Fecha, Valor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            balanceDGV.DefaultCellStyle = dataGridViewCellStyle2;
            balanceDGV.EnableHeadersVisualStyles = false;
            balanceDGV.GridColor = Color.FromArgb(64, 64, 64);
            balanceDGV.ImeMode = ImeMode.NoControl;
            balanceDGV.Location = new Point(10, 99);
            balanceDGV.MultiSelect = false;
            balanceDGV.Name = "balanceDGV";
            balanceDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            balanceDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            balanceDGV.RowHeadersWidth = 4;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 51, 102);
            balanceDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            balanceDGV.RowTemplate.Height = 25;
            balanceDGV.ScrollBars = ScrollBars.Vertical;
            balanceDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            balanceDGV.Size = new Size(722, 476);
            balanceDGV.TabIndex = 26;
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
            // tbBuscar
            // 
            tbBuscar.BackColor = Color.White;
            tbBuscar.BorderStyle = BorderStyle.None;
            tbBuscar.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscar.Location = new Point(11, 64);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = " 🔎 Buscar...";
            tbBuscar.Size = new Size(280, 20);
            tbBuscar.TabIndex = 27;
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 588);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 47);
            panel1.TabIndex = 35;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Britanica-Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(128, 27, 141);
            lblTotal.Location = new Point(626, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 32);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "00.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britanica-Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 27, 141);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 0;
            label2.Text = "TOTAL";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarFont = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInicio.CalendarTitleBackColor = Color.Purple;
            dtpFechaInicio.Cursor = Cursors.Hand;
            dtpFechaInicio.DropDownAlign = LeftRightAlignment.Right;
            dtpFechaInicio.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(353, 62);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.RightToLeft = RightToLeft.Yes;
            dtpFechaInicio.Size = new Size(117, 25);
            dtpFechaInicio.TabIndex = 36;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(475, 65);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 37;
            label3.Text = "Hasta:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarFont = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaFin.CalendarTitleBackColor = Color.Purple;
            dtpFechaFin.Cursor = Cursors.Hand;
            dtpFechaFin.Font = new Font("Britanica-Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(527, 62);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(114, 25);
            dtpFechaFin.TabIndex = 38;
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // chkInhabilitar
            // 
            chkInhabilitar.AutoSize = true;
            chkInhabilitar.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            chkInhabilitar.ForeColor = SystemColors.Control;
            chkInhabilitar.Location = new Point(6, 2);
            chkInhabilitar.Name = "chkInhabilitar";
            chkInhabilitar.Size = new Size(70, 23);
            chkInhabilitar.TabIndex = 39;
            chkInhabilitar.Text = "Todos";
            chkInhabilitar.UseVisualStyleBackColor = true;
            chkInhabilitar.CheckedChanged += chkInhabilitar_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Purple;
            panel2.Controls.Add(chkInhabilitar);
            panel2.Location = new Point(650, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 26);
            panel2.TabIndex = 40;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 650);
            Controls.Add(panel2);
            Controls.Add(dtpFechaFin);
            Controls.Add(label3);
            Controls.Add(dtpFechaInicio);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(balanceDGV);
            Controls.Add(tbBuscar);
            Controls.Add(separador);
            Controls.Add(btnRefrescar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)balanceDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrescar;
        private Label label1;
        public DataGridView balanceDGV;
        private TextBox tbBuscar;
        private Panel separador;
        private Panel panel1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Valor;
        private Label lblTotal;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private CheckBox chkInhabilitar;
        private Panel panel2;
    }
}