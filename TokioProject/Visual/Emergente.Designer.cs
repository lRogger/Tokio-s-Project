namespace Individual.Visual
{
    partial class Emergente
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
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new Individual.Visual.ComponentesMod.RJButton();
            this.btnCancel = new Individual.Visual.ComponentesMod.RJButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flPanel.SuspendLayout();
            this.panelMod1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flPanel.Controls.Add(this.btnOk);
            this.flPanel.Controls.Add(this.btnCancel);
            this.flPanel.Location = new System.Drawing.Point(27, 96);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(196, 36);
            this.flPanel.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnOk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOk.BorderRadius = 10;
            this.btnOk.BorderSize = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(8, 8);
            this.btnOk.Margin = new System.Windows.Forms.Padding(8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 20);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Si";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(104, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 20);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "No";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(12, 34);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(228, 62);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "TEXTO QUE TENDRÁ LA NOTIFICACIÓN";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(141)))));
            this.panelMod1.BorderRadius = 0;
            this.panelMod1.Controls.Add(this.lblTitulo);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 0F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panelMod1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(264, 31);
            this.panelMod1.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(9, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TITULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Emergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(252, 133);
            this.Controls.Add(this.panelMod1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.flPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergente";
            this.Load += new System.EventHandler(this.Emergente_Load);
            this.flPanel.ResumeLayout(false);
            this.panelMod1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flPanel;
        private ComponentesMod.RJButton btnOk;
        private ComponentesMod.RJButton btnCancel;
        private Label lblTexto;
        private ComponentesMod.PanelMod panelMod1;
        private Label lblTitulo;
    }
}