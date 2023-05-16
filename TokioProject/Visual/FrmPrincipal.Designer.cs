namespace Individual.Visual
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            profileP = new PictureBox();
            lblSesion = new Label();
            panelPrincipal = new Panel();
            lblAdmin = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            panelMod1 = new ComponentesMod.PanelMod();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnProductos = new Button();
            btnUsuarios = new Button();
            btnCommodities = new Button();
            btnProveedores = new Button();
            btnRegistros = new Button();
            btnBalance = new Button();
            btnConfig = new Button();
            cerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            menuConfig = new CustomControls.RJControls.RJDropdownMenu(components);
            editarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)profileP).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panelMod1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuConfig.SuspendLayout();
            SuspendLayout();
            // 
            // profileP
            // 
            profileP.BackColor = Color.DimGray;
            profileP.ErrorImage = null;
            profileP.Image = (Image)resources.GetObject("profileP.Image");
            profileP.Location = new Point(680, 3);
            profileP.Name = "profileP";
            profileP.Size = new Size(61, 58);
            profileP.SizeMode = PictureBoxSizeMode.StretchImage;
            profileP.TabIndex = 8;
            profileP.TabStop = false;
            // 
            // lblSesion
            // 
            lblSesion.FlatStyle = FlatStyle.Flat;
            lblSesion.Font = new Font("Britanica-Heavy", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSesion.ForeColor = Color.DimGray;
            lblSesion.ImageAlign = ContentAlignment.MiddleRight;
            lblSesion.Location = new Point(0, 0);
            lblSesion.Margin = new Padding(0);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(289, 35);
            lblSesion.TabIndex = 10;
            lblSesion.Text = "Nombre Completo";
            lblSesion.TextAlign = ContentAlignment.BottomRight;
            lblSesion.MouseMove += lblSesion_MouseMove;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.WhiteSmoke;
            panelPrincipal.Location = new Point(210, 100);
            panelPrincipal.Margin = new Padding(0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(744, 650);
            panelPrincipal.TabIndex = 20;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Britanica-Bold", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdmin.Location = new Point(240, 35);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(42, 16);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Admin";
            lblAdmin.TextAlign = ContentAlignment.BottomRight;
            lblAdmin.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(profileP);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(210, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(744, 85);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.MouseMove += flowLayoutPanel2_MouseMove;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSesion);
            panel2.Controls.Add(lblAdmin);
            panel2.Location = new Point(381, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 58);
            panel2.TabIndex = 1;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // panelMod1
            // 
            panelMod1.BackColor = Color.White;
            panelMod1.BorderRadius = 0;
            panelMod1.Controls.Add(tableLayoutPanel1);
            panelMod1.ForeColor = Color.Black;
            panelMod1.GradientAngle = 90F;
            panelMod1.GradientBottomColor = Color.FromArgb(128, 27, 141);
            panelMod1.GradientTopColor = Color.FromArgb(128, 27, 141);
            panelMod1.Location = new Point(0, 0);
            panelMod1.Name = "panelMod1";
            panelMod1.Size = new Size(204, 751);
            panelMod1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(128, 27, 141);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(cerrarSesion, 0, 7);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.39301F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.393013F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.393013F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.393013F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.0769234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(204, 751);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnProductos);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnCommodities);
            flowLayoutPanel1.Controls.Add(btnProveedores);
            flowLayoutPanel1.Controls.Add(btnRegistros);
            flowLayoutPanel1.Controls.Add(btnBalance);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 102);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            tableLayoutPanel1.SetRowSpan(flowLayoutPanel1, 6);
            flowLayoutPanel1.Size = new Size(198, 566);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(128, 27, 141);
            btnProductos.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 5);
            btnProductos.Margin = new Padding(0, 5, 0, 5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(198, 65);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "   👕 Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(128, 27, 141);
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 80);
            btnUsuarios.Margin = new Padding(0, 5, 0, 5);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(198, 63);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "   🙍‍♂️ Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Visible = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCommodities
            // 
            btnCommodities.BackColor = Color.FromArgb(128, 27, 141);
            btnCommodities.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnCommodities.FlatStyle = FlatStyle.Flat;
            btnCommodities.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommodities.ForeColor = Color.White;
            btnCommodities.Location = new Point(0, 153);
            btnCommodities.Margin = new Padding(0, 5, 0, 5);
            btnCommodities.Name = "btnCommodities";
            btnCommodities.Size = new Size(198, 65);
            btnCommodities.TabIndex = 3;
            btnCommodities.Text = "   \U0001f9f5 Commodities";
            btnCommodities.TextAlign = ContentAlignment.MiddleLeft;
            btnCommodities.UseVisualStyleBackColor = false;
            btnCommodities.Click += btnCommodities_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(128, 27, 141);
            btnProveedores.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(0, 228);
            btnProveedores.Margin = new Padding(0, 5, 0, 5);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(198, 65);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "   📦 Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.FromArgb(128, 27, 141);
            btnRegistros.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistros.ForeColor = Color.White;
            btnRegistros.Location = new Point(0, 303);
            btnRegistros.Margin = new Padding(0, 5, 0, 5);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(198, 65);
            btnRegistros.TabIndex = 1;
            btnRegistros.Text = "   📄 Registros";
            btnRegistros.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.FromArgb(128, 27, 141);
            btnBalance.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnBalance.FlatStyle = FlatStyle.Flat;
            btnBalance.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnBalance.ForeColor = Color.White;
            btnBalance.Location = new Point(0, 378);
            btnBalance.Margin = new Padding(0, 5, 0, 5);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(198, 65);
            btnBalance.TabIndex = 4;
            btnBalance.Text = "    💲 Balance";
            btnBalance.TextAlign = ContentAlignment.MiddleLeft;
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(128, 27, 141);
            btnConfig.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Britanica-Bold", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(0, 453);
            btnConfig.Margin = new Padding(0, 5, 0, 5);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(198, 71);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "   ⚙ Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click_1;
            // 
            // cerrarSesion
            // 
            cerrarSesion.BackColor = Color.FromArgb(128, 27, 141);
            cerrarSesion.Dock = DockStyle.Fill;
            cerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(100, 20, 100);
            cerrarSesion.FlatStyle = FlatStyle.Flat;
            cerrarSesion.Font = new Font("Britanica-Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cerrarSesion.ForeColor = Color.White;
            cerrarSesion.Location = new Point(3, 674);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(198, 74);
            cerrarSesion.TabIndex = 4;
            cerrarSesion.Text = "← Cerrar Sesión";
            cerrarSesion.UseVisualStyleBackColor = false;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 15);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelPrincipal);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 751);
            panel1.TabIndex = 26;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // menuConfig
            // 
            menuConfig.IsMainMenu = false;
            menuConfig.Items.AddRange(new ToolStripItem[] { editarUsuarioToolStripMenuItem, cambiarContraseñaToolStripMenuItem });
            menuConfig.MenuItemHeight = 25;
            menuConfig.MenuItemTextColor = Color.Empty;
            menuConfig.Name = "menuConfig";
            menuConfig.PrimaryColor = Color.Empty;
            menuConfig.Size = new Size(183, 48);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            editarUsuarioToolStripMenuItem.Size = new Size(182, 22);
            editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            editarUsuarioToolStripMenuItem.Click += editarUsuarioToolStripMenuItem_Click;
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(182, 22);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            cambiarContraseñaToolStripMenuItem.Click += cambiarContraseñaToolStripMenuItem_Click_1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 750);
            Controls.Add(panelMod1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)profileP).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMod1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuConfig.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private PictureBox profileP;
        private Label lblSesion;
        private Panel panelPrincipal;
        private ComponentesMod.PanelMod panelMod1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnProductos;
        private Button btnConfig;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private CustomControls.RJControls.RJDropdownMenu menuConfig;
        private ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        public Button btnUsuarios;
        public Label lblAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        public Button btnRegistros;
        private Button cerrarSesion;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnCommodities;
        public Button btnBalance;
        private Button btnProveedores;
    }
}



