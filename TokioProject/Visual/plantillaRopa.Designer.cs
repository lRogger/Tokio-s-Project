namespace Individual.Visual
{
    partial class plantillaRopa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plantillaRopa));
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.rjButton2 = new Individual.Visual.ComponentesMod.RJButton();
            this.rjButton1 = new Individual.Visual.ComponentesMod.RJButton();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.nombreRopa = new System.Windows.Forms.Label();
            this.panelMod2 = new Individual.Visual.ComponentesMod.PanelMod();
            this.imagenRopa = new System.Windows.Forms.PictureBox();
            this.panelMod1.SuspendLayout();
            this.panelMod2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenRopa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 30;
            this.panelMod1.Controls.Add(this.rjButton2);
            this.panelMod1.Controls.Add(this.rjButton1);
            this.panelMod1.Controls.Add(this.lblstock);
            this.panelMod1.Controls.Add(this.lblcategoria);
            this.panelMod1.Controls.Add(this.nombreRopa);
            this.panelMod1.Controls.Add(this.panelMod2);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 45F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMod1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(306, 187);
            this.panelMod1.TabIndex = 0;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(139, 132);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 5;
            this.rjButton2.Text = "Ajustar Stock";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(139, 86);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Transferencia Stock";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(243, 56);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(35, 15);
            this.lblstock.TabIndex = 3;
            this.lblstock.Text = "stock";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(152, 56);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(56, 15);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "categoria";
            // 
            // nombreRopa
            // 
            this.nombreRopa.AutoSize = true;
            this.nombreRopa.Location = new System.Drawing.Point(173, 21);
            this.nombreRopa.Name = "nombreRopa";
            this.nombreRopa.Size = new System.Drawing.Size(81, 15);
            this.nombreRopa.TabIndex = 1;
            this.nombreRopa.Text = "Nombre Ropa";
            // 
            // panelMod2
            // 
            this.panelMod2.BackColor = System.Drawing.Color.White;
            this.panelMod2.BorderRadius = 30;
            this.panelMod2.Controls.Add(this.imagenRopa);
            this.panelMod2.ForeColor = System.Drawing.Color.Black;
            this.panelMod2.GradientAngle = 0F;
            this.panelMod2.GradientBottomColor = System.Drawing.Color.White;
            this.panelMod2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMod2.Location = new System.Drawing.Point(9, 11);
            this.panelMod2.Name = "panelMod2";
            this.panelMod2.Size = new System.Drawing.Size(120, 168);
            this.panelMod2.TabIndex = 0;
            // 
            // imagenRopa
            // 
            this.imagenRopa.BackColor = System.Drawing.Color.Transparent;
            this.imagenRopa.Image = ((System.Drawing.Image)(resources.GetObject("imagenRopa.Image")));
            this.imagenRopa.InitialImage = null;
            this.imagenRopa.Location = new System.Drawing.Point(0, 0);
            this.imagenRopa.Name = "imagenRopa";
            this.imagenRopa.Size = new System.Drawing.Size(120, 168);
            this.imagenRopa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenRopa.TabIndex = 0;
            this.imagenRopa.TabStop = false;
            // 
            // plantillaRopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMod1);
            this.Name = "plantillaRopa";
            this.Size = new System.Drawing.Size(306, 190);
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.panelMod2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenRopa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentesMod.PanelMod panelMod1;
        private ComponentesMod.PanelMod panelMod2;
        private PictureBox imagenRopa;
        private ComponentesMod.RJButton rjButton2;
        private ComponentesMod.RJButton rjButton1;
        private Label lblstock;
        private Label lblcategoria;
        private Label nombreRopa;
    }
}
