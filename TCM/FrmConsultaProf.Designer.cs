namespace TCM
{
	partial class FrmConsultaProf
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
			this.dgvProf = new System.Windows.Forms.DataGridView();
			this.grpExibir = new System.Windows.Forms.GroupBox();
			this.btnExibir = new System.Windows.Forms.Button();
			this.rdbEnd = new System.Windows.Forms.RadioButton();
			this.rdbContato = new System.Windows.Forms.RadioButton();
			this.rdbPessoais = new System.Windows.Forms.RadioButton();
			this.grbPesquisa = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.cmbExibe = new System.Windows.Forms.ComboBox();
			this.grbModificar = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAlt = new System.Windows.Forms.TextBox();
			this.cmbAltCampo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
			this.grpExibir.SuspendLayout();
			this.grbPesquisa.SuspendLayout();
			this.grbModificar.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProf
			// 
			this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProf.Location = new System.Drawing.Point(12, 12);
			this.dgvProf.Name = "dgvProf";
			this.dgvProf.Size = new System.Drawing.Size(771, 306);
			this.dgvProf.TabIndex = 0;
			// 
			// grpExibir
			// 
			this.grpExibir.Controls.Add(this.btnExibir);
			this.grpExibir.Controls.Add(this.rdbEnd);
			this.grpExibir.Controls.Add(this.rdbContato);
			this.grpExibir.Controls.Add(this.rdbPessoais);
			this.grpExibir.Location = new System.Drawing.Point(13, 325);
			this.grpExibir.Name = "grpExibir";
			this.grpExibir.Size = new System.Drawing.Size(97, 168);
			this.grpExibir.TabIndex = 1;
			this.grpExibir.TabStop = false;
			this.grpExibir.Text = "Informações";
			// 
			// btnExibir
			// 
			this.btnExibir.Location = new System.Drawing.Point(7, 139);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(75, 23);
			this.btnExibir.TabIndex = 3;
			this.btnExibir.Text = "Exibir";
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
			// 
			// rdbEnd
			// 
			this.rdbEnd.AutoSize = true;
			this.rdbEnd.Location = new System.Drawing.Point(7, 66);
			this.rdbEnd.Name = "rdbEnd";
			this.rdbEnd.Size = new System.Drawing.Size(71, 17);
			this.rdbEnd.TabIndex = 2;
			this.rdbEnd.TabStop = true;
			this.rdbEnd.Text = "Endereço";
			this.rdbEnd.UseVisualStyleBackColor = true;
			// 
			// rdbContato
			// 
			this.rdbContato.AutoSize = true;
			this.rdbContato.Location = new System.Drawing.Point(7, 43);
			this.rdbContato.Name = "rdbContato";
			this.rdbContato.Size = new System.Drawing.Size(62, 17);
			this.rdbContato.TabIndex = 1;
			this.rdbContato.TabStop = true;
			this.rdbContato.Text = "Contato";
			this.rdbContato.UseVisualStyleBackColor = true;
			// 
			// rdbPessoais
			// 
			this.rdbPessoais.AutoSize = true;
			this.rdbPessoais.Location = new System.Drawing.Point(7, 20);
			this.rdbPessoais.Name = "rdbPessoais";
			this.rdbPessoais.Size = new System.Drawing.Size(67, 17);
			this.rdbPessoais.TabIndex = 0;
			this.rdbPessoais.TabStop = true;
			this.rdbPessoais.Text = "Pessoais";
			this.rdbPessoais.UseVisualStyleBackColor = true;
			// 
			// grbPesquisa
			// 
			this.grbPesquisa.Controls.Add(this.label3);
			this.grbPesquisa.Controls.Add(this.label2);
			this.grbPesquisa.Controls.Add(this.label1);
			this.grbPesquisa.Controls.Add(this.btnPesquisa);
			this.grbPesquisa.Controls.Add(this.txtPesquisa);
			this.grbPesquisa.Controls.Add(this.cmbCampo);
			this.grbPesquisa.Controls.Add(this.cmbExibe);
			this.grbPesquisa.Location = new System.Drawing.Point(116, 325);
			this.grbPesquisa.Name = "grbPesquisa";
			this.grbPesquisa.Size = new System.Drawing.Size(190, 168);
			this.grbPesquisa.TabIndex = 2;
			this.grbPesquisa.TabStop = false;
			this.grbPesquisa.Text = "Pesquisa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Coluna";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Exibição";
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.Location = new System.Drawing.Point(7, 139);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisa.TabIndex = 3;
			this.btnPesquisa.Text = "Pesquisar";
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(59, 75);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(121, 20);
			this.txtPesquisa.TabIndex = 2;
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(59, 47);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(121, 21);
			this.cmbCampo.TabIndex = 1;
			// 
			// cmbExibe
			// 
			this.cmbExibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExibe.FormattingEnabled = true;
			this.cmbExibe.Location = new System.Drawing.Point(59, 20);
			this.cmbExibe.Name = "cmbExibe";
			this.cmbExibe.Size = new System.Drawing.Size(121, 21);
			this.cmbExibe.TabIndex = 0;
			this.cmbExibe.SelectedIndexChanged += new System.EventHandler(this.cmbExibe_SelectedIndexChanged);
			// 
			// grbModificar
			// 
			this.grbModificar.Controls.Add(this.label6);
			this.grbModificar.Controls.Add(this.txtAlt);
			this.grbModificar.Controls.Add(this.cmbAltCampo);
			this.grbModificar.Controls.Add(this.label5);
			this.grbModificar.Controls.Add(this.label4);
			this.grbModificar.Controls.Add(this.txtID);
			this.grbModificar.Controls.Add(this.btnExcluir);
			this.grbModificar.Controls.Add(this.btnAlterar);
			this.grbModificar.Location = new System.Drawing.Point(313, 325);
			this.grbModificar.Name = "grbModificar";
			this.grbModificar.Size = new System.Drawing.Size(389, 168);
			this.grbModificar.TabIndex = 3;
			this.grbModificar.TabStop = false;
			this.grbModificar.Text = "Modificar";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Valor";
			// 
			// txtAlt
			// 
			this.txtAlt.Location = new System.Drawing.Point(52, 74);
			this.txtAlt.Name = "txtAlt";
			this.txtAlt.Size = new System.Drawing.Size(181, 20);
			this.txtAlt.TabIndex = 6;
			// 
			// cmbAltCampo
			// 
			this.cmbAltCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAltCampo.FormattingEnabled = true;
			this.cmbAltCampo.Location = new System.Drawing.Point(52, 47);
			this.cmbAltCampo.Name = "cmbAltCampo";
			this.cmbAltCampo.Size = new System.Drawing.Size(181, 21);
			this.cmbAltCampo.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Campo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(52, 21);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 20);
			this.txtID.TabIndex = 2;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(158, 19);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 1;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(6, 139);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 0;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(708, 470);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 23);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// FrmConsultaProf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbModificar);
			this.Controls.Add(this.grbPesquisa);
			this.Controls.Add(this.grpExibir);
			this.Controls.Add(this.dgvProf);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmConsultaProf";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmConsultaAluno";
			this.Load += new System.EventHandler(this.FrmConsultaProf_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
			this.grpExibir.ResumeLayout(false);
			this.grpExibir.PerformLayout();
			this.grbPesquisa.ResumeLayout(false);
			this.grbPesquisa.PerformLayout();
			this.grbModificar.ResumeLayout(false);
			this.grbModificar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProf;
		private System.Windows.Forms.GroupBox grpExibir;
		private System.Windows.Forms.Button btnExibir;
		private System.Windows.Forms.RadioButton rdbEnd;
		private System.Windows.Forms.RadioButton rdbContato;
		private System.Windows.Forms.RadioButton rdbPessoais;
		private System.Windows.Forms.GroupBox grbPesquisa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.ComboBox cmbExibe;
		private System.Windows.Forms.GroupBox grbModificar;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAlt;
		private System.Windows.Forms.ComboBox cmbAltCampo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
	}
}