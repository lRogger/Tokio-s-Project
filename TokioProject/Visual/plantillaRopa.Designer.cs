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
            this.panelMod1.Controls.Add(this.panelMod2);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 45F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.White;
            this.panelMod1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Margin = new System.Windows.Forms.Padding(5);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(150, 150);
            this.panelMod1.TabIndex = 0;
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
            this.panelMod2.Size = new System.Drawing.Size(61, 67);
            this.panelMod2.TabIndex = 0;
            // 
            // imagenRopa
            // 
            this.imagenRopa.BackColor = System.Drawing.Color.Transparent;
            this.imagenRopa.Image = ((System.Drawing.Image)(resources.GetObject("imagenRopa.Image")));
            this.imagenRopa.InitialImage = null;
            this.imagenRopa.Location = new System.Drawing.Point(0, 0);
            this.imagenRopa.Name = "imagenRopa";
            this.imagenRopa.Size = new System.Drawing.Size(61, 67);
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
            this.panelMod1.ResumeLayout(false);
            this.panelMod2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenRopa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentesMod.PanelMod panelMod1;
        private ComponentesMod.PanelMod panelMod2;
        private PictureBox imagenRopa;
    }
}
