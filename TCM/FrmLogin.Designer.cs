namespace TCM
{
    partial class FrmLogin
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
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.ptbLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(183, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(218, 48);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(161, 20);
			this.txtUser.TabIndex = 1;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(218, 84);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '•';
			this.txtPass.Size = new System.Drawing.Size(161, 20);
			this.txtPass.TabIndex = 3;
			this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(177, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Senha";
			// 
			// btnCancel
			// 
			this.btnCancel.BackgroundImage = global::TCM.Properties.Resources.CANCELAR_1;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCancel.Location = new System.Drawing.Point(282, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(108, 39);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackgroundImage = global::TCM.Properties.Resources.LOGIN_1;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogin.Location = new System.Drawing.Point(168, 120);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(108, 39);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// ptbLogo
			// 
			this.ptbLogo.Image = global::TCM.Properties.Resources.logo;
			this.ptbLogo.Location = new System.Drawing.Point(12, 22);
			this.ptbLogo.Name = "ptbLogo";
			this.ptbLogo.Size = new System.Drawing.Size(157, 157);
			this.ptbLogo.TabIndex = 4;
			this.ptbLogo.TabStop = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 202);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.ptbLogo);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

