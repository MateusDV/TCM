using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //botao sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //botao log off
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
			this.Dispose();
		}

		//MENU FUNCIONÁRIO--------------------------------------------------------------
        //botao cadastrar
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nao permite duas instancias do mesmo formulario
            if (Application.OpenForms.OfType<FrmCadastroFunc>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto");
            }
            else
            {
                FrmCadastroFunc frmCadastroF = new FrmCadastroFunc();
				frmCadastroF.Show();
				frmCadastroF.MdiParent = this;
            }
        }

		//MENU ALUNO---------------------------------------------------------------------------------
		//botao caddastrar
		private void cadastrarMatricularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmCadastroAluno>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmCadastroAluno frmCadastroA = new FrmCadastroAluno();
				frmCadastroA.Show();
				frmCadastroA.MdiParent = this;
			}
		}

		//botao consultar
		private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmConsultaAluno>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmConsultaAluno frmConsultaA = new FrmConsultaAluno();
				frmConsultaA.Show();
				frmConsultaA.MdiParent = this;
			}
		}

		//MENU PROFESSOR-----------------------------------------------------------------
		//botao cadastrar

		private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmCadastroProf>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmCadastroProf frmCadastroP = new FrmCadastroProf();
				frmCadastroP.Show();
				frmCadastroP.MdiParent = this;
			}
		}
	}
}
