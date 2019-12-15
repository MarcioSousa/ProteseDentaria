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

namespace View
{
    public partial class FrmSplash : Form
    {
        int tempo = 0;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            CarregaBanco();
            TempoSplash.Start();
        }

        private void CarregaBanco()
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                produtoNegocio.QtdeProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o Banco de Dados.\nMensagem: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TempoSplash_Tick(object sender, EventArgs e)
        {
            if(tempo >= 4)
            {
                TempoSplash.Stop();
                this.Close();
            }
            else
            {
                tempo++;
            }
        }
    }
}
