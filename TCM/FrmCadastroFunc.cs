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
    public partial class FrmCadastroFunc : Form
    {
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
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");

			cmbCargo.Items.Add("Gerente");
			cmbCargo.Items.Add("Funcionário");
        }
    }
}
