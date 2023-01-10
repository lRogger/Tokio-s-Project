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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.tbStock = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.tbDescrip = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCateg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecio = new CustomControls.RJControls.RJTextBox();
            this.tbNombreProd = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new Individual.Visual.ComponentesMod.RJButton();
            this.btnCancelar = new Individual.Visual.ComponentesMod.RJButton();
            this.panelMod1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britanica-Heavy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.lblTitulo.Location = new System.Drawing.Point(23, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Producto";
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 40;
            this.panelMod1.Controls.Add(this.tbStock);
            this.panelMod1.Controls.Add(this.label1);
            this.panelMod1.Controls.Add(this.cbColor);
            this.panelMod1.Controls.Add(this.cbTalla);
            this.panelMod1.Controls.Add(this.tbDescrip);
            this.panelMod1.Controls.Add(this.label7);
            this.panelMod1.Controls.Add(this.label6);
            this.panelMod1.Controls.Add(this.label5);
            this.panelMod1.Controls.Add(this.cbCateg);
            this.panelMod1.Controls.Add(this.label4);
            this.panelMod1.Controls.Add(this.tbPrecio);
            this.panelMod1.Controls.Add(this.tbNombreProd);
            this.panelMod1.Controls.Add(this.label3);
            this.panelMod1.Controls.Add(this.label2);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.White;
            this.panelMod1.GradientTopColor = System.Drawing.Color.White;
            this.panelMod1.Location = new System.Drawing.Point(23, 73);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(500, 280);
            this.panelMod1.TabIndex = 1;
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.Color.White;
            this.tbStock.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbStock.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbStock.BorderRadius = 10;
            this.tbStock.BorderSize = 1;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbStock.Location = new System.Drawing.Point(404, 27);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbStock.Multiline = false;
            this.tbStock.Name = "tbStock";
            this.tbStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbStock.PasswordChar = false;
            this.tbStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbStock.PlaceholderText = "";
            this.tbStock.Size = new System.Drawing.Size(59, 31);
            this.tbStock.TabIndex = 13;
            this.tbStock.Texts = "";
            this.tbStock.UnderlinedStyle = false;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(354, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stock:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Azul",
            "Amarillo",
            "Rojo",
            "Verde",
            "Morado",
            "Lila",
            "Marron",
            "Turquesa",
            "Fucsia"});
            this.cbColor.Location = new System.Drawing.Point(367, 80);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(96, 23);
            this.cbColor.TabIndex = 11;
            // 
            // cbTalla
            // 
            this.cbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cbTalla.Location = new System.Drawing.Point(240, 80);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(67, 23);
            this.cbTalla.TabIndex = 10;
            // 
            // tbDescrip
            // 
            this.tbDescrip.BackColor = System.Drawing.Color.White;
            this.tbDescrip.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbDescrip.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescrip.BorderRadius = 10;
            this.tbDescrip.BorderSize = 1;
            this.tbDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDescrip.Location = new System.Drawing.Point(118, 128);
            this.tbDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescrip.Multiline = true;
            this.tbDescrip.Name = "tbDescrip";
            this.tbDescrip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbDescrip.PasswordChar = false;
            this.tbDescrip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDescrip.PlaceholderText = "";
            this.tbDescrip.Size = new System.Drawing.Size(345, 125);
            this.tbDescrip.TabIndex = 9;
            this.tbDescrip.Texts = "";
            this.tbDescrip.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(21, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(318, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(198, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Talla:";
            // 
            // cbCateg
            // 
            this.cbCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCateg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCateg.FormattingEnabled = true;
            this.cbCateg.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Niño",
            "Niña"});
            this.cbCateg.Location = new System.Drawing.Point(100, 80);
            this.cbCateg.Name = "cbCateg";
            this.cbCateg.Size = new System.Drawing.Size(88, 23);
            this.cbCateg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoría:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.White;
            this.tbPrecio.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPrecio.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPrecio.BorderRadius = 10;
            this.tbPrecio.BorderSize = 1;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrecio.Location = new System.Drawing.Point(291, 27);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrecio.Multiline = false;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPrecio.PasswordChar = false;
            this.tbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPrecio.PlaceholderText = "";
            this.tbPrecio.Size = new System.Drawing.Size(59, 31);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.Texts = "";
            this.tbPrecio.UnderlinedStyle = false;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.BackColor = System.Drawing.Color.White;
            this.tbNombreProd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbNombreProd.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNombreProd.BorderRadius = 10;
            this.tbNombreProd.BorderSize = 1;
            this.tbNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNombreProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombreProd.Location = new System.Drawing.Point(86, 27);
            this.tbNombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreProd.Multiline = false;
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNombreProd.PasswordChar = false;
            this.tbNombreProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombreProd.PlaceholderText = "";
            this.tbNombreProd.Size = new System.Drawing.Size(146, 31);
            this.tbNombreProd.TabIndex = 2;
            this.tbNombreProd.Texts = "";
            this.tbNombreProd.UnderlinedStyle = false;
            this.tbNombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreProd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(239, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 15;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(388, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 2;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancelar.Location = new System.Drawing.Point(247, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelMod1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProduct";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewProduct_MouseMove);
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}