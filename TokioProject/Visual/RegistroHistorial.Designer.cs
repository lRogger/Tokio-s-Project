namespace GUIs.Visual
{
    partial class RegistroHistorial
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
            label1 = new Label();
            separador = new Panel();
            btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            btnRefrescar = new Button();
            registrosDGV = new DataGridView();
            tbBuscarRegistro = new TextBox();
            btnDescripcion = new Individual.Visual.ComponentesMod.RJButton();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)registrosDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Heavy", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(118, 27, 141);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 45);
            label1.TabIndex = 0;
            label1.Text = "Historial";
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(22, 60);
            separador.Name = "separador";
            separador.Size = new Size(709, 2);
            separador.TabIndex = 18;
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
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Transparent;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.ForeColor = Color.FromArgb(70, 15, 75);
            btnRefrescar.Location = new Point(582, 5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(50, 48);
            btnRefrescar.TabIndex = 20;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // registrosDGV
            // 
            registrosDGV.AllowUserToAddRows = false;
            registrosDGV.AllowUserToDeleteRows = false;
            registrosDGV.AllowUserToResizeColumns = false;
            registrosDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            registrosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            registrosDGV.BackgroundColor = Color.White;
            registrosDGV.BorderStyle = BorderStyle.None;
            registrosDGV.CausesValidation = false;
            registrosDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            registrosDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle2.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            registrosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            registrosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrosDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Encargado, Producto, Cantidad });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Britanica-Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            registrosDGV.DefaultCellStyle = dataGridViewCellStyle3;
            registrosDGV.EnableHeadersVisualStyles = false;
            registrosDGV.GridColor = Color.FromArgb(64, 64, 64);
            registrosDGV.ImeMode = ImeMode.NoControl;
            registrosDGV.Location = new Point(22, 105);
            registrosDGV.MultiSelect = false;
            registrosDGV.Name = "registrosDGV";
            registrosDGV.ReadOnly = true;
            registrosDGV.RowHeadersVisible = false;
            registrosDGV.RowHeadersWidth = 4;
            registrosDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 51, 102);
            registrosDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            registrosDGV.RowTemplate.Height = 25;
            registrosDGV.ScrollBars = ScrollBars.Vertical;
            registrosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            registrosDGV.Size = new Size(709, 497);
            registrosDGV.TabIndex = 21;
            registrosDGV.SelectionChanged += registrosDGV_SelectionChanged;
            // 
            // tbBuscarRegistro
            // 
            tbBuscarRegistro.BackColor = Color.White;
            tbBuscarRegistro.BorderStyle = BorderStyle.None;
            tbBuscarRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarRegistro.Location = new Point(22, 72);
            tbBuscarRegistro.Name = "tbBuscarRegistro";
            tbBuscarRegistro.PlaceholderText = " 🔎 Buscar...";
            tbBuscarRegistro.Size = new Size(710, 22);
            tbBuscarRegistro.TabIndex = 22;
            tbBuscarRegistro.TextChanged += buscarUser_TextChanged;
            // 
            // btnDescripcion
            // 
            btnDescripcion.BackColor = Color.FromArgb(128, 27, 141);
            btnDescripcion.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnDescripcion.BorderColor = Color.Transparent;
            btnDescripcion.BorderRadius = 10;
            btnDescripcion.BorderSize = 0;
            btnDescripcion.DialogResult = DialogResult.Cancel;
            btnDescripcion.FlatAppearance.BorderSize = 0;
            btnDescripcion.FlatStyle = FlatStyle.Flat;
            btnDescripcion.Font = new Font("Britanica-Heavy", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescripcion.ForeColor = Color.White;
            btnDescripcion.Location = new Point(592, 608);
            btnDescripcion.Name = "btnDescripcion";
            btnDescripcion.Size = new Size(139, 30);
            btnDescripcion.TabIndex = 29;
            btnDescripcion.Text = "Ver Detalles";
            btnDescripcion.TextColor = Color.White;
            btnDescripcion.UseVisualStyleBackColor = false;
            btnDescripcion.Click += btnDescripcion_Click;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 40;
            // 
            // Fecha
            // 
            Fecha.Frozen = true;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Encargado
            // 
            Encargado.Frozen = true;
            Encargado.HeaderText = "Responsable";
            Encargado.Name = "Encargado";
            Encargado.ReadOnly = true;
            Encargado.Width = 240;
            // 
            // Producto
            // 
            Producto.Frozen = true;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 170;
            // 
            // Cantidad
            // 
            Cantidad.Frozen = true;
            Cantidad.HeaderText = "Cantidad Alterada";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = DataGridViewTriState.True;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 170;
            // 
            // RegistroHistorial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 650);
            Controls.Add(btnDescripcion);
            Controls.Add(tbBuscarRegistro);
            Controls.Add(btnRefrescar);
            Controls.Add(btnCerrar);
            Controls.Add(separador);
            Controls.Add(label1);
            Controls.Add(registrosDGV);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegistroHistorial";
            Text = "RegistroHistorial";
            ((System.ComponentModel.ISupportInitialize)registrosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel separador;
        private Individual.Visual.ComponentesMod.RJButton btnCerrar;
        private Button btnRefrescar;
        public DataGridView registrosDGV;
        private TextBox tbBuscarRegistro;
        private Individual.Visual.ComponentesMod.RJButton btnDescripcion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Encargado;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
    }
}