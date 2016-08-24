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
	public partial class FrmConsultaAluno : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		private String[] Pes = { "ID_ALUNO", "NOME", "SEXO", "CURSO", "PERIODO" };
		private String[] Con = { "ID_ALUNO", "NOME", "EMAIL", "TELEFONE" };
		private String[] End = { "ID_ALUNO", "NOME", "RUA", "NUM", "CEP", "CIDADE", "ESTADO" };
		private String[] Aln = { "NOME", "EMAIL", "SEXO", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CURSO", "PERIODO" };
        private String pdr = "SELECT TOP 0 0";

		public FrmConsultaAluno()
		{
			InitializeComponent();
		}

		private void FrmConsultaAluno_Load(object sender, EventArgs e)
		{
			Grid.atualizar_grid("", pdr, dgvAluno);

			cmbExibe.Items.Add("Pessoais");
			cmbExibe.Items.Add("Contato");
			cmbExibe.Items.Add("Endereço");

			cmbAltCampo.Items.AddRange(Aln);
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			String query;
			if (rdbPessoais.Checked == true)
			{
				query = "SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO INNER JOIN CURSO ON ALUNO.ID_CURSO=CURSO.ID_CURSO INNER JOIN PERIODO ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO;";
			}
			else if (rdbContato.Checked == true)
			{
				query = "SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO ";
			}
			else if (rdbEnd.Checked == true)
			{
				query = "SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO";
			}
			else
			{
				query = "";
				MessageBox.Show("Por favor selecione um modo de exibição.");
			}
			Grid.atualizar_grid(query, pdr, dgvAluno);
		}

		private void cmbExibe_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbExibe.SelectedItem.Equals("Pessoais"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Pes);
			}
			else if (cmbExibe.SelectedItem.Equals("Contato"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Con);
			}
			else if (cmbExibe.SelectedItem.Equals("Endereço"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(End);
			}
			else
			{
				cmbCampo.Items.Clear();
			}
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			try
			{
				String query;
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;

				if (cmbExibe.SelectedItem.Equals("Pessoais"))
				{
					if (cmbCampo.SelectedItem.Equals("CURSO"))
					{
						query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO INNER JOIN CURSO ON ALUNO.ID_CURSO=CURSO.ID_CURSO INNER JOIN PERIODO ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO WHERE CURSO.NOME LIKE '{0}%'", valor);
					}
					else if (cmbCampo.SelectedItem.Equals("PERIODO"))
					{
						query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO INNER JOIN CURSO ON ALUNO.ID_CURSO=CURSO.ID_CURSO INNER JOIN PERIODO ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO WHERE PERIODO.NOME LIKE '{0}%'", valor);
					}
					else
					{
						query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO INNER JOIN CURSO ON ALUNO.ID_CURSO=CURSO.ID_CURSO INNER JOIN PERIODO ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO WHERE ALUNO.{0} LIKE '%{1}%'", campo, valor);
					}
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Contato"))
				{
					query = String.Format("SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Endereço"))
				{
					query = String.Format("SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else
				{
					query = "";
					MessageBox.Show("Por favor selecione um modo de exibição");
				}
                Grid.atualizar_grid(query, pdr, dgvAluno);
			}
			catch (Exception erro) { }
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				String ID = txtID.Text;
				String campo = cmbAltCampo.SelectedItem.ToString();
				String valor = txtAlt.Text;
				String query = "";
				bool IsValido;

				if (campo.Equals("CURSO"))
				{
					if (valor.ToUpper().Equals("BASICO"))
					{
						valor = "1";
						IsValido = true;
					}
					else if (valor.ToUpper().Equals("INTERMEDIARIO"))
					{
						valor = "2";
						IsValido = true;
					}
					else if (valor.ToUpper().Equals("AVANCADO"))
					{
						valor = "3";
						IsValido = true;
					}
					else if(valor.ToUpper().Equals("EXPRESSO"))
					{
                        valor = "4";
						IsValido = true;
					}
                    else
                    {
                        IsValido = false;
                    }

					query = String.Format("UPDATE ALUNO SET ID_CURSO = '{0}' WHERE ID_ALUNO = '{1}'", valor, ID);
				}
				else if (campo.Equals("PERIODO"))
				{
					if (valor.ToUpper().Equals("MANHA"))
					{
						valor = "1";
						IsValido = true;
					}
					else if (valor.ToUpper().Equals("TARDE"))
					{
						valor = "2";
						IsValido = true;
					}
					else if (valor.ToUpper().Equals("NOITE"))
					{
						valor = "3";
						IsValido = true;
					}
					else
					{
						IsValido = false;
					}
					query = String.Format("UPDATE ALUNO SET ID_PERIODO = '{0}' WHERE ID_ALUNO = '{1}'", valor, ID);
				}
				else
				{
					query = String.Format("UPDATE ALUNO SET {0} = '{1}' WHERE ID_ALUNO = '{2}'", campo, valor, ID);
					IsValido = true;
				}

				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

				if (IsValido == false || emptyTextboxes.Any())
				{
					MessageBox.Show("Por favor digite o nome do curso e do período sem acentos, e tenha certeza de que todos os campos estão preenchidos.");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0)
					{
						var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
						if (confirm.Equals(DialogResult.Yes))
						{
							conexao = new ClasseConexao();
							ds = new DataSet();

							//MessageBox.Show(query);
							ds = conexao.executarSQL(query);
						}
						else
						{
							// If 'No', do something here.
						}
					}
				}
			}
			catch (Exception erro) { }
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			try
			{
				String ID = txtID.Text;
				String query = String.Format("DELETE FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);

				if (txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0) //se ja existe
					{
						var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
						if (confirm.Equals(DialogResult.Yes))
						{
							conexao = new ClasseConexao();
							ds = new DataSet();

							//MessageBox.Show(query);
							ds = conexao.executarSQL(query);
						}
						else
						{
							// If 'No', do something here.
						}
					}
					else //se nao existe
					{
						MessageBox.Show("Esse registro não existe!");
					}
				}
			}
			catch (Exception erro) { }
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
