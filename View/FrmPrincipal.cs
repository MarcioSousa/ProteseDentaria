using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Model;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            FrmSplash frmSplash = new FrmSplash();
            frmSplash.ShowDialog();
            InitializeComponent();

        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.ShowDialog();
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.ShowDialog();
        }

        private void AbtnDesenvolvedor_Click(object sender, EventArgs e)
        {
            FrmDesenvolvedor frmDesenvolvedor = new FrmDesenvolvedor();
            frmDesenvolvedor.ShowDialog();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.ShowDialog();
        }

        private void PedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.ShowDialog();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

    }
}
