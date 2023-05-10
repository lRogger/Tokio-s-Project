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
            label1 = new Label();
            label2 = new Label();
            correofpwd = new TextBox();
            cedulafpwd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            newpwd = new TextBox();
            newpwd2 = new TextBox();
            btnCerrar = new Visual.ComponentesMod.RJButton();
            label5 = new Label();
            label6 = new Label();
            btnEnviar = new Visual.ComponentesMod.RJButton();
            btnValidar = new Visual.ComponentesMod.RJButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 80);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa tu Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 124);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa tu cédula:";
            // 
            // correofpwd
            // 
            correofpwd.Location = new Point(39, 98);
            correofpwd.Name = "correofpwd";
            correofpwd.Size = new Size(238, 23);
            correofpwd.TabIndex = 2;
            // 
            // cedulafpwd
            // 
            cedulafpwd.Location = new Point(39, 143);
            cedulafpwd.Name = "cedulafpwd";
            cedulafpwd.Size = new Size(157, 23);
            cedulafpwd.TabIndex = 3;
            cedulafpwd.KeyPress += cedulafpwd_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 230);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Nueva contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 275);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = "Repetir contraseña";
            // 
            // newpwd
            // 
            newpwd.Enabled = false;
            newpwd.Location = new Point(39, 248);
            newpwd.Name = "newpwd";
            newpwd.PasswordChar = '●';
            newpwd.Size = new Size(238, 23);
            newpwd.TabIndex = 8;
            // 
            // newpwd2
            // 
            newpwd2.Enabled = false;
            newpwd2.Location = new Point(39, 293);
            newpwd2.Name = "newpwd2";
            newpwd2.PasswordChar = '●';
            newpwd2.Size = new Size(238, 23);
            newpwd2.TabIndex = 9;
            newpwd2.KeyPress += newpwd2_KeyPress;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundColor = Color.Transparent;
            btnCerrar.BorderColor = Color.WhiteSmoke;
            btnCerrar.BorderRadius = 7;
            btnCerrar.BorderSize = 0;
            btnCerrar.DialogResult = DialogResult.Abort;
            btnCerrar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(168, 27, 141);
            btnCerrar.Location = new Point(271, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(38, 33);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "X";
            btnCerrar.TextColor = Color.FromArgb(168, 27, 141);
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(128, 27, 141);
            label5.Location = new Point(39, 50);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 12;
            label5.Text = "Verifique sus datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(128, 27, 141);
            label6.Location = new Point(39, 199);
            label6.Name = "label6";
            label6.Size = new Size(220, 25);
            label6.TabIndex = 13;
            label6.Text = "Actualice su contraseña";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(128, 27, 141);
            btnEnviar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnEnviar.BorderColor = Color.PaleVioletRed;
            btnEnviar.BorderRadius = 17;
            btnEnviar.BorderSize = 0;
            btnEnviar.Enabled = false;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(39, 339);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(238, 32);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Cambiar";
            btnEnviar.TextColor = Color.White;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(128, 27, 141);
            btnValidar.BackgroundColor = Color.FromArgb(128, 27, 141);
            btnValidar.BorderColor = Color.PaleVioletRed;
            btnValidar.BorderRadius = 12;
            btnValidar.BorderSize = 0;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(202, 143);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 24);
            btnValidar.TabIndex = 15;
            btnValidar.Text = "Validar";
            btnValidar.TextColor = Color.White;
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // Forgotpwd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(321, 433);
            Controls.Add(btnValidar);
            Controls.Add(btnEnviar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCerrar);
            Controls.Add(newpwd2);
            Controls.Add(newpwd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cedulafpwd);
            Controls.Add(correofpwd);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgotpwd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgotpwd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox correofpwd;
        private TextBox cedulafpwd;
        private Label label3;
        private Label label4;
        private TextBox newpwd;
        private TextBox newpwd2;
        private Visual.ComponentesMod.RJButton btnCerrar;
        private Label label5;
        private Label label6;
        private Visual.ComponentesMod.RJButton btnEnviar;
        private Visual.ComponentesMod.RJButton btnValidar;
    }
}