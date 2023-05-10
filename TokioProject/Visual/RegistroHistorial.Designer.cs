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
            label1 = new Label();
            separador = new Panel();
            btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            btnRefrescar = new Button();
            registrosDGV = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            tbBuscarRegistro = new TextBox();
            btnDescripcion = new Individual.Visual.ComponentesMod.RJButton();
            ((System.ComponentModel.ISupportInitialize)registrosDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(118, 27, 141);
            label1.Location = new Point(7, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 42);
            label1.TabIndex = 0;
            label1.Text = "Historial";
            // 
            // separador
            // 
            separador.BackColor = Color.FromArgb(70, 15, 75);
            separador.Location = new Point(11, 65);
            separador.Name = "separador";
            separador.Size = new Size(537, 2);
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
            btnCerrar.Location = new Point(451, 17);
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
            btnRefrescar.Location = new Point(398, 10);
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
            registrosDGV.BackgroundColor = Color.White;
            registrosDGV.BorderStyle = BorderStyle.None;
            registrosDGV.CausesValidation = false;
            registrosDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            registrosDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 27, 141);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            registrosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            registrosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrosDGV.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Encargado, Producto, Cantidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            registrosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            registrosDGV.EnableHeadersVisualStyles = false;
            registrosDGV.GridColor = Color.FromArgb(64, 64, 64);
            registrosDGV.ImeMode = ImeMode.NoControl;
            registrosDGV.Location = new Point(12, 111);
            registrosDGV.MultiSelect = false;
            registrosDGV.Name = "registrosDGV";
            registrosDGV.ReadOnly = true;
            registrosDGV.RowHeadersVisible = false;
            registrosDGV.RowHeadersWidth = 4;
            registrosDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 51, 102);
            registrosDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            registrosDGV.RowTemplate.Height = 25;
            registrosDGV.ScrollBars = ScrollBars.Vertical;
            registrosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            registrosDGV.Size = new Size(537, 305);
            registrosDGV.TabIndex = 21;
            registrosDGV.SelectionChanged += registrosDGV_SelectionChanged;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Fecha
            // 
            Fecha.Frozen = true;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 90;
            // 
            // Encargado
            // 
            Encargado.Frozen = true;
            Encargado.HeaderText = "Encargado";
            Encargado.Name = "Encargado";
            Encargado.ReadOnly = true;
            Encargado.Width = 125;
            // 
            // Producto
            // 
            Producto.Frozen = true;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 180;
            // 
            // Cantidad
            // 
            Cantidad.Frozen = true;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = DataGridViewTriState.True;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 85;
            // 
            // tbBuscarRegistro
            // 
            tbBuscarRegistro.BackColor = Color.White;
            tbBuscarRegistro.BorderStyle = BorderStyle.None;
            tbBuscarRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarRegistro.Location = new Point(11, 78);
            tbBuscarRegistro.Name = "tbBuscarRegistro";
            tbBuscarRegistro.PlaceholderText = " 🔎 Buscar...";
            tbBuscarRegistro.Size = new Size(537, 22);
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
            btnDescripcion.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescripcion.ForeColor = Color.White;
            btnDescripcion.Location = new Point(423, 428);
            btnDescripcion.Name = "btnDescripcion";
            btnDescripcion.Size = new Size(125, 30);
            btnDescripcion.TabIndex = 29;
            btnDescripcion.Text = "Ver Detalles";
            btnDescripcion.TextColor = Color.White;
            btnDescripcion.UseVisualStyleBackColor = false;
            btnDescripcion.Click += btnDescripcion_Click;
            // 
            // RegistroHistorial
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 470);
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