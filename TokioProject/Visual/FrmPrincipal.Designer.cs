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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.profileP = new System.Windows.Forms.PictureBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuConfig = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.profileP)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMod1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileP
            // 
            this.profileP.BackColor = System.Drawing.Color.DimGray;
            this.profileP.ErrorImage = null;
            this.profileP.Image = ((System.Drawing.Image)(resources.GetObject("profileP.Image")));
            this.profileP.Location = new System.Drawing.Point(475, 3);
            this.profileP.Name = "profileP";
            this.profileP.Size = new System.Drawing.Size(50, 50);
            this.profileP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileP.TabIndex = 8;
            this.profileP.TabStop = false;
            // 
            // lblSesion
            // 
            this.lblSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSesion.Font = new System.Drawing.Font("Britanica-Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSesion.ForeColor = System.Drawing.Color.DimGray;
            this.lblSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSesion.Location = new System.Drawing.Point(0, 0);
            this.lblSesion.Margin = new System.Windows.Forms.Padding(0);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(289, 35);
            this.lblSesion.TabIndex = 10;
            this.lblSesion.Text = "Nombre Completo";
            this.lblSesion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSesion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSesion_MouseMove);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrincipal.Location = new System.Drawing.Point(190, 80);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(560, 470);
            this.panelPrincipal.TabIndex = 20;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(240, 35);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(43, 16);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAdmin.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.profileP);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(210, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(528, 60);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSesion);
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Location = new System.Drawing.Point(176, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 58);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 0;
            this.panelMod1.Controls.Add(this.tableLayoutPanel1);
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panelMod1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(190, 551);
            this.panelMod1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cerrarSesion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.95745F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.95745F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.05206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.33898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnProductos);
            this.flowLayoutPanel1.Controls.Add(this.btnUsuarios);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistros);
            this.flowLayoutPanel1.Controls.Add(this.btnConfig);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Britanica-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 5);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(190, 65);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "   👕 Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Britanica-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 80);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(190, 63);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "   🙍‍♂️ Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Visible = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnRegistros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Britanica-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistros.ForeColor = System.Drawing.Color.White;
            this.btnRegistros.Location = new System.Drawing.Point(0, 153);
            this.btnRegistros.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(190, 65);
            this.btnRegistros.TabIndex = 1;
            this.btnRegistros.Text = "   📄 Registros";
            this.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Visible = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Britanica-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(0, 228);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(190, 71);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "   ⚙ Configuración";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.cerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion.Font = new System.Drawing.Font("Britanica-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.cerrarSesion.Location = new System.Drawing.Point(3, 478);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(184, 70);
            this.cerrarSesion.TabIndex = 4;
            this.cerrarSesion.Text = "← Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = false;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 551);
            this.panel1.TabIndex = 26;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menuConfig
            // 
            this.menuConfig.IsMainMenu = false;
            this.menuConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.menuConfig.MenuItemHeight = 25;
            this.menuConfig.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.PrimaryColor = System.Drawing.Color.Empty;
            this.menuConfig.Size = new System.Drawing.Size(183, 48);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panelMod1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileP)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMod1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuConfig.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}



