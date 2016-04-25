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
			int numero = int.Parse(txtNum.Text);
			int cep = int.Parse(txtCEP.Text);
			String cidade = txtCidade.Text;
			String estado = txtEstado.Text;
			String telefone = txtTelefone.Text;
			int curso;
			int periodo;

			var radioButton = grbCurso.Controls.OfType<RadioButton>()
					.Where(r => r.Checked).FirstOrDefault();
			if (radioButton == null)
			{
				curso = 0;
				MessageBox.Show("Por favor selecione um curso");
			}
			else
			{
				curso = int.Parse(radioButton.Tag.ToString());
			}

			radioButton = grbPeriodo.Controls.OfType<RadioButton>()
					.Where(r => r.Checked).FirstOrDefault();
			if (radioButton == null)
			{
				periodo = 0;
				MessageBox.Show("Por favor selecione um período");
			}
			else
			{
				periodo = int.Parse(radioButton.Tag.ToString());
			}

			MessageBox.Show(curso + "/n" + periodo);
			string check = string.Format("SELECT * FROM ALUNO WHERE NOME = '{0}'", nome);
			ds = conexao.executarSQL(check);
			int qnt = ds.Tables[0].Rows.Count;
			if (qnt > 0)
			{
				MessageBox.Show("Esse aluno já existe nos registros");
			}
			else
			{
				conexao = new ClasseConexao();
				ds = new DataSet();

				string sql = string.Format("INSERT INTO ALUNO VALUES ('{0}','{1}','{2}','{3}', {4}, {5},'{6}','{7}','{8}', {9}, {10})", nome, email, sexo, rua, numero, cep, cidade, estado, telefone, curso, periodo);
				MessageBox.Show(sql);
				ds = conexao.executarSQL(sql);
			}
		}
	}
}
