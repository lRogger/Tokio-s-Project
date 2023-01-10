namespace Individual.Visual
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.admUser = new System.Windows.Forms.CheckBox();
            this.edadUser = new System.Windows.Forms.TextBox();
            this.correoUser = new System.Windows.Forms.TextBox();
            this.nomUser = new System.Windows.Forms.TextBox();
            this.cedUser = new System.Windows.Forms.TextBox();
            this.buscarFoto = new System.Windows.Forms.Button();
            this.fotoUser = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new Individual.Visual.ComponentesMod.RJButton();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).BeginInit();
            this.panelMod1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admUser
            // 
            this.admUser.AutoSize = true;
            this.admUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.admUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admUser.Location = new System.Drawing.Point(343, 38);
            this.admUser.Name = "admUser";
            this.admUser.Size = new System.Drawing.Size(64, 20);
            this.admUser.TabIndex = 6;
            this.admUser.Text = "Admin";
            this.admUser.UseVisualStyleBackColor = false;
            this.admUser.CheckedChanged += new System.EventHandler(this.admUser_CheckedChanged);
            // 
            // edadUser
            // 
            this.edadUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edadUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edadUser.Location = new System.Drawing.Point(215, 139);
            this.edadUser.MaxLength = 3;
            this.edadUser.MinimumSize = new System.Drawing.Size(0, 27);
            this.edadUser.Name = "edadUser";
            this.edadUser.Size = new System.Drawing.Size(190, 27);
            this.edadUser.TabIndex = 5;
            this.edadUser.TextChanged += new System.EventHandler(this.edadUser_TextChanged);
            this.edadUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edadUser_KeyPress);
            // 
            // correoUser
            // 
            this.correoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correoUser.Location = new System.Drawing.Point(215, 104);
            this.correoUser.MinimumSize = new System.Drawing.Size(0, 27);
            this.correoUser.Name = "correoUser";
            this.correoUser.Size = new System.Drawing.Size(190, 27);
            this.correoUser.TabIndex = 4;
            this.correoUser.TextChanged += new System.EventHandler(this.correoUser_TextChanged);
            // 
            // nomUser
            // 
            this.nomUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomUser.Location = new System.Drawing.Point(215, 68);
            this.nomUser.MaximumSize = new System.Drawing.Size(0, 25);
            this.nomUser.MinimumSize = new System.Drawing.Size(0, 27);
            this.nomUser.Name = "nomUser";
            this.nomUser.Size = new System.Drawing.Size(190, 27);
            this.nomUser.TabIndex = 3;
            this.nomUser.TextChanged += new System.EventHandler(this.nomUser_TextChanged);
            this.nomUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomUser_KeyPress);
            // 
            // cedUser
            // 
            this.cedUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cedUser.Location = new System.Drawing.Point(215, 34);
            this.cedUser.MaximumSize = new System.Drawing.Size(200, 25);
            this.cedUser.MaxLength = 10;
            this.cedUser.MinimumSize = new System.Drawing.Size(0, 27);
            this.cedUser.Name = "cedUser";
            this.cedUser.Size = new System.Drawing.Size(122, 27);
            this.cedUser.TabIndex = 2;
            this.cedUser.TextChanged += new System.EventHandler(this.cedUser_TextChanged);
            this.cedUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedUser_KeyPress);
            // 
            // buscarFoto
            // 
            this.buscarFoto.BackColor = System.Drawing.Color.DimGray;
            this.buscarFoto.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buscarFoto.FlatAppearance.BorderSize = 2;
            this.buscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buscarFoto.Font = new System.Drawing.Font("Britanica-Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarFoto.ForeColor = System.Drawing.Color.White;
            this.buscarFoto.Location = new System.Drawing.Point(56, 141);
            this.buscarFoto.Name = "buscarFoto";
            this.buscarFoto.Size = new System.Drawing.Size(65, 18);
            this.buscarFoto.TabIndex = 1;
            this.buscarFoto.Text = "Subir Foto";
            this.buscarFoto.UseVisualStyleBackColor = false;
            this.buscarFoto.Click += new System.EventHandler(this.buscarFoto_Click);
            // 
            // fotoUser
            // 
            this.fotoUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fotoUser.Image = ((System.Drawing.Image)(resources.GetObject("fotoUser.Image")));
            this.fotoUser.Location = new System.Drawing.Point(38, 35);
            this.fotoUser.Name = "fotoUser";
            this.fotoUser.Size = new System.Drawing.Size(100, 100);
            this.fotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUser.TabIndex = 0;
            this.fotoUser.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnviar.BorderRadius = 15;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(339, 289);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(135, 35);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Guardar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 25;
            this.panelMod1.Controls.Add(this.label4);
            this.panelMod1.Controls.Add(this.label3);
            this.panelMod1.Controls.Add(this.label1);
            this.panelMod1.Controls.Add(this.label2);
            this.panelMod1.Controls.Add(this.edadUser);
            this.panelMod1.Controls.Add(this.admUser);
            this.panelMod1.Controls.Add(this.cedUser);
            this.panelMod1.Controls.Add(this.correoUser);
            this.panelMod1.Controls.Add(this.fotoUser);
            this.panelMod1.Controls.Add(this.nomUser);
            this.panelMod1.Controls.Add(this.buscarFoto);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.White;
            this.panelMod1.GradientTopColor = System.Drawing.Color.White;
            this.panelMod1.Location = new System.Drawing.Point(24, 73);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(450, 200);
            this.panelMod1.TabIndex = 12;
            this.panelMod1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMod1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(148, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(148, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britanica-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(148, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.BorderRadius = 15;
            this.btnCerrar.BorderSize = 2;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.Location = new System.Drawing.Point(218, 289);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 35);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Britanica-Heavy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 42);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Nuevo Usuario";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMod1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).EndInit();
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buscarFoto;
        public PictureBox fotoUser;
        public CheckBox admUser;
        public TextBox edadUser;
        public TextBox correoUser;
        public TextBox nomUser;
        public TextBox cedUser;
        private ComponentesMod.RJButton btnEnviar;
        private ComponentesMod.PanelMod panelMod1;
        private ComponentesMod.RJButton btnCerrar;
        private Label lblTitulo;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}