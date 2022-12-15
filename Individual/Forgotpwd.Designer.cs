namespace Individual
{
    partial class Forgotpwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correofpwd = new System.Windows.Forms.TextBox();
            this.cedulafpwd = new System.Windows.Forms.TextBox();
            this.BtnValidarFp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.newpwd = new System.Windows.Forms.TextBox();
            this.newpwd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu cédula:";
            // 
            // correofpwd
            // 
            this.correofpwd.Location = new System.Drawing.Point(141, 15);
            this.correofpwd.Name = "correofpwd";
            this.correofpwd.Size = new System.Drawing.Size(100, 23);
            this.correofpwd.TabIndex = 2;
            // 
            // cedulafpwd
            // 
            this.cedulafpwd.Location = new System.Drawing.Point(141, 41);
            this.cedulafpwd.Name = "cedulafpwd";
            this.cedulafpwd.Size = new System.Drawing.Size(100, 23);
            this.cedulafpwd.TabIndex = 3;
            this.cedulafpwd.TextChanged += new System.EventHandler(this.cedulafpwd_TextChanged);
            this.cedulafpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulafpwd_KeyPress);
            // 
            // BtnValidarFp
            // 
            this.BtnValidarFp.Location = new System.Drawing.Point(91, 79);
            this.BtnValidarFp.Name = "BtnValidarFp";
            this.BtnValidarFp.Size = new System.Drawing.Size(75, 23);
            this.BtnValidarFp.TabIndex = 4;
            this.BtnValidarFp.Text = "Validar";
            this.BtnValidarFp.UseVisualStyleBackColor = true;
            this.BtnValidarFp.Click += new System.EventHandler(this.BtnValidarFp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir contraseña";
            // 
            // enviar
            // 
            this.enviar.Enabled = false;
            this.enviar.Location = new System.Drawing.Point(91, 193);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Cambiar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // newpwd
            // 
            this.newpwd.Enabled = false;
            this.newpwd.Location = new System.Drawing.Point(141, 123);
            this.newpwd.Name = "newpwd";
            this.newpwd.PasswordChar = '●';
            this.newpwd.Size = new System.Drawing.Size(100, 23);
            this.newpwd.TabIndex = 8;
            // 
            // newpwd2
            // 
            this.newpwd2.Enabled = false;
            this.newpwd2.Location = new System.Drawing.Point(141, 152);
            this.newpwd2.Name = "newpwd2";
            this.newpwd2.PasswordChar = '●';
            this.newpwd2.Size = new System.Drawing.Size(100, 23);
            this.newpwd2.TabIndex = 9;
            this.newpwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpwd2_KeyPress);
            // 
            // Forgotpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 228);
            this.Controls.Add(this.newpwd2);
            this.Controls.Add(this.newpwd);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnValidarFp);
            this.Controls.Add(this.cedulafpwd);
            this.Controls.Add(this.correofpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgotpwd";
            this.Text = "Forgotpwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox correofpwd;
        private TextBox cedulafpwd;
        private Button BtnValidarFp;
        private Label label3;
        private Label label4;
        private Button enviar;
        private TextBox newpwd;
        private TextBox newpwd2;
    }
}