namespace GUIs.Visual
{
    partial class NewMateriaPrima
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
            lblTitulo = new Label();
            panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            fechaUltCompra = new DateTimePicker();
            tbProveedor = new CustomControls.RJControls.RJTextBox();
            txtStock = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            tbDescrip = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtPrecio = new CustomControls.RJControls.RJTextBox();
            txtNombre = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Individual.Visual.ComponentesMod.RJButton();
            btnCancelar = new Individual.Visual.ComponentesMod.RJButton();
            panelMod1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(128, 27, 141);
            lblTitulo.Location = new Point(23, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva Materia Prima";
            // 
            // panelMod1
            // 
            panelMod1.BackColor = Color.White;
            panelMod1.BorderRadius = 40;
            panelMod1.Controls.Add(fechaUltCompra);
            panelMod1.Controls.Add(tbProveedor);
            panelMod1.Controls.Add(txtStock);
            panelMod1.Controls.Add(label1);
            panelMod1.Controls.Add(tbDescrip);
            panelMod1.Controls.Add(label7);
            panelMod1.Controls.Add(label6);
            panelMod1.Controls.Add(label4);
            panelMod1.Controls.Add(txtPrecio);
            panelMod1.Controls.Add(txtNombre);
            panelMod1.Controls.Add(label3);
            panelMod1.Controls.Add(label2);
            panelMod1.ForeColor = Color.Black;
            panelMod1.GradientAngle = 90F;
            panelMod1.GradientBottomColor = Color.White;
            panelMod1.GradientTopColor = Color.White;
            panelMod1.Location = new Point(23, 73);
            panelMod1.Name = "panelMod1";
            panelMod1.Size = new Size(500, 280);
            panelMod1.TabIndex = 1;
            // 
            // fechaUltCompra
            // 
            fechaUltCompra.CalendarTitleBackColor = SystemColors.ControlText;
            fechaUltCompra.CalendarTitleForeColor = SystemColors.GrayText;
            fechaUltCompra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fechaUltCompra.Format = DateTimePickerFormat.Short;
            fechaUltCompra.Location = new Point(364, 79);
            fechaUltCompra.Name = "fechaUltCompra";
            fechaUltCompra.Size = new Size(121, 26);
            fechaUltCompra.TabIndex = 15;
            // 
            // tbProveedor
            // 
            tbProveedor.BackColor = Color.White;
            tbProveedor.BorderColor = SystemColors.ActiveBorder;
            tbProveedor.BorderFocusColor = SystemColors.ActiveCaption;
            tbProveedor.BorderRadius = 10;
            tbProveedor.BorderSize = 1;
            tbProveedor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            tbProveedor.Location = new Point(90, 76);
            tbProveedor.Margin = new Padding(4);
            tbProveedor.Multiline = false;
            tbProveedor.Name = "tbProveedor";
            tbProveedor.Padding = new Padding(10, 7, 10, 7);
            tbProveedor.PasswordChar = false;
            tbProveedor.PlaceholderColor = Color.DarkGray;
            tbProveedor.PlaceholderText = "";
            tbProveedor.Size = new Size(151, 31);
            tbProveedor.TabIndex = 14;
            tbProveedor.Texts = "";
            tbProveedor.UnderlinedStyle = false;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.White;
            txtStock.BorderColor = SystemColors.ActiveBorder;
            txtStock.BorderFocusColor = SystemColors.ActiveCaption;
            txtStock.BorderRadius = 10;
            txtStock.BorderSize = 1;
            txtStock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.FromArgb(64, 64, 64);
            txtStock.Location = new Point(426, 27);
            txtStock.Margin = new Padding(4);
            txtStock.Multiline = false;
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(10, 7, 10, 7);
            txtStock.PasswordChar = false;
            txtStock.PlaceholderColor = Color.DarkGray;
            txtStock.PlaceholderText = "";
            txtStock.Size = new Size(59, 31);
            txtStock.TabIndex = 13;
            txtStock.Texts = "";
            txtStock.UnderlinedStyle = false;
            txtStock.KeyPress += tbStock_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(376, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 12;
            label1.Text = "Stock:";
            // 
            // tbDescrip
            // 
            tbDescrip.BackColor = Color.White;
            tbDescrip.BorderColor = SystemColors.ActiveBorder;
            tbDescrip.BorderFocusColor = SystemColors.ActiveCaption;
            tbDescrip.BorderRadius = 10;
            tbDescrip.BorderSize = 1;
            tbDescrip.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescrip.ForeColor = Color.FromArgb(64, 64, 64);
            tbDescrip.Location = new Point(106, 128);
            tbDescrip.Margin = new Padding(4);
            tbDescrip.Multiline = true;
            tbDescrip.Name = "tbDescrip";
            tbDescrip.Padding = new Padding(10, 7, 10, 7);
            tbDescrip.PasswordChar = false;
            tbDescrip.PlaceholderColor = Color.DarkGray;
            tbDescrip.PlaceholderText = "";
            tbDescrip.Size = new Size(379, 125);
            tbDescrip.TabIndex = 9;
            tbDescrip.Texts = "";
            tbDescrip.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(9, 128);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 8;
            label7.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(248, 82);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "Última compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(9, 82);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 4;
            label4.Text = "Proveedor:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderColor = SystemColors.ActiveBorder;
            txtPrecio.BorderFocusColor = SystemColors.ActiveCaption;
            txtPrecio.BorderRadius = 10;
            txtPrecio.BorderSize = 1;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrecio.Location = new Point(313, 27);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(10, 7, 10, 7);
            txtPrecio.PasswordChar = false;
            txtPrecio.PlaceholderColor = Color.DarkGray;
            txtPrecio.PlaceholderText = "";
            txtPrecio.Size = new Size(59, 31);
            txtPrecio.TabIndex = 3;
            txtPrecio.Texts = "";
            txtPrecio.UnderlinedStyle = false;
            txtPrecio.KeyPress += tbPrecio_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderColor = SystemColors.ActiveBorder;
            txtNombre.BorderFocusColor = SystemColors.ActiveCaption;
            txtNombre.BorderRadius = 10;
            txtNombre.BorderSize = 1;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(74, 27);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(10, 7, 10, 7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(167, 31);
            txtNombre.TabIndex = 2;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = false;
            txtNombre.KeyPress += tbNombreProd_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(248, 33);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Precio/u:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(9, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 15;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(388, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BackgroundColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(128, 27, 141);
            btnCancelar.BorderRadius = 15;
            btnCancelar.BorderSize = 2;
            btnCancelar.DialogResult = DialogResult.Abort;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(128, 27, 141);
            btnCancelar.Location = new Point(247, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.FromArgb(128, 27, 141);
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NewMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 430);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panelMod1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewMateriaPrima";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMateriaPrima";
            MouseMove += NewProduct_MouseMove;
            panelMod1.ResumeLayout(false);
            panelMod1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private Label label3;
        private Label label2;
        private Individual.Visual.ComponentesMod.RJButton btnGuardar;
        private Individual.Visual.ComponentesMod.RJButton btnCancelar;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label1;
        public CustomControls.RJControls.RJTextBox txtPrecio;
        public CustomControls.RJControls.RJTextBox txtNombre;
        public CustomControls.RJControls.RJTextBox tbDescrip;
        public CustomControls.RJControls.RJTextBox txtStock;
        public Label lblTitulo;
        public CustomControls.RJControls.RJTextBox tbProveedor;
        public DateTimePicker fechaUltCompra;
    }
}