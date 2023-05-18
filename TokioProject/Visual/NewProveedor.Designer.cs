namespace Individual.Visual
{
    partial class NewProveedor
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
            telefProveedor = new TextBox();
            correoProveedor = new TextBox();
            nomProveedor = new TextBox();
            cedProveedor = new TextBox();
            btnGuardar = new ComponentesMod.RJButton();
            panelMod1 = new ComponentesMod.PanelMod();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            fotoUser = new PictureBox();
            btnCerrar = new ComponentesMod.RJButton();
            lblTitulo = new Label();
            panelMod1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotoUser).BeginInit();
            SuspendLayout();
            // 
            // telefProveedor
            // 
            telefProveedor.BorderStyle = BorderStyle.FixedSingle;
            telefProveedor.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            telefProveedor.Location = new Point(223, 139);
            telefProveedor.MinimumSize = new Size(0, 27);
            telefProveedor.Name = "telefProveedor";
            telefProveedor.Size = new Size(185, 27);
            telefProveedor.TabIndex = 5;
            telefProveedor.KeyPress += telefProveedor_KeyPress;
            // 
            // correoProveedor
            // 
            correoProveedor.BorderStyle = BorderStyle.FixedSingle;
            correoProveedor.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            correoProveedor.Location = new Point(223, 104);
            correoProveedor.MinimumSize = new Size(0, 27);
            correoProveedor.Name = "correoProveedor";
            correoProveedor.Size = new Size(185, 27);
            correoProveedor.TabIndex = 4;
            // 
            // nomProveedor
            // 
            nomProveedor.BorderStyle = BorderStyle.FixedSingle;
            nomProveedor.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            nomProveedor.Location = new Point(223, 68);
            nomProveedor.MaximumSize = new Size(0, 25);
            nomProveedor.MinimumSize = new Size(0, 27);
            nomProveedor.Name = "nomProveedor";
            nomProveedor.Size = new Size(185, 27);
            nomProveedor.TabIndex = 3;
            nomProveedor.KeyPress += nomProveedor_KeyPress;
            // 
            // cedProveedor
            // 
            cedProveedor.BorderStyle = BorderStyle.FixedSingle;
            cedProveedor.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cedProveedor.Location = new Point(256, 35);
            cedProveedor.MaximumSize = new Size(200, 25);
            cedProveedor.MaxLength = 13;
            cedProveedor.MinimumSize = new Size(0, 27);
            cedProveedor.Name = "cedProveedor";
            cedProveedor.Size = new Size(152, 27);
            cedProveedor.TabIndex = 2;
            cedProveedor.KeyPress += cedProveedor_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BorderColor = Color.FromArgb(224, 224, 224);
            btnGuardar.BorderRadius = 15;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(339, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 35);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panelMod1
            // 
            panelMod1.BackColor = Color.White;
            panelMod1.BorderRadius = 25;
            panelMod1.Controls.Add(label4);
            panelMod1.Controls.Add(label3);
            panelMod1.Controls.Add(label1);
            panelMod1.Controls.Add(label2);
            panelMod1.Controls.Add(telefProveedor);
            panelMod1.Controls.Add(cedProveedor);
            panelMod1.Controls.Add(correoProveedor);
            panelMod1.Controls.Add(fotoUser);
            panelMod1.Controls.Add(nomProveedor);
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
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Teléfono:";
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
            label2.Size = new Size(102, 20);
            label2.TabIndex = 7;
            label2.Text = "Cedula/RUC:";
            // 
            // fotoUser
            // 
            fotoUser.BackColor = Color.WhiteSmoke;
            fotoUser.Image = GUIs.Properties.Resources.ProveedorIcon;
            fotoUser.Location = new Point(42, 49);
            fotoUser.Name = "fotoUser";
            fotoUser.Size = new Size(100, 100);
            fotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoUser.TabIndex = 0;
            fotoUser.TabStop = false;
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
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(128, 27, 141);
            lblTitulo.Location = new Point(24, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 39);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Nuevo Proveedor";
            // 
            // NewProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(500, 350);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            Controls.Add(lblTitulo);
            Controls.Add(panelMod1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewUser";
            Load += NewUser_Load;
            MouseMove += NewUser_MouseMove;
            panelMod1.ResumeLayout(false);
            panelMod1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fotoUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox telefProveedor;
        public TextBox correoProveedor;
        public TextBox nomProveedor;
        public TextBox cedProveedor;
        private ComponentesMod.RJButton btnGuardar;
        private ComponentesMod.PanelMod panelMod1;
        private ComponentesMod.RJButton btnCerrar;
        private Label lblTitulo;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        public PictureBox fotoUser;
    }
}