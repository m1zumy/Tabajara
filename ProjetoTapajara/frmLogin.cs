using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTapajara
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txtUsuario.Text;
            senha = Convert.ToInt32(txtSenha.Text);

            if (usuario == "admin" & senha == 123)
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuário ou senha Incorretos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }
    }
}
