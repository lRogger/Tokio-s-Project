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
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // admUser
            // 
            this.admUser.AutoSize = true;
            this.admUser.Location = new System.Drawing.Point(163, 150);
            this.admUser.Name = "admUser";
            this.admUser.Size = new System.Drawing.Size(62, 19);
            this.admUser.TabIndex = 6;
            this.admUser.Text = "Admin";
            this.admUser.UseVisualStyleBackColor = true;
            this.admUser.CheckedChanged += new System.EventHandler(this.admUser_CheckedChanged);
            // 
            // edadUser
            // 
            this.edadUser.Location = new System.Drawing.Point(163, 120);
            this.edadUser.Name = "edadUser";
            this.edadUser.PlaceholderText = "Edad";
            this.edadUser.Size = new System.Drawing.Size(193, 24);
            this.edadUser.TabIndex = 5;
            this.edadUser.TextChanged += new System.EventHandler(this.edadUser_TextChanged);
            // 
            // correoUser
            // 
            this.correoUser.Location = new System.Drawing.Point(163, 90);
            this.correoUser.Name = "correoUser";
            this.correoUser.PlaceholderText = "Correo";
            this.correoUser.Size = new System.Drawing.Size(193, 24);
            this.correoUser.TabIndex = 4;
            this.correoUser.TextChanged += new System.EventHandler(this.correoUser_TextChanged);
            // 
            // nomUser
            // 
            this.nomUser.Location = new System.Drawing.Point(163, 60);
            this.nomUser.Name = "nomUser";
            this.nomUser.PlaceholderText = "Nombre";
            this.nomUser.Size = new System.Drawing.Size(193, 24);
            this.nomUser.TabIndex = 3;
            this.nomUser.TextChanged += new System.EventHandler(this.nomUser_TextChanged);
            // 
            // cedUser
            // 
            this.cedUser.Location = new System.Drawing.Point(163, 30);
            this.cedUser.Name = "cedUser";
            this.cedUser.PlaceholderText = "Cedula";
            this.cedUser.Size = new System.Drawing.Size(193, 24);
            this.cedUser.TabIndex = 2;
            this.cedUser.TextChanged += new System.EventHandler(this.cedUser_TextChanged);
            // 
            // buscarFoto
            // 
            this.buscarFoto.Location = new System.Drawing.Point(54, 146);
            this.buscarFoto.Name = "buscarFoto";
            this.buscarFoto.Size = new System.Drawing.Size(75, 23);
            this.buscarFoto.TabIndex = 1;
            this.buscarFoto.Text = "Cargar";
            this.buscarFoto.UseVisualStyleBackColor = true;
            this.buscarFoto.Click += new System.EventHandler(this.buscarFoto_Click);
            // 
            // fotoUser
            // 
            this.fotoUser.Image = ((System.Drawing.Image)(resources.GetObject("fotoUser.Image")));
            this.fotoUser.Location = new System.Drawing.Point(35, 30);
            this.fotoUser.Name = "fotoUser";
            this.fotoUser.Size = new System.Drawing.Size(112, 110);
            this.fotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUser.TabIndex = 0;
            this.fotoUser.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.White;
            this.btnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 7;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(121, 212);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(151, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.Black;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.BorderRadius = 7;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.Location = new System.Drawing.Point(362, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(-1, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 39);
            this.panel1.TabIndex = 11;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(393, 242);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.fotoUser);
            this.Controls.Add(this.admUser);
            this.Controls.Add(this.buscarFoto);
            this.Controls.Add(this.edadUser);
            this.Controls.Add(this.cedUser);
            this.Controls.Add(this.correoUser);
            this.Controls.Add(this.nomUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUser";
            this.Opacity = 0.55D;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).EndInit();
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
        private ComponentesMod.RJButton btnCerrar;
        private Panel panel1;
    }
}