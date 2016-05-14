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
    public partial class FrmCadastroFunc : Form
    {
		ClasseConexao conexao;
		DataSet ds;

        public FrmCadastroFunc()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroFunc_Load(object sender, EventArgs e)
        {
			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");

			cmbCargo.Items.Add("Gerente");
			cmbCargo.Items.Add("Funcionário");
        }

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			try
			{
				String nome = txtNome.Text;
				String sexo = cmbSexo.SelectedItem.ToString();
				String rg = txtRG.Text;
				String cpf = txtCPF.Text;
				String rua = txtRua.Text;
				int numero = int.Parse(txtNum.Text);
				String bairro = txtBairro.Text;
				String cep = txtCEP.Text;
				String cidade = txtCidade.Text;
				String estado = txtEstado.Text;
				String fone = txtFone.Text;
				String cel = txtCel.Text;
				String email = txtEmail.Text;
				String senha = txtSenha.Text;
				String cargo = cmbCargo.SelectedItem.ToString();

				//checa se os textbox, maskedtextbox estao vazios
				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

				var emptyMask = from mb in this.Controls.OfType<MaskedTextBox>() where string.IsNullOrEmpty(mb.Text) select mb;

				//var emptyCmb = from cmb in this.Controls.OfType<ComboBox>() where string.IsNullOrWhiteSpace(cmb.) select cmb;

				if (emptyTextboxes.Any() || emptyMask.Any() /*|| emptyCmb.Any()*/)
				{
					MessageBox.Show("Por favor preencha todos os campos e selecione as opções apropriadas");
				}
				else
				{
					//checa o nome para ver se já nao existe
					string check = string.Format("SELECT NOME FROM FUNCIONARIO WHERE NOME = '{0}'", nome);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0) //se ja existe
					{
						MessageBox.Show("Esse funcionário já existe nos registros");
					}
					else //se nao existe
					{
						//MessageBox.Show(curso + "\n" + periodo);

						conexao = new ClasseConexao();
						ds = new DataSet();

						string sql = String.Format("INSERT INTO FUNCIONARIO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha, cargo);
						MessageBox.Show(sql);
						ds = conexao.executarSQL(sql);
					}
				}
			}
			catch (Exception erro)
			{
			}
		}
	}
}
