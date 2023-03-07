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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.separador = new System.Windows.Forms.Panel();
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.registrosDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarRegistro = new System.Windows.Forms.TextBox();
            this.btnDescripcion = new Individual.Visual.ComponentesMod.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.separador.Location = new System.Drawing.Point(11, 65);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(537, 2);
            this.separador.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCerrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderRadius = 10;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(451, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 33);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Britanica-Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnRefrescar.Location = new System.Drawing.Point(398, 10);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(50, 48);
            this.btnRefrescar.TabIndex = 20;
            this.btnRefrescar.Text = "🔄";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // registrosDGV
            // 
            this.registrosDGV.AllowUserToAddRows = false;
            this.registrosDGV.AllowUserToDeleteRows = false;
            this.registrosDGV.AllowUserToResizeColumns = false;
            this.registrosDGV.AllowUserToResizeRows = false;
            this.registrosDGV.BackgroundColor = System.Drawing.Color.White;
            this.registrosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registrosDGV.CausesValidation = false;
            this.registrosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.registrosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Encargado,
            this.Producto,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britanica-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registrosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.registrosDGV.EnableHeadersVisualStyles = false;
            this.registrosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registrosDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registrosDGV.Location = new System.Drawing.Point(12, 111);
            this.registrosDGV.MultiSelect = false;
            this.registrosDGV.Name = "registrosDGV";
            this.registrosDGV.ReadOnly = true;
            this.registrosDGV.RowHeadersVisible = false;
            this.registrosDGV.RowHeadersWidth = 4;
            this.registrosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.registrosDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.registrosDGV.RowTemplate.Height = 25;
            this.registrosDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.registrosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registrosDGV.Size = new System.Drawing.Size(537, 305);
            this.registrosDGV.TabIndex = 21;
            this.registrosDGV.SelectionChanged += new System.EventHandler(this.registrosDGV_SelectionChanged);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Encargado
            // 
            this.Encargado.Frozen = true;
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            this.Encargado.Width = 125;
            // 
            // Producto
            // 
            this.Producto.Frozen = true;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 85;
            // 
            // tbBuscarRegistro
            // 
            this.tbBuscarRegistro.BackColor = System.Drawing.Color.White;
            this.tbBuscarRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscarRegistro.Location = new System.Drawing.Point(11, 78);
            this.tbBuscarRegistro.Name = "tbBuscarRegistro";
            this.tbBuscarRegistro.PlaceholderText = " 🔎 Buscar...";
            this.tbBuscarRegistro.Size = new System.Drawing.Size(537, 22);
            this.tbBuscarRegistro.TabIndex = 22;
            this.tbBuscarRegistro.TextChanged += new System.EventHandler(this.buscarUser_TextChanged);
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnDescripcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnDescripcion.BorderColor = System.Drawing.Color.Transparent;
            this.btnDescripcion.BorderRadius = 10;
            this.btnDescripcion.BorderSize = 0;
            this.btnDescripcion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDescripcion.FlatAppearance.BorderSize = 0;
            this.btnDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDescripcion.ForeColor = System.Drawing.Color.White;
            this.btnDescripcion.Location = new System.Drawing.Point(423, 426);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(125, 30);
            this.btnDescripcion.TabIndex = 29;
            this.btnDescripcion.Text = "Ver Detalles";
            this.btnDescripcion.TextColor = System.Drawing.Color.White;
            this.btnDescripcion.UseVisualStyleBackColor = false;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // RegistroHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 470);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.tbBuscarRegistro);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.separador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrosDGV);
            this.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroHistorial";
            this.Text = "RegistroHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.registrosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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