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
            lblDesc = new Label();
            panelDescripcionRegistro = new Panel();
            label2 = new Label();
            lblProducto = new Label();
            label7 = new Label();
            lblEncargado = new Label();
            label5 = new Label();
            lblDia = new Label();
            lblFecha = new Label();
            lblIdentificacion = new Label();
            label1 = new Label();
            btnMenos = new Individual.Visual.ComponentesMod.RJButton();
            btnSuma = new Individual.Visual.ComponentesMod.RJButton();
            lblDescripcionRegistro = new Label();
            panel1 = new Panel();
            btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            panel2 = new Panel();
            panelDescripcionRegistro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Britanica-Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = SystemColors.Window;
            lblDesc.Location = new Point(12, 13);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(224, 39);
            lblDesc.TabIndex = 31;
            lblDesc.Text = "📄 Descripción";
            // 
            // panelDescripcionRegistro
            // 
            panelDescripcionRegistro.BackColor = Color.FromArgb(70, 15, 75);
            panelDescripcionRegistro.Controls.Add(label2);
            panelDescripcionRegistro.Controls.Add(lblProducto);
            panelDescripcionRegistro.Controls.Add(label7);
            panelDescripcionRegistro.Controls.Add(lblEncargado);
            panelDescripcionRegistro.Controls.Add(label5);
            panelDescripcionRegistro.Controls.Add(lblDia);
            panelDescripcionRegistro.Controls.Add(lblFecha);
            panelDescripcionRegistro.Controls.Add(lblIdentificacion);
            panelDescripcionRegistro.Controls.Add(label1);
            panelDescripcionRegistro.Controls.Add(btnMenos);
            panelDescripcionRegistro.Controls.Add(btnSuma);
            panelDescripcionRegistro.Controls.Add(lblDescripcionRegistro);
            panelDescripcionRegistro.Dock = DockStyle.Fill;
            panelDescripcionRegistro.Location = new Point(0, 69);
            panelDescripcionRegistro.Name = "panelDescripcionRegistro";
            panelDescripcionRegistro.Size = new Size(446, 223);
            panelDescripcionRegistro.TabIndex = 29;
            panelDescripcionRegistro.Paint += panelDescripcionRegistro_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(29, 116);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 43;
            label2.Text = "CAMBIOS:";
            // 
            // lblProducto
            // 
            lblProducto.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(196, 87);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(220, 29);
            lblProducto.TabIndex = 40;
            lblProducto.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(29, 84);
            label7.Name = "label7";
            label7.Size = new Size(169, 22);
            label7.TabIndex = 39;
            label7.Text = "Producto Alterado:";
            label7.Click += label7_Click;
            // 
            // lblEncargado
            // 
            lblEncargado.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncargado.ForeColor = Color.White;
            lblEncargado.Location = new Point(147, 54);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(270, 29);
            lblEncargado.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(29, 51);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 37;
            label5.Text = "Responsable:";
            // 
            // lblDia
            // 
            lblDia.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDia.ForeColor = Color.White;
            lblDia.Location = new Point(196, 22);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(216, 29);
            lblDia.TabIndex = 36;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.Window;
            lblFecha.Location = new Point(133, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 22);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha:";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificacion.ForeColor = Color.White;
            lblIdentificacion.Location = new Point(65, 23);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(56, 29);
            lblIdentificacion.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britanica-Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(37, 22);
            label1.TabIndex = 32;
            label1.Text = "ID:";
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
            btnMenos.Location = new Point(673, 58);
            btnMenos.Margin = new Padding(0);
            btnMenos.Name = "btnMenos";
            btnMenos.RightToLeft = RightToLeft.Yes;
            btnMenos.Size = new Size(43, 31);
            btnMenos.TabIndex = 29;
            btnMenos.Text = "➖";
            btnMenos.TextColor = Color.White;
            btnMenos.UseVisualStyleBackColor = false;
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
            btnSuma.Location = new Point(775, 58);
            btnSuma.Margin = new Padding(0);
            btnSuma.Name = "btnSuma";
            btnSuma.RightToLeft = RightToLeft.Yes;
            btnSuma.Size = new Size(32, 31);
            btnSuma.TabIndex = 28;
            btnSuma.Text = "➕";
            btnSuma.TextColor = Color.White;
            btnSuma.UseVisualStyleBackColor = false;
            // 
            // lblDescripcionRegistro
            // 
            lblDescripcionRegistro.AutoSize = true;
            lblDescripcionRegistro.Font = new Font("Britanica-Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcionRegistro.ForeColor = Color.White;
            lblDescripcionRegistro.Location = new Point(30, 181);
            lblDescripcionRegistro.MaximumSize = new Size(390, 0);
            lblDescripcionRegistro.Name = "lblDescripcionRegistro";
            lblDescripcionRegistro.Size = new Size(0, 19);
            lblDescripcionRegistro.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 15, 75);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lblDesc);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 66);
            panel1.TabIndex = 30;
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
            btnCerrar.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(409, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(37, 33);
            btnCerrar.TabIndex = 31;
            btnCerrar.Text = "X";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 3);
            panel2.TabIndex = 31;
            // 
            // DescripcionRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 292);
            ControlBox = false;
            Controls.Add(panelDescripcionRegistro);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DescripcionRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DescripcionRegistro";
            panelDescripcionRegistro.ResumeLayout(false);
            panelDescripcionRegistro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        public Label lblProducto;
        private Label label7;
        private Label label2;
    }
}