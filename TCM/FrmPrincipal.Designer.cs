﻿namespace TCM
{
    partial class FrmPrincipal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarMatricularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// alunoToolStripMenuItem
			// 
			this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMatricularToolStripMenuItem});
			this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
			this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.alunoToolStripMenuItem.Text = "Aluno";
			// 
			// cadastrarMatricularToolStripMenuItem
			// 
			this.cadastrarMatricularToolStripMenuItem.Name = "cadastrarMatricularToolStripMenuItem";
			this.cadastrarMatricularToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.cadastrarMatricularToolStripMenuItem.Text = "Cadastrar/Matricular";
			this.cadastrarMatricularToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMatricularToolStripMenuItem_Click);
			// 
			// professorToolStripMenuItem
			// 
			this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1});
			this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
			this.professorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.professorToolStripMenuItem.Text = "Professor";
			// 
			// cadastrarToolStripMenuItem1
			// 
			this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
			this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
			// 
			// funcionárioToolStripMenuItem
			// 
			this.funcionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
			this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
			this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.funcionárioToolStripMenuItem.Text = "Funcionário";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// logOffToolStripMenuItem
			// 
			this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
			this.logOffToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.logOffToolStripMenuItem.Text = "LogOff";
			this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.ToolTipText = "Fecha o programa";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 533);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPrincipal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarMatricularToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
	}
}