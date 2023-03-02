namespace GUIs.Visual
{
    partial class DescripcionRegistro
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.panelDescripcionRegistro = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            this.btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            this.lblDescripcionRegistro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDescripcionRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Britanica-Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDesc.Location = new System.Drawing.Point(12, 13);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(224, 39);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "📄 Descripción";
            // 
            // panelDescripcionRegistro
            // 
            this.panelDescripcionRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.panelDescripcionRegistro.Controls.Add(this.label10);
            this.panelDescripcionRegistro.Controls.Add(this.lblCantidad);
            this.panelDescripcionRegistro.Controls.Add(this.label9);
            this.panelDescripcionRegistro.Controls.Add(this.lblProducto);
            this.panelDescripcionRegistro.Controls.Add(this.label7);
            this.panelDescripcionRegistro.Controls.Add(this.lblEncargado);
            this.panelDescripcionRegistro.Controls.Add(this.label5);
            this.panelDescripcionRegistro.Controls.Add(this.lblDia);
            this.panelDescripcionRegistro.Controls.Add(this.lblFecha);
            this.panelDescripcionRegistro.Controls.Add(this.lblIdentificacion);
            this.panelDescripcionRegistro.Controls.Add(this.label1);
            this.panelDescripcionRegistro.Controls.Add(this.btnMenos);
            this.panelDescripcionRegistro.Controls.Add(this.btnSuma);
            this.panelDescripcionRegistro.Controls.Add(this.lblDescripcionRegistro);
            this.panelDescripcionRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescripcionRegistro.Location = new System.Drawing.Point(0, 69);
            this.panelDescripcionRegistro.Name = "panelDescripcionRegistro";
            this.panelDescripcionRegistro.Size = new System.Drawing.Size(446, 261);
            this.panelDescripcionRegistro.TabIndex = 29;
            this.panelDescripcionRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDescripcionRegistro_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(29, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cambios:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(120, 117);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(298, 29);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(29, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cantidad:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(120, 83);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(298, 29);
            this.lblProducto.TabIndex = 40;
            this.lblProducto.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(29, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Producto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblEncargado
            // 
            this.lblEncargado.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEncargado.ForeColor = System.Drawing.Color.White;
            this.lblEncargado.Location = new System.Drawing.Point(133, 50);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(285, 29);
            this.lblEncargado.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(29, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Encargado:";
            // 
            // lblDia
            // 
            this.lblDia.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(318, 17);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(100, 29);
            this.lblDia.TabIndex = 36;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFecha.Location = new System.Drawing.Point(251, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 22);
            this.lblFecha.TabIndex = 35;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.ForeColor = System.Drawing.Color.White;
            this.lblIdentificacion.Location = new System.Drawing.Point(67, 16);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(56, 29);
            this.lblIdentificacion.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
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
            this.btnMenos.Location = new System.Drawing.Point(673, 77);
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
            this.btnSuma.Location = new System.Drawing.Point(775, 77);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSuma.Size = new System.Drawing.Size(32, 31);
            this.btnSuma.TabIndex = 28;
            this.btnSuma.Text = "➕";
            this.btnSuma.TextColor = System.Drawing.Color.White;
            this.btnSuma.UseVisualStyleBackColor = false;
            // 
            // lblDescripcionRegistro
            // 
            this.lblDescripcionRegistro.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionRegistro.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionRegistro.Location = new System.Drawing.Point(29, 181);
            this.lblDescripcionRegistro.Name = "lblDescripcionRegistro";
            this.lblDescripcionRegistro.Size = new System.Drawing.Size(389, 58);
            this.lblDescripcionRegistro.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 66);
            this.panel1.TabIndex = 30;
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
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(409, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 33);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 3);
            this.panel2.TabIndex = 31;
            // 
            // DescripcionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 330);
            this.ControlBox = false;
            this.Controls.Add(this.panelDescripcionRegistro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescripcionRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DescripcionRegistro";
            this.panelDescripcionRegistro.ResumeLayout(false);
            this.panelDescripcionRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblDesc;
        private Panel panelDescripcionRegistro;
        private Individual.Visual.ComponentesMod.RJButton btnMenos;
        private Individual.Visual.ComponentesMod.RJButton btnSuma;
        private Panel panel1;
        private Panel panel2;
        private Individual.Visual.ComponentesMod.RJButton btnCerrar;
        public Label lblDescripcionRegistro;
        private Label label1;
        public Label lblDia;
        private Label lblFecha;
        public Label lblIdentificacion;
        public Label lblEncargado;
        private Label label5;
        public Label lblCantidad;
        private Label label9;
        public Label lblProducto;
        private Label label7;
        private Label label10;
    }
}