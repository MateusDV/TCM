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
    public partial class FrmLogin : Form
    {
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
            //validacao de usuario e senha
            if (txtUser.Text.Equals("1") && txtPass.Text.Equals("1"))
            {
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos");
            }
        }

        //botao cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
