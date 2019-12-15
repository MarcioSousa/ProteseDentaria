using Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FrmNovoPedido : Form
    {
        ProdutoNegocio produtoNegocio = new ProdutoNegocio();
        List<Produto> produtos = new List<Produto>();
        List<ItemPedido> itemPedidos = new List<ItemPedido>();
        Empresa empresa = new Empresa();
        Pedido pedido = new Pedido();

        bool novoPedido;
        bool novoItemPedido;

        public FrmNovoPedido(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            novoPedido = true;
        }

        public FrmNovoPedido(Empresa empresa, Pedido pedido)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.pedido = pedido;
            novoPedido = false;
        }

        private void TxtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void TxtCodigoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
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
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void TxtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            LblCodigoEmpresa.Text = empresa.Codigo.ToString();

            if (empresa.Empresanome == "")
            {
                LblEmpresaDentista.Text = empresa.Dentistadono;
                TxtCliente.Text = empresa.Dentistadono;
                TxtCliente.Enabled = false;
            }
            else
            {
                LblEmpresaDentista.Text = empresa.Empresanome;
            }

            produtos = produtoNegocio.ProcurarPorCodigoOuNome(0, "");

            for (int t = 0; t < produtos.Count; t++)
            {
                TxtNomeProduto.AutoCompleteCustomSource.Add(produtos[t].Nome);
            }

            if (!novoPedido)
            {
                TxtCodigoPedido.Text = pedido.Codigo.ToString();
                CarregaGridItemPedido();
                TxtCodigoProduto.Focus();
                SomarGridPedido();
            }
            novoItemPedido = true;

            CbxEntrega.Checked = false;
        }

        private void TxtCodigoPedido_Leave(object sender, EventArgs e)
        {
            if (novoPedido)
            {
                if (TxtCodigoPedido.Text != "")
                {
                    PedidoNegocio pedidoNegocio = new PedidoNegocio();

                    if (pedidoNegocio.VerificarCodigo(Convert.ToInt32(TxtCodigoPedido.Text)))
                    {
                        MessageBox.Show("Código Já existe, digite outro código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigoPedido.Focus();
                    }
                }
            }
        }

        private void CarregarNomeProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Codigo.ToString() == TxtCodigoProduto.Text)
                {
                    TxtNomeProduto.Text = produtos[t].Nome;
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtNomeProduto.Text = "";
            }
        }

        private void CarregarCodigoProduto()
        {
            bool passou = false;

            for (int t = 0; t < produtos.Count; t++)
            {
                if (produtos[t].Nome == TxtNomeProduto.Text)
                {
                    TxtCodigoProduto.Text = produtos[t].Codigo.ToString();
                    passou = true;
                    break;
                }
            }

            if (passou == false)
            {
                TxtCodigoProduto.Text = "";
            }
        }

        private void TxtCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodigoProduto.Focused)
            {
                CarregarNomeProduto();
            }

        }

        private void TxtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtNomeProduto.Focused)
            {
                CarregarCodigoProduto();
            }
        }

        private void CarregaGridItemPedido()
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();

                itemPedidos = itemPedidoNegocio.ItemPedidos(Convert.ToInt32(TxtCodigoPedido.Text));

                for (int t = 0; t < itemPedidos.Count; t++)
                {
                    itemPedidos[t].Total = itemPedidos[t].Qtde * itemPedidos[t].ValorUnid;
                    if (itemPedidos[t].Dataentrega == null)
                    {
                        DgvItensProduto.Rows.Add(itemPedidos[t].Codigo, itemPedidos[t].Codigoproduto, itemPedidos[t].NomeProduto, itemPedidos[t].Paciente, itemPedidos[t].ValorUnid, itemPedidos[t].Qtde, itemPedidos[t].Total, "");
                    }
                    else
                    {
                        DgvItensProduto.Rows.Add(itemPedidos[t].Codigo, itemPedidos[t].Codigoproduto, itemPedidos[t].NomeProduto, itemPedidos[t].Paciente, itemPedidos[t].ValorUnid, itemPedidos[t].Qtde, itemPedidos[t].Total, itemPedidos[t].Dataentrega);
                    }

                    BtnEditar.Visible = true;
                    BtnRemover.Visible = true;
                    BtnEntrega.Visible = true;
                    BtnFinalizarPedido.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os pedidos feitos.\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GravarPedido()
        {
            //GravarPedido();
            //if (TxtCodigoPedido.Text.Trim() != "")
            //{
            //    if (TxtCliente.Text.Trim() != "")
            //    {
            //        if (TxtPaciente.Text.Trim() != "")
            //        {
            //            try
            //            {
            //                if (!edicao)
            //                {
            //                    //Gravando novo pedido no banco de dados.
            //                    Pedido pedido = new Pedido(Convert.ToInt32(TxtCodigoPedido.Text), Convert.ToInt32(LblCodigoEmpresa.Text), TxtCliente.Text, TxtPaciente.Text, DtpEntrada.Value, null);
            //                    PedidoNegocio pedidoNegocio = new PedidoNegocio();

            //                    LblCodigoPedido.Text = Convert.ToInt32(pedidoNegocio.Inserir(pedido)).ToString();

            //                    TxtCodigoPedido.Enabled = false;
            //                    DtpEntrada.Enabled = false;
            //                    TxtCliente.Enabled = false;
            //                    TxtPaciente.Enabled = false;
            //                    TxtCodigoProduto.Focus();
            //                }
            //                else
            //                {
            //                    //Editando Pedido já do banco de dados.
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Erro ao gravar: Mensagem: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                LblCodigoPedido.Text = "";
            //            }

            //        }
            //        else
            //        {
            //            TxtPaciente.Focus();
            //        }
            //    }
            //    else
            //    {
            //        TxtCliente.Focus();
            //    }
            //}
            //else
            //{
            //    TxtCodigoPedido.Focus();
            //}
        }

        private void GravarItemPedido()
        {
            //if (TxtNomeProduto.Text != "")
            //{
            //    if (TxtQtde.Text != "")
            //    {
            //        //========================================
            //        //===== SALVAR NA TABELA ITEMPRODUTO =====
            //        //========================================
            //        ProdutoNegocio produtoNegocio = new ProdutoNegocio();
            //        ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
            //        List<Produto> produtos = new List<Produto>();

            //        produtos = produtoNegocio.ProcurarPorCodigoOuNome(Convert.ToInt32(TxtCodigoProduto.Text), "");

            //        if (produtos.Count > 0)
            //        {
            //            ItemPedido itemPedido = new ItemPedido(null, Convert.ToInt32(TxtCodigoProduto.Text), Convert.ToInt32(TxtCodigoPedido.Text), produtos[0].Valor, Convert.ToInt32(TxtQtde.Text));
            //            itemPedidoNegocio.Inserir(itemPedido);

            //            CarregaGridItemPedido();
            //            SomarGridPedido();
            //            TxtCodigoProduto.Text = "";
            //            TxtQtde.Text = "";
            //            TxtCodigoProduto.Focus();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Não foi encontrado o código do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Digite a quantidade de produtos feitos nesse pedido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Produto inválido! Digite um código do produto válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void SomarGridPedido()
        {
            try
            {
                double somaTotal = 0;

                for (int t = 0; t < DgvItensProduto.Rows.Count; t++)
                {
                    somaTotal = somaTotal + Convert.ToDouble(DgvItensProduto.Rows[t].Cells[6].Value);
                }

                LblTotal.Text = somaTotal.ToString("C");
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar a soma.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvItensProduto.Rows.Count == 0)
                {
                    if (MessageBox.Show("Com esse método, será excluído todo o pedido feito.\nDeseja Continuar?", "Cancelamento de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                        PedidoNegocio pedidoNegocio = new PedidoNegocio();

                        itemPedidoNegocio.ExcluirPedido(pedido.Codigo);
                        pedidoNegocio.Excluir(pedido.Codigo);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por SEGURANÇA, Remova todos os produtos feitos nesse pedido clicando em 'Remover Produto'!", "Cancelamento Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível cancelar o Pedido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            TxtCodigoProduto.Text = "";
            TxtNomeProduto.Text = "";
            TxtQtde.Text = "";
            TxtPaciente.Text = "";
            TxtCodigoProduto.Focus();
        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigoPedido.Text != "")
                {
                    if (TxtCodigoProduto.Text != "" && TxtNomeProduto.Text != "" && TxtQtde.Text != "" && TxtPaciente.Text != "")
                    {
                        if (novoItemPedido)
                        {
                            double valor = produtoNegocio.ProcurarPorCodigo(Convert.ToInt32(TxtCodigoProduto.Text));

                            if (DtpEntrega.Visible == true)
                            {
                                DgvItensProduto.Rows.Add("", TxtCodigoProduto.Text, TxtNomeProduto.Text, TxtPaciente.Text, valor, TxtQtde.Text, valor * Convert.ToInt32(TxtQtde.Text), DtpEntrega.Text);
                            }
                            else
                            {
                                DgvItensProduto.Rows.Add("", TxtCodigoProduto.Text, TxtNomeProduto.Text, TxtPaciente.Text, valor, TxtQtde.Text, valor * Convert.ToInt32(TxtQtde.Text), "");
                            }

                            LimparCampos();
                            SomarGridPedido();
                            CbxEntrega.Checked = false;
                            BtnRemover.Visible = true;
                            BtnEditar.Visible = true;
                            BtnEntrega.Visible = true;
                            BtnFinalizarPedido.Visible = true;
                            BtnAdicionarProduto.Text = "Adicionar Produto";
                        }
                        else
                        {
                            double valor = produtoNegocio.ProcurarPorCodigo(Convert.ToInt32(TxtCodigoProduto.Text));
                            int codigoitempedido = 0;
                            
                            if(DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value.ToString() != "")
                            {
                                codigoitempedido = Convert.ToInt32(DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value);
                            }

                            //DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = DtpEntrega.Value;

                            //DgvItensProduto.Rows.RemoveAt(DgvItensProduto.CurrentRow.Index);

                            if (DtpEntrega.Visible == true)
                            {
                                if (codigoitempedido != 0)
                                {
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value = codigoitempedido;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[1].Value = TxtCodigoProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[2].Value = TxtNomeProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[3].Value = TxtPaciente.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[4].Value = valor;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[5].Value = TxtQtde.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[6].Value = valor * Convert.ToInt32(TxtQtde.Text);
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = DtpEntrega.Text;
                                }
                                else
                                {
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value = "";
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[1].Value = TxtCodigoProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[2].Value = TxtNomeProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[3].Value = TxtPaciente.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[4].Value = valor;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[5].Value = TxtQtde.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[6].Value = valor * Convert.ToInt32(TxtQtde.Text);
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = "";
                                }
                            }
                            else
                            {
                                if (codigoitempedido != 0)
                                {
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value = codigoitempedido;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[1].Value = TxtCodigoProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[2].Value = TxtNomeProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[3].Value = TxtPaciente.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[4].Value = valor;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[5].Value = TxtQtde.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[6].Value = valor * Convert.ToInt32(TxtQtde.Text);
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = "";
                                    //DgvItensProduto.Rows.Add(codigoitempedido, TxtCodigoProduto.Text, TxtNomeProduto.Text, TxtPaciente.Text, valor, TxtQtde.Text, valor * Convert.ToInt32(TxtQtde.Text), "");
                                }
                                else
                                {
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value = "";
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[1].Value = TxtCodigoProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[2].Value = TxtNomeProduto.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[3].Value = TxtPaciente.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[4].Value = valor;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[5].Value = TxtQtde.Text;
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[6].Value = valor * Convert.ToInt32(TxtQtde.Text);
                                    DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = "";
                                    //DgvItensProduto.Rows.Add("", TxtCodigoProduto.Text, TxtNomeProduto.Text, TxtPaciente.Text, valor, TxtQtde.Text, valor * Convert.ToInt32(TxtQtde.Text), "");
                                }
                            }

                            LimparCampos();
                            SomarGridPedido();
                            CbxEntrega.Checked = false;
                            BtnRemover.Visible = true;
                            BtnEditar.Visible = true;
                            BtnEntrega.Visible = true;
                            BtnFinalizarPedido.Visible = true;
                            BtnAdicionarProduto.Text = "Adicionar Produto";
                            BtnCancelar.Visible = true;
                            novoItemPedido = true;
                            DgvItensProduto.Enabled = true;
                            BtnCancelar.Visible = true;
                            BtnCancelarVoltar.Visible = false;
                        }
                    }
                    else
                    {
                        if (TxtCodigoProduto.Enabled == false)
                        {
                            if (CbxEntrega.Checked)
                            {
                                DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = DtpEntrega.Value;
                            }
                            else
                            {
                                DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value = "";
                            }

                            BtnAdicionarProduto.Text = "Adicionar Produto";
                            HabilitarBotoes();
                        }
                        else
                        {
                            if (TxtCodigoProduto.Text == "")
                            {
                                MessageBox.Show("Digite o Código do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCodigoProduto.Focus();
                            }
                            else if (TxtNomeProduto.Text == "")
                            {
                                MessageBox.Show("Digite o Nome do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtNomeProduto.Focus();
                            }
                            else if (TxtQtde.Text == "")
                            {
                                MessageBox.Show("Digite a quantidade de produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtQtde.Focus();
                            }
                            else if (TxtPaciente.Text == "")
                            {
                                MessageBox.Show("Digite o nome do Paciente que fez o pedido do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtPaciente.Focus();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite o código do pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCodigoPedido.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível salvar o produto, digite novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();

                if (novoPedido)
                {
                    //PEDIDO NOVO E CADASTRO DE ITEMPRDIDO
                    PedidoNegocio pedidoNegocio = new PedidoNegocio();
                    Pedido pedido = new Pedido(Convert.ToInt32(TxtCodigoPedido.Text), Convert.ToInt32(LblCodigoEmpresa.Text), LblEmpresaDentista.Text, null);

                    for (int t = 0; t < DgvItensProduto.Rows.Count; t++)
                    {
                        if (DgvItensProduto.Rows[t].Cells[7].Value.ToString() == "")
                        {
                            ItemPedido itemPedido = new ItemPedido(null, Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), Convert.ToInt32(TxtCodigoPedido.Text), Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString());
                            itemPedidoNegocio.Inserir(itemPedido);
                        }
                        else
                        {
                            ItemPedido itemPedido = new ItemPedido(null, Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), Convert.ToInt32(TxtCodigoPedido.Text), Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString(), Convert.ToDateTime(DgvItensProduto.Rows[t].Cells[7].Value.ToString()));
                            itemPedidoNegocio.Inserir(itemPedido);
                        }
                    }

                    pedidoNegocio.Inserir(pedido);
                }
                else
                {
                    //ALTERAÇÃO DE ITEMPEDIDO E ALTERACAO DE CODIGO DO PEDIDO
                    //VERIFICAR SE O CÓDIGO DE PEDIDO É O MESMO QUE O ANTERIOR E MODIFICAR COM O ITEMPEDIDO
                    if (Convert.ToInt32(TxtCodigoPedido.Text) != pedido.Codigo)
                    {
                        PedidoNegocio pedidoNegocio = new PedidoNegocio();

                        pedidoNegocio.AlterarCodigo(pedido, Convert.ToInt32(TxtCodigoPedido.Text));
                        itemPedidoNegocio.AlterarCodigoPedido(Convert.ToInt32(TxtCodigoPedido.Text), pedido.Codigo);
                        pedido.Codigo = Convert.ToInt32(TxtCodigoPedido.Text);
                    }

                    //VERIFICAR CADA LINHA DO DATAGRID PARA VER QUAL O PRODUTO NOVO CADASTRADO E FAZER UM INSERT (ITEM PEDIDO = ""),
                    //SE ESTIVER VAZIO, FAZER UM INSERT;
                    for (int t = 0; t < DgvItensProduto.Rows.Count; t++)
                    {
                        if (DgvItensProduto.Rows[t].Cells[0].Value.ToString() == "")
                        {
                            if (DgvItensProduto.Rows[t].Cells[7].Value.ToString() == "")
                            {
                                ItemPedido itemPedido = new ItemPedido(null, Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), pedido.Codigo, Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString(), null);
                                itemPedidoNegocio.Inserir(itemPedido);
                            }
                            else
                            {
                                ItemPedido itemPedido = new ItemPedido(null, Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), pedido.Codigo, Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString(), Convert.ToDateTime(DgvItensProduto.Rows[t].Cells[7].Value));
                                itemPedidoNegocio.Inserir(itemPedido);
                            }
                        }
                        else
                        {
                            if (DgvItensProduto.Rows[t].Cells[7].Value.ToString() == "")
                            {
                                //SE TIVER COM CÓDIGO ITEMPEDIDO, FAZER UM UPDATE;
                                ItemPedido itemPedido = new ItemPedido(Convert.ToInt32(DgvItensProduto.Rows[t].Cells[0].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), pedido.Codigo, Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString(), null);
                                itemPedidoNegocio.Alterar(itemPedido);
                            }
                            else
                            {
                                //SE TIVER COM CÓDIGO ITEMPEDIDO, FAZER UM UPDATE;
                                ItemPedido itemPedido = new ItemPedido(Convert.ToInt32(DgvItensProduto.Rows[t].Cells[0].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[1].Value), pedido.Codigo, Convert.ToDouble(DgvItensProduto.Rows[t].Cells[4].Value), Convert.ToInt32(DgvItensProduto.Rows[t].Cells[5].Value), DgvItensProduto.Rows[t].Cells[3].Value.ToString(), Convert.ToDateTime(DgvItensProduto.Rows[t].Cells[7].Value));
                                itemPedidoNegocio.Alterar(itemPedido);
                            }
                        }
                    }
                    //VERIFICAR COM UM FOR SE TEM UM PEDIDO QUE FOI DELETADO DO DATAGRID (SOMENTE COM ITEMPEDIDO != "").
                    int qtde = 0;
                    bool encontrado = false;
                    for (int t = 0; t < DgvItensProduto.Rows.Count; t++)
                    {
                        if (DgvItensProduto.Rows[t].Cells[0].Value.ToString() != "")
                        {
                            qtde++;
                        }
                    }

                    if (qtde != itemPedidos.Count)
                    {
                        for (int m = 0; m < itemPedidos.Count; m++)
                        {
                            for (int d = 0; d < DgvItensProduto.Rows.Count; d++)
                            {
                                if (DgvItensProduto.Rows[d].Cells[0].Value.ToString() != "")
                                {
                                    if (itemPedidos[m].Codigo == Convert.ToInt32(DgvItensProduto.Rows[d].Cells[0].Value))
                                    {
                                        encontrado = true;
                                        break;
                                    }
                                }
                            }

                            if (encontrado == false)
                            {
                                itemPedidoNegocio.Excluir(Convert.ToInt32(itemPedidos[m].Codigo));
                            }
                            encontrado = false;
                        }
                    }

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível fazer a o cadastro do Pedido!" + ex.Message, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxEntrega.Checked)
            {
                DtpEntrega.Visible = true;
            }
            else
            {
                DtpEntrega.Visible = false;
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente Remover o Produto Selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DgvItensProduto.Rows.RemoveAt(DgvItensProduto.CurrentRow.Index);
                    if (DgvItensProduto.Rows.Count == 0)
                    {
                        BtnRemover.Visible = false;
                        BtnEditar.Visible = false;
                        BtnEntrega.Visible = false;
                        BtnFinalizarPedido.Visible = false;
                    }
                    SomarGridPedido();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível Remover o Produto da lista!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            novoItemPedido = false;

            LblCodigoItemPedido.Text = DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[0].Value.ToString();
            TxtCodigoProduto.Text = DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[1].Value.ToString();
            TxtNomeProduto.Text = DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[2].Value.ToString();
            TxtQtde.Text = DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[5].Value.ToString();
            TxtPaciente.Text = DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[3].Value.ToString();

            if (DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value == null)
            {
                CbxEntrega.Checked = true;
                DtpEntrega.Value = Convert.ToDateTime(DgvItensProduto.Rows[DgvItensProduto.CurrentRow.Index].Cells[7].Value);
            }

            DgvItensProduto.Enabled = false;
            TxtCodigoProduto.Focus();
            BtnEditar.Visible = false;
            BtnCancelar.Visible = false;
            BtnRemover.Visible = false;
            BtnEntrega.Visible = false;
            BtnCancelarVoltar.Visible = true;
            BtnAdicionarProduto.Text = "Confirmar Edição";

        }

        private void BtnCancelarVoltar_Click(object sender, EventArgs e)
        {
            HabilitarBotoes();
        }

        private void HabilitarBotoes()
        {
            BtnAdicionarProduto.Text = "Adicionar Produto";
            CbxEntrega.Checked = false;
            TxtCodigoPedido.Enabled = true;
            TxtCodigoProduto.Enabled = true;
            TxtNomeProduto.Enabled = true;
            TxtQtde.Enabled = true;
            TxtPaciente.Enabled = true;

            BtnCancelarVoltar.Visible = false;
            BtnEntrega.Visible = true;
            BtnEditar.Visible = true;
            BtnRemover.Visible = true;
            BtnCancelar.Visible = true;
            DgvItensProduto.Enabled = true;
            BtnLimpar.Visible = true;
            LimparCampos();
            novoItemPedido = true;
            BtnFinalizarPedido.Visible = true;
        }

        private void BtnEntrega_Click(object sender, EventArgs e)
        {
            BtnAdicionarProduto.Text = "Registrar Entrega";
            CbxEntrega.Checked = true;
            TxtCodigoPedido.Enabled = false;
            TxtCodigoProduto.Enabled = false;
            TxtNomeProduto.Enabled = false;
            TxtQtde.Enabled = false;
            TxtPaciente.Enabled = false;
            DgvItensProduto.Enabled = false;

            BtnRemover.Visible = false;
            BtnEditar.Visible = false;
            BtnLimpar.Visible = false;
            BtnEntrega.Visible = false;
            BtnCancelarVoltar.Visible = true;
            BtnFinalizarPedido.Visible = false;

            DtpEntrega.Focus();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}