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
	public partial class FrmConsultaProf : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		private String[] Pes = { "ID_PROFESSOR", "NOME", "SEXO", "RG", "CPF" };
		private String[] Con = { "ID_PROFESSOR", "NOME", "EMAIL", "TELEFONE" };
		private String[] End = { "ID_PROFESSOR", "NOME", "RUA", "NUM", "CEP", "CIDADE", "ESTADO" };
		private String[] Prf = { "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL" };
        private String pdr = "SELECT TOP 0 0";

		public FrmConsultaProf()
		{
			InitializeComponent();
		}

		private void FrmConsultaProf_Load(object sender, EventArgs e)
		{
			Compartilha comp = new Compartilha();
			string nivel = comp.Nivel;

			if (nivel.Equals("gerente", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else if (nivel.Equals("professor", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else
			{
				grbModificar.Visible = false;
			}

            Grid.atualizar_grid("", pdr, dgvProf);

			cmbExibe.Items.Add("Pessoais");
			cmbExibe.Items.Add("Contato");
			cmbExibe.Items.Add("Endereço");

			cmbAltCampo.Items.AddRange(Prf);
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			String query;
			if (rdbPessoais.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF FROM PROFESSOR";
			}
			else if (rdbContato.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR";
			}
			else if (rdbEnd.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR";
			}
			else
			{
				query = "";
				MessageBox.Show("Por favor selecione um modo de exibição.");
			}
			Grid.atualizar_grid(query, pdr, dgvProf);
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
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Contato"))
				{
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Endereço"))
				{
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else
				{
					query = "";
					MessageBox.Show("Por favor selecione um modo de exibição");
				}
                Grid.atualizar_grid(query, pdr, dgvProf);
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

				query = String.Format("UPDATE PROFESSOR SET {0} = '{1}' WHERE ID_PROFESSOR = '{2}'", campo, valor, ID);

				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

				if (emptyTextboxes.Any())
				{
					MessageBox.Show("Por favor tenha certeza de que todos os campos estão preenchidos.");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					string check = string.Format("SELECT * FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);
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
				String query = String.Format("DELETE FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);

				if (txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					string check = string.Format("SELECT * FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);
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
