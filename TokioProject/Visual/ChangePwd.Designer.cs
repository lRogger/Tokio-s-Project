namespace TokiosProject.Visual
{
    partial class ChangePwd
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
            this.tbPwdAnt = new CustomControls.RJControls.RJTextBox();
            this.tbPwdNew = new CustomControls.RJControls.RJTextBox();
            this.tbPwdRep = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton1 = new Individual.Visual.ComponentesMod.RJButton();
            this.btnCerrar = new Individual.Visual.ComponentesMod.RJButton();
            this.SuspendLayout();
            // 
            // tbPwdAnt
            // 
            this.tbPwdAnt.BackColor = System.Drawing.SystemColors.Window;
            this.tbPwdAnt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.tbPwdAnt.BorderFocusColor = System.Drawing.Color.LightSteelBlue;
            this.tbPwdAnt.BorderRadius = 10;
            this.tbPwdAnt.BorderSize = 1;
            this.tbPwdAnt.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPwdAnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPwdAnt.Location = new System.Drawing.Point(38, 108);
            this.tbPwdAnt.Margin = new System.Windows.Forms.Padding(4);
            this.tbPwdAnt.Multiline = false;
            this.tbPwdAnt.Name = "tbPwdAnt";
            this.tbPwdAnt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPwdAnt.PasswordChar = true;
            this.tbPwdAnt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPwdAnt.PlaceholderText = "🔑 Contraseña";
            this.tbPwdAnt.Size = new System.Drawing.Size(311, 31);
            this.tbPwdAnt.TabIndex = 0;
            this.tbPwdAnt.Texts = "";
            this.tbPwdAnt.UnderlinedStyle = false;
            this.tbPwdAnt._TextChanged += new System.EventHandler(this.tbPwdAnt__TextChanged);
            this.tbPwdAnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPwdAnt_KeyPress);
            // 
            // tbPwdNew
            // 
            this.tbPwdNew.BackColor = System.Drawing.SystemColors.Window;
            this.tbPwdNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.tbPwdNew.BorderFocusColor = System.Drawing.Color.LightSteelBlue;
            this.tbPwdNew.BorderRadius = 10;
            this.tbPwdNew.BorderSize = 1;
            this.tbPwdNew.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPwdNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPwdNew.Location = new System.Drawing.Point(38, 174);
            this.tbPwdNew.Margin = new System.Windows.Forms.Padding(4);
            this.tbPwdNew.Multiline = false;
            this.tbPwdNew.Name = "tbPwdNew";
            this.tbPwdNew.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPwdNew.PasswordChar = true;
            this.tbPwdNew.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPwdNew.PlaceholderText = "🔑 Nueva Contraseña";
            this.tbPwdNew.Size = new System.Drawing.Size(311, 31);
            this.tbPwdNew.TabIndex = 1;
            this.tbPwdNew.Texts = "";
            this.tbPwdNew.UnderlinedStyle = false;
            this.tbPwdNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPwdAnt_KeyPress);
            // 
            // tbPwdRep
            // 
            this.tbPwdRep.BackColor = System.Drawing.SystemColors.Window;
            this.tbPwdRep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.tbPwdRep.BorderFocusColor = System.Drawing.Color.LightSteelBlue;
            this.tbPwdRep.BorderRadius = 10;
            this.tbPwdRep.BorderSize = 1;
            this.tbPwdRep.Font = new System.Drawing.Font("Britanica-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPwdRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPwdRep.Location = new System.Drawing.Point(38, 213);
            this.tbPwdRep.Margin = new System.Windows.Forms.Padding(4);
            this.tbPwdRep.Multiline = false;
            this.tbPwdRep.Name = "tbPwdRep";
            this.tbPwdRep.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPwdRep.PasswordChar = true;
            this.tbPwdRep.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPwdRep.PlaceholderText = "🔑 Repetir Contraseña";
            this.tbPwdRep.Size = new System.Drawing.Size(311, 31);
            this.tbPwdRep.TabIndex = 2;
            this.tbPwdRep.Texts = "";
            this.tbPwdRep.UnderlinedStyle = false;
            this.tbPwdRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPwdAnt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britanica-Heavy", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britanica-Heavy", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britanica-Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(38, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cambiar Contraseña";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(38, 263);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(155, 36);
            this.rjButton1.TabIndex = 8;
            this.rjButton1.Text = "Cambiar ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.BorderRadius = 15;
            this.btnCerrar.BorderSize = 2;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Britanica-Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.Location = new System.Drawing.Point(199, 263);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 36);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(27)))), ((int)(((byte)(141)))));
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 346);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPwdRep);
            this.Controls.Add(this.tbPwdNew);
            this.Controls.Add(this.tbPwdAnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePwd";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePwd_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tbPwdAnt;
        private CustomControls.RJControls.RJTextBox tbPwdNew;
        private CustomControls.RJControls.RJTextBox tbPwdRep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Individual.Visual.ComponentesMod.RJButton rjButton1;
        private Individual.Visual.ComponentesMod.RJButton btnCerrar;
    }
}