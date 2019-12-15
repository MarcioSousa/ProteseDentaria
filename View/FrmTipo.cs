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
    public partial class FrmTipo : Form
    {
        bool novo;

        public FrmTipo()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            IniciarCadastro();
            novo = true;
        }

        private void IniciarCadastro()
        {
            BtnAdicionar.Visible = false;
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;

            TxtTipo.Visible = true;
            TxtTipo.Text = "";
            LblTipo.Visible = true;

            BtnCancelar.Visible = true;
            BtnConfirmar.Visible = true;

            DgvTipo.Enabled = false;


        }

        private void FinalizarCadastro()
        {
            BtnAdicionar.Visible = true;
            BtnEditar.Visible = true;
            BtnExcluir.Visible = true;

            TxtTipo.Visible = false;
            LblTipo.Visible = false;

            BtnCancelar.Visible = false;
            BtnConfirmar.Visible = false;

            DgvTipo.Enabled = true;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            IniciarCadastro();
            TxtTipo.Text = DgvTipo.Rows[DgvTipo.CurrentRow.Index].Cells[1].Value.ToString();
            novo = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o item selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TipoNegocio tipoNegocio = new TipoNegocio();
                    string mensagem = tipoNegocio.Excluir(Convert.ToInt32(DgvTipo.Rows[DgvTipo.CurrentRow.Index].Cells[0].Value));
                    if (mensagem != "0")
                    {
                        MessageBox.Show("Não foi possível excluir o Tipo Selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CarregaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o tipo selecionado.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        public void CarregaGrid()
        {
            try
            {
                TipoNegocio tipoNegocio = new TipoNegocio();
                DgvTipo.DataSource = tipoNegocio.CarregaListaTipo();

                if (DgvTipo.Rows.Count == 0)
                {
                    BtnEditar.Visible = false;
                    BtnExcluir.Visible = false;
                }
                else
                {
                    BtnEditar.Visible = true;
                    BtnExcluir.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar carregar os dados!\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FinalizarCadastro();
            CarregaGrid();
            TxtTipo.Text = "";
            novo = false;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoNegocio tipoNegocio = new TipoNegocio();

                if (novo && TxtTipo.Text.Trim() != "")
                {
                    Tipo tipo = new Tipo(0, TxtTipo.Text);
                    string mensagem = tipoNegocio.Inserir(tipo);
                    if (mensagem != "0")
                    {
                        MessageBox.Show("Não foi possível Inserir o Tipo Selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CarregaGrid();
                    }
                }
                else if (novo == false && TxtTipo.Text.Trim() != "")
                {
                    Tipo tipo = new Tipo(Convert.ToInt32(DgvTipo.Rows[DgvTipo.CurrentRow.Index].Cells[0].Value.ToString()), TxtTipo.Text);
                    string mensagem = tipoNegocio.Alterar(tipo);
                    if (mensagem != "0")
                    {
                        MessageBox.Show("Não foi possível Editar o Tipo Selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CarregaGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Escreva um Tipo no campo em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtTipo.Focus();
                }
                FinalizarCadastro();
                novo = false;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                if (novo)
                {
                    MessageBox.Show("Não foi possível Adicionar!\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível Editar!\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

    }
}