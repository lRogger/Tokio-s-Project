namespace Individual.Visual
{
    partial class MantenimientoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuario));
            this.buscarUser = new System.Windows.Forms.TextBox();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.separador = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarUser
            // 
            this.buscarUser.BackColor = System.Drawing.Color.White;
            this.buscarUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscarUser.Location = new System.Drawing.Point(37, 102);
            this.buscarUser.Name = "buscarUser";
            this.buscarUser.PlaceholderText = " 🔎 Buscar...";
            this.buscarUser.Size = new System.Drawing.Size(685, 16);
            this.buscarUser.TabIndex = 1;
            this.buscarUser.TextChanged += new System.EventHandler(this.buscarUser_TextChanged);
            this.buscarUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarUser_KeyPress);
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            this.usersDGV.AllowUserToOrderColumns = true;
            this.usersDGV.AllowUserToResizeColumns = false;
            this.usersDGV.AllowUserToResizeRows = false;
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.BackgroundColor = System.Drawing.Color.White;
            this.usersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.EnableHeadersVisualStyles = false;
            this.usersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usersDGV.Location = new System.Drawing.Point(37, 126);
            this.usersDGV.Name = "usersDGV";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.usersDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersDGV.RowTemplate.Height = 25;
            this.usersDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(685, 529);
            this.usersDGV.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.White;
            this.editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.editar.Location = new System.Drawing.Point(171, 21);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(82, 43);
            this.editar.TabIndex = 5;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // crear
            // 
            this.crear.BackColor = System.Drawing.Color.White;
            this.crear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.crear.Location = new System.Drawing.Point(91, 21);
            this.crear.Margin = new System.Windows.Forms.Padding(0);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(76, 43);
            this.crear.TabIndex = 6;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.White;
            this.eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.eliminar.Location = new System.Drawing.Point(364, 21);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(87, 43);
            this.eliminar.TabIndex = 7;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnCerrar.BorderRadius = 10;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(625, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 33);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.Black;
            this.separador.Location = new System.Drawing.Point(37, 83);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(686, 2);
            this.separador.TabIndex = 9;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.White;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnRefrescar.Location = new System.Drawing.Point(259, 21);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(99, 43);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 684);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.usersDGV);
            this.Controls.Add(this.buscarUser);
            this.Controls.Add(this.separador);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoUsuario";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MantenimientoUsuario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox buscarUser;
        private Button editar;
        private Button crear;
        private Button eliminar;
        public DataGridView usersDGV;
        private ComponentesMod.RJButton btnCerrar;
        private Panel separador;
        private Button btnRefrescar;
    }
}