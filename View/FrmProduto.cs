using Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FrmProduto : Form
    {
        bool novo;

        public FrmProduto()
        {
            InitializeComponent();
            DgvProduto.AutoGenerateColumns = false;
        }

        private void CarregaTodosProdutos()
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                DgvProduto.DataSource = produtoNegocio.ProdutosOrdenadoCodigo();

                DgvProduto.Update();
                DgvProduto.Refresh();

                if (BtnAdicionar.Enabled == true)
                {
                    if (DgvProduto.Rows.Count == 0)
                    {
                        BtnEditar.Visible = false;
                        BtnExcluir.Visible = false;
                        TxtPesquisa.Visible = false;
                    }
                    else
                    {
                        BtnEditar.Visible = true;
                        BtnExcluir.Visible = true;
                        TxtPesquisa.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregaTodosProdutos();
            CarregaTipos();
            CarregaQtdeProduto();
        }

        private void CarregaQtdeProduto()
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                LblQtde.Text = "Qtde Produtos: " + produtoNegocio.QtdeProdutos().ToString();
            }
            catch
            {
                MessageBox.Show("Ñão foi possível contabilizar a quantidade de produtos cadastrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (TxtPesquisa.Text != "")
            {
                if (decimal.TryParse(TxtPesquisa.Text, out decimal numero))
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtPesquisa.Text), "");
                }
                else
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    DgvProduto.DataSource = produtoNegocio.ProcurarPorCodigoOuNome(0, TxtPesquisa.Text);
                }

                DgvProduto.Update();
                DgvProduto.Refresh();

                if(DgvProduto.Rows.Count != 0)
                {
                    BtnEditar.Visible = true;
                    BtnExcluir.Visible = true;
                }
                else
                {
                    BtnEditar.Visible = false;
                    BtnExcluir.Visible = false;
                }
            }
            else
            {
                CarregaTodosProdutos();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            TxtPesquisa.Text = "";
            IniciarCadastro();
            TxtCodigo.Focus();
            novo = true;
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                TxtNome.Focus();
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValor.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (e.KeyChar == 13)
            {
                BtnCadastrar.Focus();
            }

        }
 
        private void LimpaCampos()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtValor.Text = "";
            TxtCodigo.Focus();
        }

        private void CarregaTipos()
        {
            try
            {
                List<Tipo> tipos = new List<Tipo>();
                TipoNegocio tipoNegocio = new TipoNegocio();

                tipos = tipoNegocio.CarregaListaTipo();

                CbxTipo.DataSource = tipos;
                CbxTipo.DisplayMember = "nome";
                CbxTipo.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os tipos de Produto. Aviso: " + ex.Message);
            }
        }

        private void IniciarCadastro()
        {
            GbxCUD.Visible = false;

            GbxDados.Visible = true;

            BtnCancelarRetornar.Visible = true;

            TxtPesquisa.Visible = false;

            DgvProduto.Enabled = false;

            TxtCodigo.Focus();
        }

        private void FinalizarCadastro()
        {
            GbxCUD.Visible = true;

            GbxDados.Visible = false;

            BtnCancelarRetornar.Visible = false;

            TxtPesquisa.Visible = true;

            DgvProduto.Enabled = true;

            CarregaTodosProdutos();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                if (TxtCodigo.Text != "")
                {
                    if (TxtNome.Text != "")
                    {
                        if (TxtValor.Text != "")
                        {
                            if (CbxTipo.Text != "")
                            {
                                Produto produto = new Produto(Convert.ToInt32(TxtCodigo.Text), TxtNome.Text, Convert.ToDouble(TxtValor.Text), Convert.ToInt32(CbxTipo.SelectedValue));
                                string mensagem, escolha;

                                if (novo)
                                {
                                    mensagem = produtoNegocio.Inserir(produto);
                                    escolha = "INSERIR";
                                }
                                else
                                {
                                    mensagem = produtoNegocio.Alterar(produto, Convert.ToInt32(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value));
                                    escolha = "ALTERAR";
                                }

                                if (mensagem != "0")
                                {
                                    MessageBox.Show("Não foi possível " + escolha + " o Produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    CarregaTodosProdutos();
                                    FinalizarCadastro();
                                    LimpaCampos();
                                    CarregaQtdeProduto();
                                }
                             
                            }
                            else
                            {
                                MessageBox.Show("Cadastre um Tipo de Produto clicando no botão de '+'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite o valor do produto no campo 'Valor'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtValor.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite o nome do produto no campo 'Nome'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNome.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Digite o código do produto no campo 'Código'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro para finalizar o cadastro.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FinalizarCadastro();
            LimpaCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value.ToString();
            TxtNome.Text = DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[1].Value.ToString();
            TxtValor.Text = Convert.ToDouble(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[2].Value).ToString("C2").Replace("R$", "");
            CbxTipo.SelectedValue = Convert.ToInt32(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[3].Value);
            IniciarCadastro();
            novo = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente deletar o cadastro selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    string aviso = produtoNegocio.Excluir(Convert.ToInt32(DgvProduto.Rows[DgvProduto.CurrentRow.Index].Cells[0].Value));

                    if (aviso != "0")
                    {
                        MessageBox.Show("Não foi possível excluir pois já foi feito a venda desse mesmo produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Excluido com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaQtdeProduto();
                        CarregaTodosProdutos();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o produto/serviço selecionado!" + ex.Message, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            FrmTipo frmTipo = new FrmTipo();
            frmTipo.ShowDialog();

            CarregaTipos();
        }

    }
}