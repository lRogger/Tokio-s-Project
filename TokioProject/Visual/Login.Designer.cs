namespace Individual
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cerrar = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.btnIniciar = new Individual.Visual.ComponentesMod.RJButton();
            this.tbpwd = new CustomControls.RJControls.RJTextBox();
            this.tbUser = new CustomControls.RJControls.RJTextBox();
            this.panelMod1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cerrar.ForeColor = System.Drawing.Color.Thistle;
            this.cerrar.Location = new System.Drawing.Point(709, 1);
            this.cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Padding = new System.Windows.Forms.Padding(5);
            this.cerrar.Size = new System.Drawing.Size(40, 42);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Britanica-Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(105, 310);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidé mi contraseña";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britanica-Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.Black;
            this.panelMod1.BorderRadius = 30;
            this.panelMod1.Controls.Add(this.btnIniciar);
            this.panelMod1.Controls.Add(this.tbpwd);
            this.panelMod1.Controls.Add(this.tbUser);
            this.panelMod1.Controls.Add(this.linkLabel1);
            this.panelMod1.Controls.Add(this.label3);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelMod1.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelMod1.Location = new System.Drawing.Point(215, 54);
            this.panelMod1.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(321, 433);
            this.panelMod1.TabIndex = 11;
            this.panelMod1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMod1_MouseMove);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnIniciar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnIniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIniciar.BorderRadius = 15;
            this.btnIniciar.BorderSize = 0;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(77, 265);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(171, 40);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextColor = System.Drawing.Color.White;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // tbpwd
            // 
            this.tbpwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpwd.BorderColor = System.Drawing.Color.Transparent;
            this.tbpwd.BorderFocusColor = System.Drawing.Color.LightGray;
            this.tbpwd.BorderRadius = 10;
            this.tbpwd.BorderSize = 2;
            this.tbpwd.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpwd.Location = new System.Drawing.Point(51, 208);
            this.tbpwd.Margin = new System.Windows.Forms.Padding(4);
            this.tbpwd.Multiline = false;
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbpwd.PasswordChar = true;
            this.tbpwd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbpwd.PlaceholderText = "🔑 Contraseña";
            this.tbpwd.Size = new System.Drawing.Size(223, 31);
            this.tbpwd.TabIndex = 7;
            this.tbpwd.Texts = "";
            this.tbpwd.UnderlinedStyle = false;
            this.tbpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox1_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbUser.BorderColor = System.Drawing.Color.Transparent;
            this.tbUser.BorderFocusColor = System.Drawing.Color.LightGray;
            this.tbUser.BorderRadius = 10;
            this.tbUser.BorderSize = 2;
            this.tbUser.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUser.Location = new System.Drawing.Point(51, 166);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbUser.PasswordChar = false;
            this.tbUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUser.PlaceholderText = "ℹ Cédula";
            this.tbUser.Size = new System.Drawing.Size(223, 31);
            this.tbUser.TabIndex = 6;
            this.tbUser.Texts = "";
            this.tbUser.UnderlinedStyle = false;
            this.tbUser._TextChanged += new System.EventHandler(this.tbUser__TextChanged);
            this.tbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUser_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panelMod1);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicia sesión";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cerrar;
        private LinkLabel linkLabel1;
        private Label label3;
        private Visual.ComponentesMod.PanelMod panelMod1;
        public CustomControls.RJControls.RJTextBox tbUser;
        public CustomControls.RJControls.RJTextBox tbpwd;
        public Visual.ComponentesMod.RJButton btnIniciar;
    }
}