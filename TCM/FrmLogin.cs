﻿using System;
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
    public partial class FrmLogin : Form
    {
		ClasseConexao conexao;
		DataSet ds;

        public FrmLogin()
        {
            InitializeComponent();
        }

        //faz a combinaçao alt+f4 se desabilitar
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        //botao login
        private void btnLogin_Click(object sender, EventArgs e)
        {
			////validacao de usuario e senha
			//if (txtUser.Text.Equals("1") && txtPass.Text.Equals("1"))
			//{
			//    this.Hide();
			//FrmPrincipal frmPrincipal = new FrmPrincipal();
			//frmPrincipal.Show();
			//}
			//else
			//{
			//    MessageBox.Show("Usuário ou senha incorretos");
			//}
			string email = txtUser.Text;
			string senha = txtPass.Text;

			conexao = new ClasseConexao();
			ds = new DataSet();
			Compartilha comp = new Compartilha(); //get & set nivel/id

			string sql = String.Format("SELECT * FROM FUNCIONARIO WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

			ds = conexao.executarSQL(sql);

			int conta = ds.Tables[0].Rows.Count;

			if (conta > 0)
			{
				comp.Nivel = ds.Tables[0].Rows[0]["CARGO"].ToString();
				comp.Id = ds.Tables[0].Rows[0]["ID_FUNCIONARIO"].ToString();
				comp.Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
				this.Hide();
				FrmPrincipal frmPrincipal = new FrmPrincipal();
				frmPrincipal.Show();

			}
			else
			{
				conexao = new ClasseConexao();
				ds = new DataSet();
				conta = 0;

				sql = String.Format("SELECT * FROM PROFESSOR WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

				ds = conexao.executarSQL(sql);

				conta = ds.Tables[0].Rows.Count;

				if (conta > 0)
				{
					comp.Nivel = "professor";
					comp.Id = ds.Tables[0].Rows[0]["ID_PROFESSOR"].ToString();
					comp.Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
					this.Hide();
					FrmPrincipal frmPrincipal = new FrmPrincipal();
					frmPrincipal.Show();
				}
				else
				{
					MessageBox.Show("Usuário ou senha inválidos.");
				}
			}
		}

        //botao cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sai da aplicacao
        }
	}
}
