namespace TCM
{
	partial class FrmCadastroProf
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtCel = new System.Windows.Forms.MaskedTextBox();
			this.txtFone = new System.Windows.Forms.MaskedTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtRG = new System.Windows.Forms.MaskedTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCEP = new System.Windows.Forms.MaskedTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(532, 322);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtCel
			// 
			this.txtCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCel.Location = new System.Drawing.Point(259, 222);
			this.txtCel.Mask = "(99) 99999-9999";
			this.txtCel.Name = "txtCel";
			this.txtCel.Size = new System.Drawing.Size(86, 20);
			this.txtCel.TabIndex = 11;
			this.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtFone
			// 
			this.txtFone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtFone.Location = new System.Drawing.Point(129, 222);
			this.txtFone.Mask = "(99) 9999-9999";
			this.txtFone.Name = "txtFone";
			this.txtFone.Size = new System.Drawing.Size(79, 20);
			this.txtFone.TabIndex = 10;
			this.txtFone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(532, 149);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(19, 13);
			this.label15.TabIndex = 65;
			this.label15.Text = "N°";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(552, 145);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(55, 20);
			this.txtNum.TabIndex = 5;
			// 
			// txtCPF
			// 
			this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCPF.Location = new System.Drawing.Point(256, 120);
			this.txtCPF.Mask = "999.999.999-99";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(81, 20);
			this.txtCPF.TabIndex = 3;
			this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtRG
			// 
			this.txtRG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtRG.Location = new System.Drawing.Point(129, 120);
			this.txtRG.Mask = "99.999.999-9";
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(70, 20);
			this.txtRG.TabIndex = 2;
			this.txtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(220, 124);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 13);
			this.label14.TabIndex = 61;
			this.label14.Text = "CPF";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(97, 124);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 13);
			this.label13.TabIndex = 60;
			this.label13.Text = "RG";
			// 
			// txtCEP
			// 
			this.txtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtCEP.Location = new System.Drawing.Point(129, 197);
			this.txtCEP.Mask = "99999-999";
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(57, 20);
			this.txtCEP.TabIndex = 7;
			this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(237, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(168, 20);
			this.label12.TabIndex = 58;
			this.label12.Text = "Cadastro de Professor";
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(210, 322);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 15;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(129, 322);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 14;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(86, 175);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 13);
			this.label10.TabIndex = 53;
			this.label10.Text = "Bairro";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(129, 171);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(374, 20);
			this.txtBairro.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(84, 251);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 13);
			this.label9.TabIndex = 51;
			this.label9.Text = "E-Mail";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(128, 248);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(374, 20);
			this.txtEmail.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(214, 226);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 49;
			this.label8.Text = "Celular";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(73, 226);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 48;
			this.label7.Text = "Telefone";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(511, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 47;
			this.label6.Text = "Estado";
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(552, 197);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(55, 20);
			this.txtEstado.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(195, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 45;
			this.label5.Text = "Cidade";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(240, 198);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(262, 20);
			this.txtCidade.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(92, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 43;
			this.label4.Text = "CEP";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(93, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 40;
			this.label2.Text = "Rua";
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(129, 145);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(374, 20);
			this.txtRua.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 38;
			this.label1.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(129, 67);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(374, 20);
			this.txtNome.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(84, 277);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 13);
			this.label11.TabIndex = 70;
			this.label11.Text = "Senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(128, 274);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(374, 20);
			this.txtSenha.TabIndex = 13;
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Location = new System.Drawing.Point(129, 93);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(158, 21);
			this.cmbSexo.TabIndex = 1;
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(89, 96);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(31, 13);
			this.lblSexo.TabIndex = 71;
			this.lblSexo.Text = "Sexo";
			// 
			// FrmCadastroProf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtCel);
			this.Controls.Add(this.txtFone);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtCEP);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRua);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCadastroProf";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCadastroProf";
			this.Load += new System.EventHandler(this.FrmCadastroProf_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.MaskedTextBox txtCel;
		private System.Windows.Forms.MaskedTextBox txtFone;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.MaskedTextBox txtRG;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.MaskedTextBox txtCEP;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
	}
}