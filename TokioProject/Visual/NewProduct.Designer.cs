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
            this.btnGuardar = new Individual.Visual.ComponentesMod.RJButton();
            this.btnCancelar = new Individual.Visual.ComponentesMod.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreProd = new CustomControls.RJControls.RJTextBox();
            this.tbPrecio = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCateg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescrip = new CustomControls.RJControls.RJTextBox();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.panelMod1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britanica-Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.lblTitulo.Location = new System.Drawing.Point(23, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Producto";
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 40;
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
            this.panelMod1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMod1_Paint);
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(294, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio:";
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.BackColor = System.Drawing.Color.White;
            this.tbNombreProd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbNombreProd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNombreProd.BorderRadius = 10;
            this.tbNombreProd.BorderSize = 1;
            this.tbNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNombreProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombreProd.Location = new System.Drawing.Point(88, 26);
            this.tbNombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreProd.Multiline = false;
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNombreProd.PasswordChar = false;
            this.tbNombreProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombreProd.PlaceholderText = "";
            this.tbNombreProd.Size = new System.Drawing.Size(200, 31);
            this.tbNombreProd.TabIndex = 2;
            this.tbNombreProd.Texts = "";
            this.tbNombreProd.UnderlinedStyle = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.White;
            this.tbPrecio.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPrecio.BorderRadius = 10;
            this.tbPrecio.BorderSize = 1;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrecio.Location = new System.Drawing.Point(350, 26);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrecio.Multiline = false;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPrecio.PasswordChar = false;
            this.tbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPrecio.PlaceholderText = "";
            this.tbPrecio.Size = new System.Drawing.Size(113, 31);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.Texts = "";
            this.tbPrecio.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoría:";
            // 
            // cbCateg
            // 
            this.cbCateg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCateg.FormattingEnabled = true;
            this.cbCateg.Location = new System.Drawing.Point(102, 81);
            this.cbCateg.Name = "cbCateg";
            this.cbCateg.Size = new System.Drawing.Size(88, 23);
            this.cbCateg.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(192, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Talla:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(314, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Color:";
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
            // tbDescrip
            // 
            this.tbDescrip.BackColor = System.Drawing.Color.White;
            this.tbDescrip.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbDescrip.BorderFocusColor = System.Drawing.Color.HotPink;
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
            // cbTalla
            // 
            this.cbTalla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.Location = new System.Drawing.Point(235, 81);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(72, 23);
            this.cbTalla.TabIndex = 10;
            // 
            // cbColor
            // 
            this.cbColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(367, 81);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(96, 23);
            this.cbColor.TabIndex = 11;
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
            this.Text = "NewProduct";
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private CustomControls.RJControls.RJTextBox tbPrecio;
        private CustomControls.RJControls.RJTextBox tbNombreProd;
        private Label label3;
        private Label label2;
        private Individual.Visual.ComponentesMod.RJButton btnGuardar;
        private Individual.Visual.ComponentesMod.RJButton btnCancelar;
        private CustomControls.RJControls.RJTextBox tbDescrip;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cbCateg;
        private Label label4;
        private ComboBox cbColor;
        private ComboBox cbTalla;
    }
}