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
	public partial class FrmCadastroAluno : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		public FrmCadastroAluno()
		{
			InitializeComponent();
		}

		private void FrmCadastroAluno_Load(object sender, EventArgs e)
		{
			cmbSexo.Items.Add("Masculino");
			cmbSexo.Items.Add("Feminino");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			String nome = txtNome.Text;
			String email = txtEmail.Text;
			String sexo = cmbSexo.SelectedItem.ToString();
			String rua = txtRua.Text;
			String numero = txtNum.Text;
			String cep = txtCEP.Text;
			String cidade = txtCidade.Text;
			String estado = txtEstado.Text;
			String telefone = txtTelefone.Text;
			//String curso = grbCurso.
			//String periodo = rd

			//int num = int.Parse(numero);
			//int
			string check = string.Format("SELECT * FROM ALUNO WHERE NOME = '{0}'", nome);
			ds = conexao.executarSQL(check);
			int qnt = ds.Tables[0].Rows.Count;
			if (qnt > 0)
			{
				MessageBox.Show("Esse aluno já existe nos registros");
			}
			else
			{
				string sql = string.Format("INSERT INTO ALUNO (NOME, EMAIL, SEXO, RUA, NUMERO, CEP, CIDADE, ESTADO, TELEFONE) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", nome, email, sexo, rua, numero, cep, cidade, estado, telefone);
				MessageBox.Show(sql);
				ds = conexao.executarSQL(sql);
			}
		}
	}
}
