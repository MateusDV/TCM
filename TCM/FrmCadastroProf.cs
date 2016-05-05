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
	public partial class FrmCadastroProf : Form
	{
		public FrmCadastroProf()
		{
			InitializeComponent();
		}

        private void FrmCadastroProf_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
	}
}
