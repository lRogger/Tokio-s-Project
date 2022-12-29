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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRopaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.profileP = new System.Windows.Forms.PictureBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.adminMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(790, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(59, 20);
            this.menuUsuario.Text = "Usuario";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar usuario";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPersonasToolStripMenuItem,
            this.mantenimientoRopaToolStripMenuItem});
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(55, 20);
            this.adminMenu.Text = "Admin";
            this.adminMenu.Visible = false;
            // 
            // mantenimientoPersonasToolStripMenuItem
            // 
            this.mantenimientoPersonasToolStripMenuItem.Name = "mantenimientoPersonasToolStripMenuItem";
            this.mantenimientoPersonasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.mantenimientoPersonasToolStripMenuItem.Text = "Mantenimiento Personas";
            this.mantenimientoPersonasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPersonasToolStripMenuItem_Click);
            // 
            // mantenimientoRopaToolStripMenuItem
            // 
            this.mantenimientoRopaToolStripMenuItem.Name = "mantenimientoRopaToolStripMenuItem";
            this.mantenimientoRopaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.mantenimientoRopaToolStripMenuItem.Text = "Mantenimiento Ropa";
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Location = new System.Drawing.Point(662, 61);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(104, 23);
            this.cerrarSesion.TabIndex = 4;
            this.cerrarSesion.Text = "Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // profileP
            // 
            this.profileP.Location = new System.Drawing.Point(12, 37);
            this.profileP.Name = "profileP";
            this.profileP.Size = new System.Drawing.Size(70, 70);
            this.profileP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileP.TabIndex = 8;
            this.profileP.TabStop = false;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Location = new System.Drawing.Point(88, 37);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(62, 15);
            this.lblSesion.TabIndex = 10;
            this.lblSesion.Text = "Sesion: ___";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(108, 126);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(560, 400);
            this.panelPrincipal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "WORK IN PROGRESS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.profileP);
            this.Controls.Add(this.cerrarSesion);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private Button cerrarSesion;
        public ToolStripMenuItem adminMenu;
        private ToolStripMenuItem mantenimientoPersonasToolStripMenuItem;
        private ToolStripMenuItem mantenimientoRopaToolStripMenuItem;
        private PictureBox profileP;
        private Label lblSesion;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private Panel panelPrincipal;
        private Label label1;
    }
}



