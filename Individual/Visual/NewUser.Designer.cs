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
            this.button1 = new System.Windows.Forms.Button();
            this.admUser = new System.Windows.Forms.CheckBox();
            this.edadUser = new System.Windows.Forms.TextBox();
            this.correoUser = new System.Windows.Forms.TextBox();
            this.nomUser = new System.Windows.Forms.TextBox();
            this.cedUser = new System.Windows.Forms.TextBox();
            this.buscarFoto = new System.Windows.Forms.Button();
            this.fotoUser = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admUser
            // 
            this.admUser.AutoSize = true;
            this.admUser.Location = new System.Drawing.Point(121, 148);
            this.admUser.Name = "admUser";
            this.admUser.Size = new System.Drawing.Size(62, 19);
            this.admUser.TabIndex = 6;
            this.admUser.Text = "Admin";
            this.admUser.UseVisualStyleBackColor = true;
            // 
            // edadUser
            // 
            this.edadUser.Location = new System.Drawing.Point(121, 115);
            this.edadUser.Name = "edadUser";
            this.edadUser.PlaceholderText = "Edad";
            this.edadUser.Size = new System.Drawing.Size(100, 23);
            this.edadUser.TabIndex = 5;
            // 
            // correoUser
            // 
            this.correoUser.Location = new System.Drawing.Point(121, 86);
            this.correoUser.Name = "correoUser";
            this.correoUser.PlaceholderText = "Correo";
            this.correoUser.Size = new System.Drawing.Size(100, 23);
            this.correoUser.TabIndex = 4;
            // 
            // nomUser
            // 
            this.nomUser.Location = new System.Drawing.Point(121, 57);
            this.nomUser.Name = "nomUser";
            this.nomUser.PlaceholderText = "Nombre";
            this.nomUser.Size = new System.Drawing.Size(100, 23);
            this.nomUser.TabIndex = 3;
            // 
            // cedUser
            // 
            this.cedUser.Location = new System.Drawing.Point(121, 28);
            this.cedUser.Name = "cedUser";
            this.cedUser.PlaceholderText = "Cedula";
            this.cedUser.Size = new System.Drawing.Size(100, 23);
            this.cedUser.TabIndex = 2;
            // 
            // buscarFoto
            // 
            this.buscarFoto.Location = new System.Drawing.Point(22, 144);
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
            this.fotoUser.Location = new System.Drawing.Point(22, 38);
            this.fotoUser.Name = "fotoUser";
            this.fotoUser.Size = new System.Drawing.Size(75, 100);
            this.fotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUser.TabIndex = 0;
            this.fotoUser.TabStop = false;
            // 
            // cerrar
            // 
            this.cerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cerrar.Location = new System.Drawing.Point(209, 1);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(27, 23);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 281);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoUser);
            this.Controls.Add(this.admUser);
            this.Controls.Add(this.buscarFoto);
            this.Controls.Add(this.edadUser);
            this.Controls.Add(this.cedUser);
            this.Controls.Add(this.correoUser);
            this.Controls.Add(this.nomUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fotoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buscarFoto;
        private Button button1;
        public PictureBox fotoUser;
        public CheckBox admUser;
        public TextBox edadUser;
        public TextBox correoUser;
        public TextBox nomUser;
        public TextBox cedUser;
        private Button cerrar;
    }
}