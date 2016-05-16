namespace TCM
{
	partial class FrmAtividades
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
			this.dgvAtiv = new System.Windows.Forms.DataGridView();
			this.grbPesquisar = new System.Windows.Forms.GroupBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.grbCriar = new System.Windows.Forms.GroupBox();
			this.lblCar = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.grbMod = new System.Windows.Forms.GroupBox();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).BeginInit();
			this.grbPesquisar.SuspendLayout();
			this.grbCriar.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAtiv
			// 
			this.dgvAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtiv.Location = new System.Drawing.Point(12, 12);
			this.dgvAtiv.Name = "dgvAtiv";
			this.dgvAtiv.Size = new System.Drawing.Size(440, 481);
			this.dgvAtiv.TabIndex = 0;
			// 
			// grbPesquisar
			// 
			this.grbPesquisar.Controls.Add(this.btnPesquisar);
			this.grbPesquisar.Controls.Add(this.label2);
			this.grbPesquisar.Controls.Add(this.txtValor);
			this.grbPesquisar.Controls.Add(this.label1);
			this.grbPesquisar.Controls.Add(this.cmbCampo);
			this.grbPesquisar.Location = new System.Drawing.Point(458, 12);
			this.grbPesquisar.Name = "grbPesquisar";
			this.grbPesquisar.Size = new System.Drawing.Size(325, 104);
			this.grbPesquisar.TabIndex = 1;
			this.grbPesquisar.TabStop = false;
			this.grbPesquisar.Text = "Pesquisar";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(6, 73);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(52, 47);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(121, 20);
			this.txtValor.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Campo";
			// 
			// cmbCampo
			// 
			this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Location = new System.Drawing.Point(52, 19);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(121, 21);
			this.cmbCampo.TabIndex = 0;
			this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// grbCriar
			// 
			this.grbCriar.Controls.Add(this.lblCar);
			this.grbCriar.Controls.Add(this.label5);
			this.grbCriar.Controls.Add(this.label4);
			this.grbCriar.Controls.Add(this.txtDesc);
			this.grbCriar.Controls.Add(this.label3);
			this.grbCriar.Controls.Add(this.txtNome);
			this.grbCriar.Controls.Add(this.button1);
			this.grbCriar.Location = new System.Drawing.Point(458, 122);
			this.grbCriar.Name = "grbCriar";
			this.grbCriar.Size = new System.Drawing.Size(325, 200);
			this.grbCriar.TabIndex = 2;
			this.grbCriar.TabStop = false;
			this.grbCriar.Text = "Criar";
			// 
			// lblCar
			// 
			this.lblCar.AutoSize = true;
			this.lblCar.Location = new System.Drawing.Point(179, 144);
			this.lblCar.Name = "lblCar";
			this.lblCar.Size = new System.Drawing.Size(0, 13);
			this.lblCar.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(63, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Caracteres restantes: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Descrição";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(63, 46);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(242, 91);
			this.txtDesc.TabIndex = 3;
			this.txtDesc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(63, 20);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(121, 20);
			this.txtNome.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 171);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Criar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// grbMod
			// 
			this.grbMod.Location = new System.Drawing.Point(458, 328);
			this.grbMod.Name = "grbMod";
			this.grbMod.Size = new System.Drawing.Size(325, 135);
			this.grbMod.TabIndex = 3;
			this.grbMod.TabStop = false;
			this.grbMod.Text = "Modificar";
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(708, 470);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 23);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			// 
			// FrmAtividades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 505);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.grbMod);
			this.Controls.Add(this.grbCriar);
			this.Controls.Add(this.grbPesquisar);
			this.Controls.Add(this.dgvAtiv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAtividades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAtividades";
			this.Load += new System.EventHandler(this.FrmAtividades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAtiv)).EndInit();
			this.grbPesquisar.ResumeLayout(false);
			this.grbPesquisar.PerformLayout();
			this.grbCriar.ResumeLayout(false);
			this.grbCriar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAtiv;
		private System.Windows.Forms.GroupBox grbPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.GroupBox grbCriar;
		private System.Windows.Forms.GroupBox grbMod;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label lblCar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button button1;
	}
}