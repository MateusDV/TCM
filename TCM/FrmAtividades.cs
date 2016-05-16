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
	public partial class FrmAtividades : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		Compartilha comp = new Compartilha();

		protected String[] ativ = { "ID_ATIV", "NOME", "DESCRICAO", "ID_PROFESSOR" };

		public FrmAtividades()
		{
			InitializeComponent();
		}

		private void formataGrid()
		{
			//permite personalizar o grid
			dgvAtiv.AutoGenerateColumns = true;
			dgvAtiv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvAtiv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvAtiv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgvAtiv.RowsDefaultCellStyle.BackColor = Color.White;
			dgvAtiv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//altera o nome das colunas
			//dgvAtiv.Columns[0].HeaderText = "ID";
			//dgvAtiv.Columns[1].HeaderText = "NOME";
			//dgvAtiv.Columns[2].HeaderText = "FONE";
			//dgvAtiv.Columns[3].HeaderText = "NIVEL";
			//grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
			//dgvAtiv.Columns[0].Width = 20;
			//dgvAtiv.Columns[1].Width = 150;
			//dgvAtiv.Columns[2].Width = 80;
			//dgvAtiv.Columns[3].Width = 50;
			//formata a coluna para moeda (currency)
			//grid.Columns[3].DefaultCellStyle.Format = "c";
			//ao clicar, seleciona a linha inteira
			dgvAtiv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgvAtiv.MultiSelect = false;
			// exibe vazio no lugar de null
			//dgvAtiv.DefaultCellStyle.NullValue = "";
			//Expande a célula automáticamente
			dgvAtiv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//alinha à direita os campos moeda
			//grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAtiv.ReadOnly = true;
			dgvAtiv.RowHeadersVisible = false;
			dgvAtiv.AllowUserToAddRows = false;
		}

		private void atualizar_grid(String sql)
		{
			if (sql.Equals(null) || sql.Equals(""))
			{
				//placeholder
				sql = "SELECT TOP 0 0";
			}
			conexao = new ClasseConexao();
			ds = new DataSet();
			ds = conexao.executarSQL(sql);
			dgvAtiv.DataSource = ds.Tables[0];
			formataGrid();
		}

		private void FrmAtividades_Load(object sender, EventArgs e)
		{
			String nivel = comp.Nivel;
			String id = comp.Id;

			if (nivel.Equals("gerente", StringComparison.InvariantCultureIgnoreCase))
			{
				grbCriar.Enabled = false;
				grbMod.Enabled = false;
			}
			else if (nivel.Equals("professor", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else
			{
				grbCriar.Visible = false;
				grbMod.Visible = false;
			}

			cmbCampo.Items.AddRange(ativ);

			lblCar.Text = "100";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			String nivel = comp.Nivel;
			String id = comp.Id;

			if (cmbCampo.SelectedItem.Equals("ID_PROFESSOR") && nivel.Equals("Professor", StringComparison.InvariantCultureIgnoreCase))
			{
				txtValor.Text = id;
				txtValor.Enabled = false;
			}
			else
			{
				txtValor.Enabled = true;
			}
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			String campo = cmbCampo.SelectedItem.ToString();
			String valor = txtValor.Text;
			String query = String.Format("SELECT * FROM ATIVIDADE WHERE '{0}' LIKE '%{1}%'", campo, valor);

			atualizar_grid(query);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			lblCar.Text = (100 - txtDesc.Text.Length).ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String nome = txtNome.Text;
			String desc = txtDesc.Text;
			String id = comp.Id;

			var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

			if (emptyTextboxes.Any() || desc.Trim().Length > 100)
			{
				MessageBox.Show("Por favor preencha o nome e a descrição, e tenha certeza que a descrição tenha menos de 100 caracteres");
			}
			else
			{
				conexao = new ClasseConexao();
				ds = new DataSet();

				string check = string.Format("SELECT * FROM ATIVIDADE WHERE NOME = '{0}'", nome);
				ds = conexao.executarSQL(check);
				int qnt = 0;
				qnt = ds.Tables[0].Rows.Count;

				if (qnt > 0) //se ja existe
				{
					MessageBox.Show("Essa atividade já existe nos registros");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					String query = String.Format("INSERT INTO ATIVIDADE VALUES ('{0}','{1}', '{2}')", nome, desc, id);

					ds = conexao.executarSQL(query);

					String atl = String.Format("SELECT * FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}'", id);
					atualizar_grid(atl);
				}
			}
		}
	}
}
