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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
            DgvEmpresa.AutoGenerateColumns = false;
            DgvPedido.AutoGenerateColumns = false;
        }

        public void CarregaGridEmpresa()
        {
            try
            {
                EmpresaNegocio empresaNegocio = new EmpresaNegocio();

                DgvEmpresa.DataSource = empresaNegocio.CarregaListaEmpresas();

                DgvEmpresa.Update();
                DgvEmpresa.Refresh();

                if (DgvEmpresa.Rows.Count == 0)
                {
                    BtnEditar.Visible = false;
                }
                else
                {
                    BtnEditar.Visible = true;
                }
            }
            catch 
            {
                MessageBox.Show("Não foi possível carregar a lista de Empresas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaGridEmpresa();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(TxtPesquisa.Text != "")
                {
                    EmpresaNegocio empresaNegocio = new EmpresaNegocio();

                    if (decimal.TryParse(TxtPesquisa.Text, out decimal numero))
                    {
                        DgvEmpresa.DataSource = empresaNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtPesquisa.Text), "");
                    }
                    else
                    {
                        DgvEmpresa.DataSource = empresaNegocio.ProcurarPorCodigoOuNome(0, TxtPesquisa.Text);
                    }

                    DgvEmpresa.Update();
                    DgvEmpresa.Refresh();

                    if (DgvEmpresa.Rows.Count == 0)
                    {
                        DgvPedido.DataSource = null;
                        BtnEditar.Visible = false;
                    }
                    else
                    {
                        BtnEditar.Visible = true;
                    }
                }
                else
                {
                    CarregaGridEmpresa();
                }
            }
            catch 
            {
                MessageBox.Show("Não foi possível pesquisar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();

                DgvPedido.DataSource = pedidoNegocio.PedidosDeterminadaEmpresa(Convert.ToInt32(DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value));

                DgvPedido.Update();
                DgvPedido.Refresh();

                if(DgvPedido.Rows.Count == 0)
                {
                    BtnEditar.Visible = false;
                    BtnExcluirFechamento.Visible = false;
                    BtnFechamento.Visible = false;
                }
                else
                {
                    BtnEditar.Visible = true;
                    BtnExcluirFechamento.Visible = true;
                    BtnFechamento.Visible = true;
                }
            }
            catch 
            {
                MessageBox.Show("Não foi possível carregar os Pedidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNovoPedido_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(Convert.ToInt32(DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value), DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[2].Value.ToString(), DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[1].Value.ToString());

            FrmNovoPedido frmNovoPedido = new FrmNovoPedido(empresa);
            frmNovoPedido.ShowDialog();
            CarregaGridPedido();

            if(DgvPedido.Rows.Count == 0)
            {
                BtnEditar.Visible = false;
                BtnExcluirFechamento.Visible = false;
                BtnFechamento.Visible = false;
            }
            else
            {
                BtnEditar.Visible = true;
                BtnExcluirFechamento.Visible = true;
                BtnFechamento.Visible = true;
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvEmpresa.Rows.Count != 0 && DgvPedido.Rows.Count != 0)
            {
                Empresa empresa = new Empresa(Convert.ToInt32(DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value), DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[2].Value.ToString(), DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[1].Value.ToString());
                Pedido pedido = new Pedido(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[1].Value), DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[2].Value.ToString(), Convert.ToDateTime(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[3].Value));
                FrmNovoPedido frmNovoPedido = new FrmNovoPedido(empresa, pedido);
                frmNovoPedido.ShowDialog();
                CarregaGridPedido();
            }
            else
            {
                MessageBox.Show("Não foi possível carregar para a edição, é necessário ter uma empresa e um pedido para a edição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregaGridPedido()
        {
            PedidoNegocio pedidoNegocio = new PedidoNegocio();

            DgvPedido.DataSource = pedidoNegocio.PedidosDeterminadaEmpresa(Convert.ToInt32(DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value));

            DgvPedido.Update();
            DgvPedido.Refresh();
        }

        private void BtnFechamento_Click(object sender, EventArgs e)
        {
            FrmFechamento frmFechamento = new FrmFechamento(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value));
            frmFechamento.ShowDialog();
            CarregaGridPedido();
        }

        private void BtnExcluirFechamento_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exclusão de Fechamento!\nDeseja apagar o Fechamento selecionado abaixo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                MessageBox.Show(pedidoNegocio.ApagarDataFechamento(Convert.ToInt32(DgvPedido.Rows[DgvPedido.CurrentRow.Index].Cells[0].Value)).ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGridPedido();
            }
        }
    }
}
