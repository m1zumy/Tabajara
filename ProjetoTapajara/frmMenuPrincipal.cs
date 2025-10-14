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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente abrir = new frmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto abrir = new frmProduto();
            abrir.Show();
            this.Hide();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor abrir = new frmFornecedor();
            abrir.Show();
            this.Hide();
        }
    }
}
