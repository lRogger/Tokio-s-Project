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
            admUser = new CheckBox();
            edadUser = new TextBox();
            correoUser = new TextBox();
            nomUser = new TextBox();
            cedUser = new TextBox();
            buscarFoto = new Button();
            fotoUser = new PictureBox();
            btnEnviar = new ComponentesMod.RJButton();
            panelMod1 = new ComponentesMod.PanelMod();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCerrar = new ComponentesMod.RJButton();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoUser).BeginInit();
            panelMod1.SuspendLayout();
            SuspendLayout();
            // 
            // admUser
            // 
            admUser.AutoSize = true;
            admUser.BackColor = Color.WhiteSmoke;
            admUser.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            admUser.Location = new Point(343, 38);
            admUser.Name = "admUser";
            admUser.Size = new Size(64, 20);
            admUser.TabIndex = 6;
            admUser.Text = "Admin";
            admUser.UseVisualStyleBackColor = false;
            // 
            // edadUser
            // 
            edadUser.BorderStyle = BorderStyle.FixedSingle;
            edadUser.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            edadUser.Location = new Point(215, 139);
            edadUser.MaxLength = 3;
            edadUser.MinimumSize = new Size(0, 27);
            edadUser.Name = "edadUser";
            edadUser.Size = new Size(190, 27);
            edadUser.TabIndex = 5;
            edadUser.KeyPress += edadUser_KeyPress;
            // 
            // correoUser
            // 
            correoUser.BorderStyle = BorderStyle.FixedSingle;
            correoUser.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            correoUser.Location = new Point(215, 104);
            correoUser.MinimumSize = new Size(0, 27);
            correoUser.Name = "correoUser";
            correoUser.Size = new Size(190, 27);
            correoUser.TabIndex = 4;
            // 
            // nomUser
            // 
            nomUser.BorderStyle = BorderStyle.FixedSingle;
            nomUser.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            nomUser.Location = new Point(215, 68);
            nomUser.MaximumSize = new Size(0, 25);
            nomUser.MinimumSize = new Size(0, 27);
            nomUser.Name = "nomUser";
            nomUser.Size = new Size(190, 27);
            nomUser.TabIndex = 3;
            nomUser.KeyPress += nomUser_KeyPress;
            // 
            // cedUser
            // 
            cedUser.BorderStyle = BorderStyle.FixedSingle;
            cedUser.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cedUser.Location = new Point(215, 34);
            cedUser.MaximumSize = new Size(200, 25);
            cedUser.MaxLength = 10;
            cedUser.MinimumSize = new Size(0, 27);
            cedUser.Name = "cedUser";
            cedUser.Size = new Size(122, 27);
            cedUser.TabIndex = 2;
            cedUser.KeyPress += cedUser_KeyPress;
            // 
            // buscarFoto
            // 
            buscarFoto.BackColor = Color.DimGray;
            buscarFoto.FlatAppearance.BorderColor = Color.DimGray;
            buscarFoto.FlatAppearance.BorderSize = 2;
            buscarFoto.FlatStyle = FlatStyle.System;
            buscarFoto.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            buscarFoto.ForeColor = Color.White;
            buscarFoto.Location = new Point(38, 141);
            buscarFoto.Name = "buscarFoto";
            buscarFoto.Size = new Size(100, 25);
            buscarFoto.TabIndex = 1;
            buscarFoto.Text = "Añadir Foto";
            buscarFoto.UseVisualStyleBackColor = false;
            buscarFoto.Click += buscarFoto_Click;
            // 
            // fotoUser
            // 
            fotoUser.BackColor = Color.WhiteSmoke;
            fotoUser.Location = new Point(38, 35);
            fotoUser.Name = "fotoUser";
            fotoUser.Size = new Size(100, 100);
            fotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoUser.TabIndex = 0;
            fotoUser.TabStop = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(128, 27, 141);
            btnEnviar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnEnviar.BorderColor = Color.FromArgb(224, 224, 224);
            btnEnviar.BorderRadius = 15;
            btnEnviar.BorderSize = 0;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(339, 289);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(135, 35);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Guardar";
            btnEnviar.TextColor = Color.White;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // panelMod1
            // 
            panelMod1.BackColor = Color.White;
            panelMod1.BorderRadius = 25;
            panelMod1.Controls.Add(label4);
            panelMod1.Controls.Add(label3);
            panelMod1.Controls.Add(label1);
            panelMod1.Controls.Add(label2);
            panelMod1.Controls.Add(edadUser);
            panelMod1.Controls.Add(admUser);
            panelMod1.Controls.Add(cedUser);
            panelMod1.Controls.Add(correoUser);
            panelMod1.Controls.Add(fotoUser);
            panelMod1.Controls.Add(nomUser);
            panelMod1.Controls.Add(buscarFoto);
            panelMod1.ForeColor = Color.Black;
            panelMod1.GradientAngle = 90F;
            panelMod1.GradientBottomColor = Color.White;
            panelMod1.GradientTopColor = Color.White;
            panelMod1.Location = new Point(24, 73);
            panelMod1.Name = "panelMod1";
            panelMod1.Size = new Size(450, 200);
            panelMod1.TabIndex = 12;
            panelMod1.MouseMove += panelMod1_MouseMove;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(148, 143);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 10;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(148, 108);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(148, 72);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(148, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "Cedula:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundColor = Color.Transparent;
            btnCerrar.BorderColor = Color.FromArgb(128, 27, 141);
            btnCerrar.BorderRadius = 15;
            btnCerrar.BorderSize = 2;
            btnCerrar.DialogResult = DialogResult.Abort;
            btnCerrar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(128, 27, 141);
            btnCerrar.Location = new Point(218, 289);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(115, 35);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cancelar";
            btnCerrar.TextColor = Color.FromArgb(128, 27, 141);
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(128, 27, 141);
            lblTitulo.Location = new Point(24, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(246, 39);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Nuevo Usuario";
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(500, 350);
            Controls.Add(btnEnviar);
            Controls.Add(btnCerrar);
            Controls.Add(lblTitulo);
            Controls.Add(panelMod1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewUser";
            Load += NewUser_Load;
            MouseMove += NewUser_MouseMove;
            ((System.ComponentModel.ISupportInitialize)fotoUser).EndInit();
            panelMod1.ResumeLayout(false);
            panelMod1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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