using Model;
using Negocio;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmEmpresa : Form
    {
        bool novo;

        public FrmEmpresa()
        {
            InitializeComponent();
            DgvEmpresa.AutoGenerateColumns = false;
        }

        private void DesabilitarCampos()
        {
            BtnAdicionar.Visible = true;

            TxtCodigo.Enabled = false;
            TxtNome.Enabled = false;
            TxtDono.Enabled = false;
            MtbCep.Enabled = false;
            TxtRua.Enabled = false;
            TxtNumero.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            CbxUf.Enabled = false;
            TxtTelu.Enabled = false;
            TxtTeld.Enabled = false;

            BtnCancelar.Visible = false;
            BtnConfirmar.Visible = false;

            if (DgvEmpresa.Rows.Count == 0)
            {
                BtnEditar.Visible = false;
                BtnExcluir.Visible = false;
            }
            else
            {
                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
            }

            DgvEmpresa.Enabled = true;
        }

        private void HabilitaCampos()
        {
            BtnAdicionar.Visible = false;

            TxtCodigo.Enabled = true;
            TxtNome.Enabled = true;
            TxtDono.Enabled = true;
            MtbCep.Enabled = true;
            TxtRua.Enabled = true;
            TxtNumero.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            CbxUf.Enabled = true;
            TxtTelu.Enabled = true;
            TxtTeld.Enabled = true;

            BtnCancelar.Visible = true;
            BtnConfirmar.Visible = true;

            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;

            DgvEmpresa.Enabled = false;

            TxtCodigo.Focus();
        }

        private void BtnAdicionarEmpresa_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            LimpaCampos();
            novo = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            TxtCodigo.Focus();
            novo = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir a Empresa Selecionada?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string mensagem;
                    EmpresaNegocio empresaNegocio = new EmpresaNegocio();

                    mensagem = empresaNegocio.Excluir(Convert.ToInt32(TxtCodigo.Text));

                    if (mensagem == "0")
                    {
                        MessageBox.Show("Excluído com sucesso do Sistema.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridEmpresa();

                        if (DgvEmpresa.Rows.Count == 0)
                        {
                            LimpaCampos();
                            BtnEditar.Enabled = false;
                            BtnExcluir.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir a Cliente/Empresa", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir a Cliente/Empresa", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LimpaCampos()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtDono.Text = "";
            MtbCep.Text = "";
            TxtRua.Text = "";
            TxtNumero.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            CbxUf.Text = "";
            TxtTelu.Text = "";
            TxtTeld.Text = "";
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text != "" && TxtDono.Text != "")
                {
                    string mensagem;
                    EmpresaNegocio enderecoNegocio = new EmpresaNegocio();
                    Empresa empresa = new Empresa(Convert.ToInt32(TxtCodigo.Text), TxtNome.Text.Trim().ToUpper(), TxtDono.Text.Trim().ToUpper(), TxtRua.Text, TxtNumero.Text, TxtBairro.Text, TxtCidade.Text, CbxUf.Text, MtbCep.Text.Replace("-", ""), TxtTelu.Text.Replace(" ", ""), TxtTeld.Text.Replace(" ", ""));

                    if (novo)
                    {
                        //Novo Cadastro
                        mensagem = enderecoNegocio.Inserir(empresa).ToString();
                    }
                    else
                    {
                        //Edita Cadastro
                        mensagem = enderecoNegocio.Alterar(empresa, Convert.ToInt32(DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value));
                    }

                    if (mensagem == "0")
                    {
                        DesabilitarCampos();
                        LimpaCampos();
                        CarregaGridEmpresa();
                        novo = false;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir a Empresa do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (TxtCodigo.Text == "")
                    {
                        MessageBox.Show("Digite um Código para a Empresa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Nome da Dono da Empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtDono.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de erro.\n" + ex.Message, "Não Salvou", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            DesabilitarCampos();
            CarregaCampos();
            novo = false;
        }

        private void LocalizarCep()
        {
            if (MtbCep.TextLength == 9)
            {
                using (var ws = new Criative.WsCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var resultado = ws.consultaCEP(MtbCep.Text.Replace("-", ""));
                        TxtRua.Text = resultado.end;
                        TxtBairro.Text = resultado.bairro;
                        TxtCidade.Text = resultado.cidade;
                        CbxUf.Text = resultado.uf;
                        TxtNumero.Focus();
                    }
                    catch 
                    {
                        MtbCep.Text = "";
                        TxtRua.Text = "";
                        TxtBairro.Text = "";
                        TxtCidade.Text = "";
                        CbxUf.Text = "";
                    }
                }
            }
        }

        private void MtbCep_Leave(object sender, EventArgs e)
        {
            if (MtbCep.Text.Replace("-", "").ToString().Trim().Length == 8)
            {
                LocalizarCep();
            }
        }

        private void TxtNumero_Leave(object sender, EventArgs e)
        {
            if (MtbCep.Text.Replace("-", "").ToString().Trim().Length == 8)
            {
                if (TxtBairro.Text != "")
                {
                    if (TxtCidade.Text != "")
                    {
                        if (CbxUf.Text != "")
                        {
                            TxtTelu.Focus();
                        }
                        else
                        {
                            CbxUf.Focus();
                        }
                    }
                    else
                    {
                        TxtCidade.Focus();
                    }
                }
                else
                {
                    TxtBairro.Focus();
                }
            }
        }

        private void TxtTelu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

        }

        private void TxtTeld_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void TxtTelu_Leave(object sender, EventArgs e)
        {
            if (TxtTelu.Text != "")
            {
                if (TxtTelu.Text.Replace(" ", "").Length == 10 || TxtTelu.Text.Replace(" ", "").Length == 11)
                {
                    TxtTeld.Focus();
                }
                else
                {
                    MessageBox.Show("Digite:\n10 números se for número de Telefone;\nExemplo: 1122223333\n\n11 números se for Celular;\nDigite também o DDD;\nExemplo: 11911112222.");
                    TxtTelu.Text = "";
                }
            }
        }

        private void TxtTeld_Leave(object sender, EventArgs e)
        {
            if (TxtTeld.Text != "")
            {
                if (TxtTeld.Text.Replace(" ", "").Length == 10 || TxtTeld.Text.Replace(" ", "").Length == 11)
                {
                    BtnConfirmar.Focus();
                }
                else
                {
                    MessageBox.Show("Digite:\n10 números se for número de Telefone;\nExemplo: 11 2121 3222\n\n11 números se for Celular;\nDigite também o DDD;\nExemplo: 11 9 2525 2322.");
                    TxtTeld.Text = "";
                }
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            CarregaGridEmpresa();
        }

        private void CarregaGridEmpresa()
        {
            try
            {
                EmpresaNegocio enderecoNegocio = new EmpresaNegocio();
                DgvEmpresa.DataSource = null;
                DgvEmpresa.DataSource = enderecoNegocio.CarregaListaEmpresas();

                DgvEmpresa.Update();
                DgvEmpresa.Refresh();

                if(DgvEmpresa.Rows.Count == 0)
                {
                    BtnEditar.Visible = false;
                    BtnExcluir.Visible = false;

                    BtnCancelar.Visible = false;
                    BtnConfirmar.Visible = false;
                }
                else
                {
                    BtnEditar.Visible = true;
                    BtnExcluir.Visible = true;

                    BtnCancelar.Visible = true;
                    BtnConfirmar.Visible = true;
                }

                BtnConfirmar.Visible = false;
                BtnCancelar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os dados das Empresas.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregaCampos()
        {
            try
            {
                if (DgvEmpresa.Rows.Count != 0)
                {
                    TxtCodigo.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNome.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtDono.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtRua.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[3].Value.ToString();
                    TxtNumero.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[4].Value.ToString();
                    TxtBairro.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[5].Value.ToString();
                    TxtCidade.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[6].Value.ToString();
                    CbxUf.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[7].Value.ToString();
                    MtbCep.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[8].Value.ToString();
                    TxtTelu.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[9].Value.ToString();
                    TxtTeld.Text = DgvEmpresa.Rows[DgvEmpresa.CurrentRow.Index].Cells[10].Value.ToString();

                    BtnEditar.Enabled = true;
                    BtnExcluir.Enabled = true;
                }
                else
                {
                    LimpaCampos();
                    BtnEditar.Enabled = false;
                    BtnExcluir.Enabled = false;
                }
            }
            catch 
            {
                MessageBox.Show("Erro ao carregar os campos de texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            CarregaCampos();
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

        private void DgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}